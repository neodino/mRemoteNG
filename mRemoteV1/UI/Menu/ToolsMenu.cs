using System;
using System.Windows.Forms;
using mRemoteNG.App;
using mRemoteNG.Credential;

namespace mRemoteNG.UI.Menu
{
	public class ToolsMenu : ToolStripMenuItem
    {
        private ToolStripSeparator _mMenToolsSep1;
        private ToolStripMenuItem _mMenToolsOptions;
        private ToolStripMenuItem _mMenToolsSshTransfer;
        private ToolStripMenuItem _mMenToolsUvncsc;
        private ToolStripMenuItem _mMenToolsComponentsCheck;

        public Form MainForm { get; set; }
        public ICredentialRepositoryList CredentialProviderCatalog { get; set; }

        public ToolsMenu()
        {
            Initialize();
        }

        private void Initialize()
        {
            _mMenToolsSshTransfer = new ToolStripMenuItem();
            _mMenToolsUvncsc = new ToolStripMenuItem();
            _mMenToolsSep1 = new ToolStripSeparator();
            _mMenToolsComponentsCheck = new ToolStripMenuItem();
            _mMenToolsOptions = new ToolStripMenuItem();

            // 
            // mMenTools
            // 
            DropDownItems.AddRange(new ToolStripItem[] {
            _mMenToolsSshTransfer,
            _mMenToolsUvncsc,
            _mMenToolsSep1,
            _mMenToolsComponentsCheck,
            _mMenToolsOptions});
            Name = "mMenTools";
            Size = new System.Drawing.Size(48, 20);
            Text = Language.strMenuTools;
            // 
            // mMenToolsSSHTransfer
            // 
            _mMenToolsSshTransfer.Image = Resources.SSHTransfer;
            _mMenToolsSshTransfer.Name = "mMenToolsSSHTransfer";
            _mMenToolsSshTransfer.Size = new System.Drawing.Size(184, 22);
            _mMenToolsSshTransfer.Text = Language.strMenuSSHFileTransfer;
            _mMenToolsSshTransfer.Click += mMenToolsSSHTransfer_Click;
            // 
            // mMenToolsUVNCSC
            // 
            _mMenToolsUvncsc.Image = Resources.UVNC_SC;
            _mMenToolsUvncsc.Name = "mMenToolsUVNCSC";
            _mMenToolsUvncsc.Size = new System.Drawing.Size(184, 22);
            _mMenToolsUvncsc.Text = Language.strUltraVNCSingleClick;
            _mMenToolsUvncsc.Visible = false;
            _mMenToolsUvncsc.Click += mMenToolsUVNCSC_Click;

            // 
            // mMenToolsSep1
            // 
            _mMenToolsSep1.Name = "mMenToolsSep1";
            _mMenToolsSep1.Size = new System.Drawing.Size(181, 6);
            // 
            // mMenToolsComponentsCheck
            // 
            _mMenToolsComponentsCheck.Image = Resources.cog_error;
            _mMenToolsComponentsCheck.Name = "mMenToolsComponentsCheck";
            _mMenToolsComponentsCheck.Size = new System.Drawing.Size(184, 22);
            _mMenToolsComponentsCheck.Text = Language.strComponentsCheck;
            _mMenToolsComponentsCheck.Click += mMenToolsComponentsCheck_Click;
            // 
            // mMenToolsOptions
            // 
            _mMenToolsOptions.Image = Resources.Options;
            _mMenToolsOptions.Name = "mMenToolsOptions";
            _mMenToolsOptions.Size = new System.Drawing.Size(184, 22);
            _mMenToolsOptions.Text = Language.strMenuOptions;
            _mMenToolsOptions.Click += mMenToolsOptions_Click;
        }

        public void ApplyLanguage()
        {
            Text = Language.strMenuTools;
            _mMenToolsSshTransfer.Text = Language.strMenuSSHFileTransfer;
            _mMenToolsComponentsCheck.Text = Language.strComponentsCheck;
            _mMenToolsOptions.Text = Language.strMenuOptions;
        }

        #region Tools
        private void mMenToolsSSHTransfer_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.SSHTransfer);
        }

        private void mMenToolsUVNCSC_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.UltraVNCSC);
        }


        private void mMenToolsComponentsCheck_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.ComponentsCheck);
        }

        private void mMenToolsOptions_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.Options);
        }
        #endregion
    }
}