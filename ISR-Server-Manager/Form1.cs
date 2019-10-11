// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Reflection;
using ISRAPI;

namespace ISR_Server_Manager
{
    public partial class Form1 : Form
    {
        enum ServerMode
        {
            Running,
            Stopped
        };

        static PerformanceCounter cpuCounter;
        static PerformanceCounter ramCounter;
        private System.Windows.Forms.Timer timer1 = null;
        IRSMConfig config = IRSMConfig.LoadConfig();

        ServerMode serverStatus = ServerMode.Stopped;

        public Form1(string[] args)
        {
            InitializeComponent();

            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;

            this.Text = String.Format(this.Text,
                                appVersion.Major.ToString(),
                                appVersion.Minor.ToString(),
                                appVersion.Build.ToString(),
                                appVersion.Revision.ToString());

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();

            ServerAPI.ChatData += ServerAPI_ChatData;
            ServerAPI.ConsoleData += ServerAPI_ConsoleData;
            ServerAPI.PlayerData += ServerAPI_PlayerData;

            chkAutoRestart.Checked = config.ThreadMonitor;
            LogToCMD("IR.exe Server Auto Restart is " + (config.ThreadMonitor ? "Enabled" : "Disabled"));

            textBoxIRexeLocation.Text = config.IRExePath;
            try
            {
                if (args[1].Equals("-autostart")) buttonStartServer_Click(null, null);
            }
            catch
            {
                textBoxCMDOutput.Text = String.Empty;
                LogToCMD("No Valid Arguments have been Passed to the Application on start.");
            }
            LogToCMD("IR.exe location is - " + config.IRExePath);
        }


        List<string> OnlinePlayers = new List<string>();
        private void ServerAPI_PlayerData(object sender, PlayerEventArgs e)
        {
            switch (e.Activity)
            {
                case PlayerActivityEnum.Join:
                    OnlinePlayers.Add(e.Name);
                    break;
                case PlayerActivityEnum.Leave:
                    if (OnlinePlayers.Contains(e.Name))
                        OnlinePlayers.Remove(e.Name);
                    break;
                default:
                    break;
            }

            this.Invoke(new Action(() => //Invokes the following action on the same thread as this form, not the thread that requested it!!
            {
                toolPlayerCount.Text = "Player Count = " + lstboxOnlinePlayers.Items.Count.ToString();
                lstboxOnlinePlayers.DataSource = null;
                lstboxOnlinePlayers.DataSource = OnlinePlayers;
            }));
        }

        private void ServerAPI_ConsoleData(object sender, OutputEventArgs e)
        {
            this.Invoke(new Action(() => //Invokes the following action on the same thread as this form, not the thread that requested it!!
            {
                LogToCMD(e.Data);
            }));
        }

        private void ServerAPI_ChatData(object sender, OutputEventArgs e)
        {
            this.Invoke(new Action(() => //Invokes the following action on the same thread as this form, not the thread that requested it!!
            {
                LogToChat(e.Data);
            }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolCPU.Text = "CPU: " + CurrentCPUusage;
            toolMemory.Text = "Mem: " + CurrentRAMusage;

            bool isRunning = Process.GetProcessesByName("IR").Any();

            if (!isRunning)
            {
                if (config.ThreadMonitor && serverStatus == ServerMode.Running)
                {
                    this.Invoke(new Action(() => //Invokes the following action on the same thread as this form, not the thread that requested it!!
                    {
                        LogToCMD("IR.exe Server has crashed and will be restarted!!!!");
                        buttonStartServer_Click(sender, e);
                    }));
                }
            }
        }

        public static string CurrentCPUusage
        {
            get
            {
                return cpuCounter.NextValue() + " %";
            }
        }

        public static string CurrentRAMusage
        {
            get
            {
                return ramCounter.NextValue() + " MB";
            }
        }

        private void TextBoxSendChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ButtonSendChat_Click(sender, new EventArgs());
            }
        }

        private void TextBoxManualCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                buttonSendCommand_Click(sender, new EventArgs());
            }
        }

        private void Game_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                OutputToCMD(e.Data);
            }));
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                ServerAPI.Start(config.IRExePath, "-server");
                serverStatus = ServerMode.Running;  //Required to fix Auto-restart script.  If you stop server manually this is always in the stopped state and breaks it entirely.  
            }
            #pragma warning disable 0168
            catch (ProcessAlreadyStartedException ex)
            #pragma warning restore 0168
            {
            MessageBox.Show("Interstellar Rift is already running properly", "Launch error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #pragma warning disable 0168
            catch (IRRunningDetachedException ex)
            #pragma warning restore 0168
            {
            MessageBox.Show("Interstellar Rift is already running and not monitored by ISRSM.  Please terminate it and start the server from here.", "Launch error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStopServer_Click(object sender, EventArgs e)
        {
            ExitTimeForm etfDialog = new ExitTimeForm();

            etfDialog.Minutes = config.LastShutdownTime;
            etfDialog.RestartEnabled = config.RestartServer;

            if (etfDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!etfDialog.RestartEnabled)
                    serverStatus = ServerMode.Stopped;

                ServerAPI.ExitTimer(etfDialog.Minutes*60, "Server is Shutting Down in " + etfDialog.Minutes + " minutes!!");

                config.LastShutdownTime = etfDialog.Minutes;
                config.RestartServer = etfDialog.RestartEnabled;
                config.SaveConfig();
            }
            etfDialog.Dispose();
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            ServerAPI.ConsoleDirect(textBoxManualCmd.Text);
            textBoxManualCmd.Text = String.Empty;
        }

        private void buttonOpenDBReader_Click(object sender, EventArgs e)
        {
            LogToCMD("Feature not yet Implemented");
        }

        private void textBoxManualCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCMDList_Click(object sender, EventArgs e)
        {
            LogToCMD("Feature not yet Implemented");
        }

        private void ChkAutoRestart_CheckedChanged(object sender, EventArgs e)
        {
            Boolean IsAutoRestart = ((CheckBox)sender).Checked;
            LogToCMD("IR.exe Server Auto - Restart is " + ( IsAutoRestart ? "Enabled" : "Disabled" ) );
            config.ThreadMonitor = IsAutoRestart;
            config.SaveConfig();
        }

        #region CMD Logging

        private const String ISRSMTag = "MNGR";
        private const String ISRSvrTag = "ISRS";

        private void LogToCMD(String msg)
        {
            RawToCMD(ISRSMTag, msg);
        }

        private void OutputToCMD(String msg)
        {
            RawToCMD(ISRSvrTag, msg);
        }

        private void RawToCMD(String tag, String msg)
        {
            textBoxCMDOutput.AppendText(DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss") + " [" + tag + "] " + msg + "\r\n");
        }

        #endregion

        #region Chat Management

        private void LogToChat(String msg)
        {
            textBoxChatLog.AppendText(DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss") + " | " + msg + "\r\n");
        }

        #endregion

        private void buttonSelectFolderIRLocation_Click_1(object sender, EventArgs e)
        {
            if (irexeBrowser.ShowDialog() == DialogResult.OK)
            {
                textBoxIRexeLocation.Text = irexeBrowser.FileName;
            }
        }

        private void ButtonSaveLocation_Click(object sender, EventArgs e)
        {
            config.IRExePath = textBoxIRexeLocation.Text;
            config.SaveConfig();
        }

        private void ButtonSendChat_Click(object sender, EventArgs e)
        {
            LogToChat("Server: " + textBoxSendChat.Text);
            ServerAPI.MessageToAll(textBoxSendChat.Text);
            textBoxSendChat.Text = String.Empty;
        }
    }
}
