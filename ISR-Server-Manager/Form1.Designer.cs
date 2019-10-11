// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

namespace ISR_Server_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.irexeBrowser = new System.Windows.Forms.OpenFileDialog();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolPlayerCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.ilPushButton = new System.Windows.Forms.ImageList(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSaveLocation = new System.Windows.Forms.Button();
            this.buttonSelectFolderIRLocation = new System.Windows.Forms.Button();
            this.textBoxIRexeLocation = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.chOccurence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabServerManager = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scUpper = new System.Windows.Forms.SplitContainer();
            this.textBoxChatLog = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkAutoRestart = new System.Windows.Forms.CheckBox();
            this.buttonOpenDBReader = new System.Windows.Forms.Button();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSendChat = new System.Windows.Forms.Button();
            this.textBoxSendChat = new System.Windows.Forms.TextBox();
            this.lstboxOnlinePlayers = new System.Windows.Forms.ListBox();
            this.textBoxCMDOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxManualCmd = new System.Windows.Forms.TextBox();
            this.buttonCMDList = new System.Windows.Forms.Button();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ssMain.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabServerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scUpper)).BeginInit();
            this.scUpper.Panel1.SuspendLayout();
            this.scUpper.Panel2.SuspendLayout();
            this.scUpper.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // irexeBrowser
            // 
            this.irexeBrowser.DefaultExt = "exe";
            this.irexeBrowser.FileName = "IR.exe";
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPlayerCount,
            this.toolSpacer,
            this.toolCPU,
            this.toolMemory});
            this.ssMain.Location = new System.Drawing.Point(0, 413);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMain.Size = new System.Drawing.Size(1099, 22);
            this.ssMain.TabIndex = 3;
            // 
            // toolPlayerCount
            // 
            this.toolPlayerCount.Name = "toolPlayerCount";
            this.toolPlayerCount.Size = new System.Drawing.Size(95, 17);
            this.toolPlayerCount.Text = "Player Count: {0}";
            // 
            // toolSpacer
            // 
            this.toolSpacer.Name = "toolSpacer";
            this.toolSpacer.Size = new System.Drawing.Size(868, 17);
            this.toolSpacer.Spring = true;
            // 
            // toolCPU
            // 
            this.toolCPU.Name = "toolCPU";
            this.toolCPU.Size = new System.Drawing.Size(47, 17);
            this.toolCPU.Text = "CPU {0}";
            // 
            // toolMemory
            // 
            this.toolMemory.Name = "toolMemory";
            this.toolMemory.Size = new System.Drawing.Size(69, 17);
            this.toolMemory.Text = "Memory {0}";
            // 
            // ilPushButton
            // 
            this.ilPushButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPushButton.ImageStream")));
            this.ilPushButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPushButton.Images.SetKeyName(0, "AutoOn");
            this.ilPushButton.Images.SetKeyName(1, "AutoOff");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1091, 387);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Manager Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveLocation);
            this.groupBox3.Controls.Add(this.buttonSelectFolderIRLocation);
            this.groupBox3.Controls.Add(this.textBoxIRexeLocation);
            this.groupBox3.Location = new System.Drawing.Point(24, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(819, 123);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IR.exe Location";
            // 
            // buttonSaveLocation
            // 
            this.buttonSaveLocation.Location = new System.Drawing.Point(123, 69);
            this.buttonSaveLocation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveLocation.Name = "buttonSaveLocation";
            this.buttonSaveLocation.Size = new System.Drawing.Size(116, 28);
            this.buttonSaveLocation.TabIndex = 2;
            this.buttonSaveLocation.Text = "Save Location";
            this.buttonSaveLocation.UseVisualStyleBackColor = true;
            this.buttonSaveLocation.Click += new System.EventHandler(this.ButtonSaveLocation_Click);
            // 
            // buttonSelectFolderIRLocation
            // 
            this.buttonSelectFolderIRLocation.Location = new System.Drawing.Point(8, 69);
            this.buttonSelectFolderIRLocation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectFolderIRLocation.Name = "buttonSelectFolderIRLocation";
            this.buttonSelectFolderIRLocation.Size = new System.Drawing.Size(107, 28);
            this.buttonSelectFolderIRLocation.TabIndex = 1;
            this.buttonSelectFolderIRLocation.Text = "Select IR.Exe";
            this.buttonSelectFolderIRLocation.UseVisualStyleBackColor = true;
            this.buttonSelectFolderIRLocation.Click += new System.EventHandler(this.buttonSelectFolderIRLocation_Click_1);
            // 
            // textBoxIRexeLocation
            // 
            this.textBoxIRexeLocation.Location = new System.Drawing.Point(8, 37);
            this.textBoxIRexeLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIRexeLocation.Name = "textBoxIRexeLocation";
            this.textBoxIRexeLocation.Size = new System.Drawing.Size(785, 20);
            this.textBoxIRexeLocation.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1091, 387);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Server Config";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1091, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Discord Bridge";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvTasks);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1091, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task Scheduler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvTasks
            // 
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOccurence,
            this.chTime,
            this.chType,
            this.chActivity});
            this.lvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTasks.Location = new System.Drawing.Point(4, 31);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(1083, 352);
            this.lvTasks.TabIndex = 1;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            // 
            // chOccurence
            // 
            this.chOccurence.Text = "Occurence";
            this.chOccurence.Width = 270;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 270;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 270;
            // 
            // chActivity
            // 
            this.chActivity.Text = "Activity";
            this.chActivity.Width = 270;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tabServerManager
            // 
            this.tabServerManager.Controls.Add(this.splitContainer1);
            this.tabServerManager.Location = new System.Drawing.Point(4, 22);
            this.tabServerManager.Margin = new System.Windows.Forms.Padding(4);
            this.tabServerManager.Name = "tabServerManager";
            this.tabServerManager.Padding = new System.Windows.Forms.Padding(4);
            this.tabServerManager.Size = new System.Drawing.Size(1091, 387);
            this.tabServerManager.TabIndex = 5;
            this.tabServerManager.Text = "Server Manager";
            this.tabServerManager.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.scUpper);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCMDOutput);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 379);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // scUpper
            // 
            this.scUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scUpper.Location = new System.Drawing.Point(0, 0);
            this.scUpper.Margin = new System.Windows.Forms.Padding(4);
            this.scUpper.Name = "scUpper";
            // 
            // scUpper.Panel1
            // 
            this.scUpper.Panel1.Controls.Add(this.textBoxChatLog);
            this.scUpper.Panel1.Controls.Add(this.panel4);
            this.scUpper.Panel1.Controls.Add(this.panel3);
            // 
            // scUpper.Panel2
            // 
            this.scUpper.Panel2.Controls.Add(this.lstboxOnlinePlayers);
            this.scUpper.Size = new System.Drawing.Size(1083, 179);
            this.scUpper.SplitterDistance = 636;
            this.scUpper.SplitterWidth = 5;
            this.scUpper.TabIndex = 0;
            // 
            // textBoxChatLog
            // 
            this.textBoxChatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChatLog.Location = new System.Drawing.Point(0, 37);
            this.textBoxChatLog.Multiline = true;
            this.textBoxChatLog.Name = "textBoxChatLog";
            this.textBoxChatLog.ReadOnly = true;
            this.textBoxChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxChatLog.Size = new System.Drawing.Size(636, 105);
            this.textBoxChatLog.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkAutoRestart);
            this.panel4.Controls.Add(this.buttonOpenDBReader);
            this.panel4.Controls.Add(this.buttonStopServer);
            this.panel4.Controls.Add(this.buttonStartServer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 37);
            this.panel4.TabIndex = 43;
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.AutoSize = true;
            this.chkAutoRestart.Location = new System.Drawing.Point(517, 9);
            this.chkAutoRestart.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.Size = new System.Drawing.Size(85, 17);
            this.chkAutoRestart.TabIndex = 32;
            this.chkAutoRestart.Text = "Auto-Restart";
            this.chkAutoRestart.UseVisualStyleBackColor = true;
            this.chkAutoRestart.CheckedChanged += new System.EventHandler(this.ChkAutoRestart_CheckedChanged);
            // 
            // buttonOpenDBReader
            // 
            this.buttonOpenDBReader.Location = new System.Drawing.Point(227, 4);
            this.buttonOpenDBReader.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenDBReader.Name = "buttonOpenDBReader";
            this.buttonOpenDBReader.Size = new System.Drawing.Size(123, 28);
            this.buttonOpenDBReader.TabIndex = 31;
            this.buttonOpenDBReader.Text = "Read Database";
            this.buttonOpenDBReader.UseVisualStyleBackColor = true;
            this.buttonOpenDBReader.Click += new System.EventHandler(this.buttonOpenDBReader_Click);
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.Location = new System.Drawing.Point(119, 4);
            this.buttonStopServer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(100, 28);
            this.buttonStopServer.TabIndex = 30;
            this.buttonStopServer.Text = "Stop Server";
            this.buttonStopServer.UseVisualStyleBackColor = true;
            this.buttonStopServer.Click += new System.EventHandler(this.buttonStopServer_Click);
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(11, 4);
            this.buttonStartServer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(100, 28);
            this.buttonStartServer.TabIndex = 29;
            this.buttonStartServer.Text = "Start Server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSendChat);
            this.panel3.Controls.Add(this.textBoxSendChat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 37);
            this.panel3.TabIndex = 42;
            // 
            // buttonSendChat
            // 
            this.buttonSendChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendChat.Location = new System.Drawing.Point(532, 5);
            this.buttonSendChat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendChat.Name = "buttonSendChat";
            this.buttonSendChat.Size = new System.Drawing.Size(100, 28);
            this.buttonSendChat.TabIndex = 43;
            this.buttonSendChat.Text = "Send";
            this.buttonSendChat.UseVisualStyleBackColor = true;
            this.buttonSendChat.Click += new System.EventHandler(this.ButtonSendChat_Click);
            // 
            // textBoxSendChat
            // 
            this.textBoxSendChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendChat.Location = new System.Drawing.Point(11, 7);
            this.textBoxSendChat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSendChat.Name = "textBoxSendChat";
            this.textBoxSendChat.Size = new System.Drawing.Size(512, 20);
            this.textBoxSendChat.TabIndex = 42;
            this.textBoxSendChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSendChat_KeyPress);
            // 
            // lstboxOnlinePlayers
            // 
            this.lstboxOnlinePlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstboxOnlinePlayers.FormattingEnabled = true;
            this.lstboxOnlinePlayers.Location = new System.Drawing.Point(0, 0);
            this.lstboxOnlinePlayers.Margin = new System.Windows.Forms.Padding(4);
            this.lstboxOnlinePlayers.Name = "lstboxOnlinePlayers";
            this.lstboxOnlinePlayers.ScrollAlwaysVisible = true;
            this.lstboxOnlinePlayers.Size = new System.Drawing.Size(442, 179);
            this.lstboxOnlinePlayers.Sorted = true;
            this.lstboxOnlinePlayers.TabIndex = 26;
            // 
            // textBoxCMDOutput
            // 
            this.textBoxCMDOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCMDOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxCMDOutput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMDOutput.Multiline = true;
            this.textBoxCMDOutput.Name = "textBoxCMDOutput";
            this.textBoxCMDOutput.ReadOnly = true;
            this.textBoxCMDOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCMDOutput.Size = new System.Drawing.Size(1083, 133);
            this.textBoxCMDOutput.TabIndex = 43;
            this.textBoxCMDOutput.Text = "textBoxCMDOutput";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxManualCmd);
            this.panel1.Controls.Add(this.buttonCMDList);
            this.panel1.Controls.Add(this.buttonSendCommand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 62);
            this.panel1.TabIndex = 42;
            // 
            // textBoxManualCmd
            // 
            this.textBoxManualCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManualCmd.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "addSpecialResource",
            "addStackableSpecialResource",
            "all",
            "allowRetrieveEverywhere",
            "allowRetrieveInsuredShip",
            "clearIgnoreList",
            "clearResInv",
            "clearResourceInventory",
            "clearToolInv",
            "clearToolInventory",
            "copySave",
            "destroyShip",
            "exit",
            "exitTimer",
            "findSteamId",
            "findSystemIdForPlayer",
            "fixInaccessibleSystem",
            "giveAllRes",
            "giveMoney",
            "giveReputation",
            "giveRes",
            "giveResInv",
            "giveTool",
            "giveToolInv",
            "help",
            "ignore",
            "increaseRebuildVersion",
            "kickPlayer",
            "killPlayer",
            "listAllDronesInSystem",
            "listAllFactions",
            "listAllResources",
            "listAllTools",
            "listConnections",
            "listFactions",
            "listFleets",
            "listPlayerShipsInSystem",
            "listRanks",
            "listResourceInventory",
            "listResources",
            "listResourceVault",
            "listShipsInSystem",
            "listSpecialResources",
            "listToolInventory",
            "listTools",
            "listToolVault",
            "motd",
            "p",
            "players",
            "printPermissions",
            "printRebuildVersion",
            "printStoreOTron",
            "printTradeStats",
            "purgeAdmins",
            "quit",
            "quitTimer",
            "rebuildServer",
            "rebuildSystem",
            "removeAllDronesInSystem",
            "removeAllSkrillInSystem",
            "removeSpecialResource",
            "requestSystemSaveData",
            "resources",
            "save",
            "saveCrews",
            "saveFleets",
            "saveGalaxyUpdatables",
            "savePlayerClientData",
            "savePlayerData",
            "selfdestruct",
            "setAllRes",
            "setMoney",
            "setMotd",
            "setPassword",
            "setRes",
            "setSuperAdmin",
            "setSystemInfluence",
            "setWelcomeMessageEnabled",
            "setWelcomeMessageText",
            "setWelcomeMessageTitle",
            "storeAllShipsInSystem",
            "storeShip",
            "teleportPlayerToShipInSystem",
            "toggleCppChecksum",
            "toggleCreativeMode",
            "toggleCSharpChecksum",
            "toggleIndestructableShips",
            "togglePvEMode",
            "tools",
            "tpts",
            "unignore"});
            this.textBoxManualCmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxManualCmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxManualCmd.Location = new System.Drawing.Point(7, 31);
            this.textBoxManualCmd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManualCmd.Name = "textBoxManualCmd";
            this.textBoxManualCmd.Size = new System.Drawing.Size(812, 20);
            this.textBoxManualCmd.TabIndex = 41;
            this.textBoxManualCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxManualCmd_KeyPress);
            // 
            // buttonCMDList
            // 
            this.buttonCMDList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCMDList.Location = new System.Drawing.Point(935, 28);
            this.buttonCMDList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCMDList.Name = "buttonCMDList";
            this.buttonCMDList.Size = new System.Drawing.Size(143, 28);
            this.buttonCMDList.TabIndex = 43;
            this.buttonCMDList.Text = "Command List";
            this.buttonCMDList.UseVisualStyleBackColor = true;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendCommand.Location = new System.Drawing.Point(827, 28);
            this.buttonSendCommand.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(100, 28);
            this.buttonSendCommand.TabIndex = 42;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Manual console server commands:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabServerManager);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 413);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1099, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ssMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(931, 373);
            this.Name = "Form1";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabServerManager.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scUpper.Panel1.ResumeLayout(false);
            this.scUpper.Panel1.PerformLayout();
            this.scUpper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scUpper)).EndInit();
            this.scUpper.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog irexeBrowser;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolPlayerCount;
        private System.Windows.Forms.ToolStripStatusLabel toolCPU;
        private System.Windows.Forms.ToolStripStatusLabel toolMemory;
        private System.Windows.Forms.ImageList ilPushButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSaveLocation;
        private System.Windows.Forms.Button buttonSelectFolderIRLocation;
        private System.Windows.Forms.TextBox textBoxIRexeLocation;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabServerManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer scUpper;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonOpenDBReader;
        private System.Windows.Forms.Button buttonStopServer;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSendChat;
        private System.Windows.Forms.TextBox textBoxSendChat;
        private System.Windows.Forms.ListBox lstboxOnlinePlayers;
        private System.Windows.Forms.TextBox textBoxCMDOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxManualCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripStatusLabel toolSpacer;
        private System.Windows.Forms.CheckBox chkAutoRestart;
        private System.Windows.Forms.Button buttonCMDList;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader chOccurence;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chActivity;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBoxChatLog;
    }
}

