// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Diagnostics;
using System.Linq;

namespace ISRAPI
{
    internal class ServerConnection
    {
        Process game;

        public Boolean isServerRunning
        {
            get
            {
                return !(game == null);
            }
        }

        string pathToTheApp;
        string arguments;

        public ServerConnection(string pathToTheApp, string arguments)
        {
            this.pathToTheApp = pathToTheApp;
            this.arguments = arguments;
        }

        public void Start()
        {
            if (isServerRunning)
                throw new ProcessAlreadyStartedException("Server is already running.");

            if (isIRRunning())
                throw new IRRunningDetachedException("IR is already running out of process.");

            this.game = StartProcess();
        }

        public void ForceKill()
        {
            if (game != null)
            {
                try
                {
                    game.Kill();
                    game.Dispose();
                    game = null;
                }
                catch { }
            }
        }

        public void SendToConsole(String msg)
        {
            game.StandardInput.WriteLine(msg);
        }

        #region Private server management

        private Boolean isIRRunning()
        {
            return Process.GetProcesses().Where(p => p.ProcessName == "IR").Any();
        }

        Process StartProcess()
        {
            Process proc = new Process();

            proc.StartInfo.FileName = pathToTheApp;
            proc.StartInfo.Arguments = arguments;

            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.OutputDataReceived += Proc_OutputDataReceived;
            proc.ErrorDataReceived += Proc_ErrorDataReceived;
            proc.Exited += Proc_Exited;
            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();

            return proc;
        }

        private void Proc_Exited(object sender, System.EventArgs e)
        {
            game.Dispose();
            game = null;
        }

        #endregion

        #region Output Events

        public event EventHandler<OutputEventArgs> OutputData;
        public event EventHandler<OutputEventArgs> ErrorData;

        protected void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OutputData?.Invoke(this, new OutputEventArgs(e.Data));
        }

        private void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            ErrorData?.Invoke(this, new OutputEventArgs(e.Data));
        }

        #endregion
    }
}
