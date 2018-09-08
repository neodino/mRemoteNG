namespace mRemoteNG.UI.Forms
{
	public partial class FrmMain : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            mRemoteNG.Connection.ConnectionInitiator connectionInitiator1 = new mRemoteNG.Connection.ConnectionInitiator();
            this.pnlDock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new mRemoteNG.UI.Menu.MainFileMenu();
            this.viewMenu = new mRemoteNG.UI.Menu.ViewMenu();
            this.toolsMenu = new mRemoteNG.UI.Menu.ToolsMenu();
            this.helpMenu = new mRemoteNG.UI.Menu.HelpMenu();
            this.mMenSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this._quickConnectToolStrip = new mRemoteNG.UI.Controls.QuickConnectToolStrip();
            this._multiSshToolStrip = new mRemoteNG.UI.Controls.MultiSshToolStrip();
            this._externalToolsToolStrip = new mRemoteNG.UI.Controls.ExternalToolsToolStrip();
            this.tmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.vsToolStripExtender = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.msMain.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDock
            // 
            this.pnlDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDock.DockBackColor = System.Drawing.SystemColors.Control;
            this.pnlDock.DockLeftPortion = 230D;
            this.pnlDock.DockRightPortion = 230D;
            this.pnlDock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.pnlDock.Location = new System.Drawing.Point(0, 0);
            this.pnlDock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(2258, 967);
            this.pnlDock.TabIndex = 13;
            this.pnlDock.ActiveDocumentChanged += new System.EventHandler(this.pnlDock_ActiveDocumentChanged);
            // 
            // msMain
            // 
            this.msMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.msMain.Dock = System.Windows.Forms.DockStyle.None;
            this.msMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.msMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu,
            this.helpMenu});
            this.msMain.Location = new System.Drawing.Point(3, 25);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(550, 42);
            this.msMain.Stretch = false;
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main Toolbar";
            // 
            // fileMenu
            // 
            this.fileMenu.ConnectionInitiator = null;
            this.fileMenu.Name = "mMenFile";
            this.fileMenu.Size = new System.Drawing.Size(64, 38);
            this.fileMenu.Text = "&File";
            this.fileMenu.TreeWindow = null;
            this.fileMenu.DropDownOpening += new System.EventHandler(this.mainFileMenu1_DropDownOpening);
            // 
            // viewMenu
            // 
            this.viewMenu.FullscreenHandler = null;
            this.viewMenu.MainForm = null;
            this.viewMenu.Name = "mMenView";
            this.viewMenu.Size = new System.Drawing.Size(78, 38);
            this.viewMenu.Text = "&View";
            this.viewMenu.TsExternalTools = null;
            this.viewMenu.TsMultiSsh = null;
            this.viewMenu.TsQuickConnect = null;
            this.viewMenu.DropDownOpening += new System.EventHandler(this.ViewMenu_Opening);
            // 
            // toolsMenu
            // 
            this.toolsMenu.CredentialProviderCatalog = null;
            this.toolsMenu.MainForm = null;
            this.toolsMenu.Name = "mMenTools";
            this.toolsMenu.Size = new System.Drawing.Size(82, 38);
            this.toolsMenu.Text = "&Tools";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "mMenInfo";
            this.helpMenu.Size = new System.Drawing.Size(77, 38);
            this.helpMenu.Text = "&Help";
            this.helpMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // mMenSep3
            // 
            this.mMenSep3.Name = "mMenSep3";
            this.mMenSep3.Size = new System.Drawing.Size(211, 6);
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.pnlDock);
            this.tsContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(2258, 967);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(2258, 1098);
            this.tsContainer.TabIndex = 17;
            this.tsContainer.Text = "ToolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this._quickConnectToolStrip);
            this.tsContainer.TopToolStripPanel.Controls.Add(this._multiSshToolStrip);
            this.tsContainer.TopToolStripPanel.Controls.Add(this.msMain);
            this.tsContainer.TopToolStripPanel.Controls.Add(this._externalToolsToolStrip);
            // 
            // _quickConnectToolStrip
            // 
            this._quickConnectToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this._quickConnectToolStrip.ConnectionInitiator = connectionInitiator1;
            this._quickConnectToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._quickConnectToolStrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this._quickConnectToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._quickConnectToolStrip.Location = new System.Drawing.Point(3, 0);
            this._quickConnectToolStrip.MaximumSize = new System.Drawing.Size(0, 25);
            this._quickConnectToolStrip.Name = "_quickConnectToolStrip";
            this._quickConnectToolStrip.Size = new System.Drawing.Size(484, 25);
            this._quickConnectToolStrip.TabIndex = 18;
            // 
            // _multiSshToolStrip
            // 
            this._multiSshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._multiSshToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._multiSshToolStrip.Location = new System.Drawing.Point(3, 92);
            this._multiSshToolStrip.MinimumSize = new System.Drawing.Size(300, 0);
            this._multiSshToolStrip.Name = "_multiSshToolStrip";
            this._multiSshToolStrip.Size = new System.Drawing.Size(440, 39);
            this._multiSshToolStrip.TabIndex = 1;
            // 
            // _externalToolsToolStrip
            // 
            this._externalToolsToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this._externalToolsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._externalToolsToolStrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this._externalToolsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._externalToolsToolStrip.Location = new System.Drawing.Point(39, 67);
            this._externalToolsToolStrip.MaximumSize = new System.Drawing.Size(0, 25);
            this._externalToolsToolStrip.Name = "_externalToolsToolStrip";
            this._externalToolsToolStrip.Size = new System.Drawing.Size(111, 25);
            this._externalToolsToolStrip.TabIndex = 17;
            // 
            // tmrAutoSave
            // 
            this.tmrAutoSave.Interval = 10000;
            this.tmrAutoSave.Tick += new System.EventHandler(this.tmrAutoSave_Tick);
            // 
            // vsToolStripExtender
            // 
            this.vsToolStripExtender.DefaultRenderer = null;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2258, 1098);
            this.Controls.Add(this.tsContainer);
            this.Icon = global::mRemoteNG.Resources.mRemote_Icon;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(774, 704);
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.Text = "mRemoteNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.ResumeLayout(false);

		}
		internal WeifenLuo.WinFormsUI.Docking.DockPanel pnlDock;
		internal System.Windows.Forms.MenuStrip msMain;
		internal System.Windows.Forms.ToolStripContainer tsContainer;
		internal System.Windows.Forms.Timer tmrAutoSave;
		internal System.Windows.Forms.ToolStripSeparator mMenSep3;
        private System.ComponentModel.IContainer components;
        private Menu.MainFileMenu fileMenu;
        private Menu.ViewMenu viewMenu;
        private Menu.ToolsMenu toolsMenu;
        private Menu.HelpMenu helpMenu;
        internal mRemoteNG.UI.Controls.QuickConnectToolStrip _quickConnectToolStrip;
        internal mRemoteNG.UI.Controls.ExternalToolsToolStrip _externalToolsToolStrip;
		internal mRemoteNG.UI.Controls.MultiSshToolStrip _multiSshToolStrip;
        //theming support
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender;
    }
}
