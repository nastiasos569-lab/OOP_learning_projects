namespace lb30.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treeViewFtp = new System.Windows.Forms.TreeView();
            this.contextMenuFtp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadRETRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadSTORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadUniqueSTOUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendAPPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameRENAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeSIZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeSIZEDateMDTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMKDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleListNLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель підключення ";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(15, 90);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(107, 22);
            this.tbHost.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(142, 90);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(107, 22);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(268, 90);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(107, 22);
            this.tbPass.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(399, 90);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pass";
            // 
            // treeViewFtp
            // 
            this.treeViewFtp.ContextMenuStrip = this.contextMenuFtp;
            this.treeViewFtp.Location = new System.Drawing.Point(15, 133);
            this.treeViewFtp.Name = "treeViewFtp";
            this.treeViewFtp.Size = new System.Drawing.Size(492, 388);
            this.treeViewFtp.TabIndex = 16;
            this.treeViewFtp.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFtp_BeforeExpand);
            this.treeViewFtp.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFtp_NodeMouseClick);
            // 
            // contextMenuFtp
            // 
            this.contextMenuFtp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuFtp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.infoToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.contextMenuFtp.Name = "contextMenuFtp";
            this.contextMenuFtp.Size = new System.Drawing.Size(140, 100);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadRETRToolStripMenuItem,
            this.uploadSTORToolStripMenuItem,
            this.uploadUniqueSTOUToolStripMenuItem,
            this.appendAPPEToolStripMenuItem,
            this.deleteDELEToolStripMenuItem,
            this.renameRENAMEToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // downloadRETRToolStripMenuItem
            // 
            this.downloadRETRToolStripMenuItem.Name = "downloadRETRToolStripMenuItem";
            this.downloadRETRToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.downloadRETRToolStripMenuItem.Text = "Download (RETR)";
            this.downloadRETRToolStripMenuItem.Click += new System.EventHandler(this.downloadRETRToolStripMenuItem_Click);
            // 
            // uploadSTORToolStripMenuItem
            // 
            this.uploadSTORToolStripMenuItem.Name = "uploadSTORToolStripMenuItem";
            this.uploadSTORToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.uploadSTORToolStripMenuItem.Text = "Upload (STOR)";
            this.uploadSTORToolStripMenuItem.Click += new System.EventHandler(this.uploadSTORToolStripMenuItem_Click);
            // 
            // uploadUniqueSTOUToolStripMenuItem
            // 
            this.uploadUniqueSTOUToolStripMenuItem.Name = "uploadUniqueSTOUToolStripMenuItem";
            this.uploadUniqueSTOUToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.uploadUniqueSTOUToolStripMenuItem.Text = "Upload Unique (STOU)";
            this.uploadUniqueSTOUToolStripMenuItem.Click += new System.EventHandler(this.uploadUniqueSTOUToolStripMenuItem_Click);
            // 
            // appendAPPEToolStripMenuItem
            // 
            this.appendAPPEToolStripMenuItem.Name = "appendAPPEToolStripMenuItem";
            this.appendAPPEToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.appendAPPEToolStripMenuItem.Text = "Append (APPE)";
            this.appendAPPEToolStripMenuItem.Click += new System.EventHandler(this.appendAPPEToolStripMenuItem_Click);
            // 
            // deleteDELEToolStripMenuItem
            // 
            this.deleteDELEToolStripMenuItem.Name = "deleteDELEToolStripMenuItem";
            this.deleteDELEToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.deleteDELEToolStripMenuItem.Text = "Delete (DELE)";
            this.deleteDELEToolStripMenuItem.Click += new System.EventHandler(this.deleteDELEToolStripMenuItem_Click);
            // 
            // renameRENAMEToolStripMenuItem
            // 
            this.renameRENAMEToolStripMenuItem.Name = "renameRENAMEToolStripMenuItem";
            this.renameRENAMEToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.renameRENAMEToolStripMenuItem.Text = "Rename (RENAME)";
            this.renameRENAMEToolStripMenuItem.Click += new System.EventHandler(this.renameRENAMEToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeSIZEToolStripMenuItem,
            this.sizeSIZEDateMDTMToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // sizeSIZEToolStripMenuItem
            // 
            this.sizeSIZEToolStripMenuItem.Name = "sizeSIZEToolStripMenuItem";
            this.sizeSIZEToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.sizeSIZEToolStripMenuItem.Text = "Size (SIZE)";
            this.sizeSIZEToolStripMenuItem.Click += new System.EventHandler(this.sizeSIZEToolStripMenuItem_Click);
            // 
            // sizeSIZEDateMDTMToolStripMenuItem
            // 
            this.sizeSIZEDateMDTMToolStripMenuItem.Name = "sizeSIZEDateMDTMToolStripMenuItem";
            this.sizeSIZEDateMDTMToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.sizeSIZEDateMDTMToolStripMenuItem.Text = "Date (MDTM)";
            this.sizeSIZEDateMDTMToolStripMenuItem.Click += new System.EventHandler(this.sizeSIZEDateMDTMToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMKDToolStripMenuItem,
            this.removeRMDToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // createMKDToolStripMenuItem
            // 
            this.createMKDToolStripMenuItem.Name = "createMKDToolStripMenuItem";
            this.createMKDToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.createMKDToolStripMenuItem.Text = "Create (MKD)";
            this.createMKDToolStripMenuItem.Click += new System.EventHandler(this.createMKDToolStripMenuItem_Click);
            // 
            // removeRMDToolStripMenuItem
            // 
            this.removeRMDToolStripMenuItem.Name = "removeRMDToolStripMenuItem";
            this.removeRMDToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.removeRMDToolStripMenuItem.Text = "Remove (RMD)";
            this.removeRMDToolStripMenuItem.Click += new System.EventHandler(this.removeRMDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listLISTToolStripMenuItem,
            this.simpleListNLISTToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listLISTToolStripMenuItem
            // 
            this.listLISTToolStripMenuItem.Name = "listLISTToolStripMenuItem";
            this.listLISTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listLISTToolStripMenuItem.Text = "List (LIST)";
            this.listLISTToolStripMenuItem.Click += new System.EventHandler(this.listLISTToolStripMenuItem_Click);
            // 
            // simpleListNLISTToolStripMenuItem
            // 
            this.simpleListNLISTToolStripMenuItem.Name = "simpleListNLISTToolStripMenuItem";
            this.simpleListNLISTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.simpleListNLISTToolStripMenuItem.Text = "Simple List (NLIST)";
            this.simpleListNLISTToolStripMenuItem.Click += new System.EventHandler(this.simpleListNLISTToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "View";
            // 
            // comboBoxView
            // 
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "Simple",
            "",
            "Full"});
            this.comboBoxView.Location = new System.Drawing.Point(57, 533);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(159, 24);
            this.comboBoxView.TabIndex = 18;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Upload Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeViewFtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuFtp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeViewFtp;
        private System.Windows.Forms.ContextMenuStrip contextMenuFtp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem downloadRETRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadSTORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadUniqueSTOUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendAPPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameRENAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeSIZEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeSIZEDateMDTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMKDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleListNLISTToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Button button1;
    }
}