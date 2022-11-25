using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Text;
using System.Windows.Forms;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        private readonly FBAPIClient r_FBAPIClient;
        private readonly FormAppSettings r_FromAppSettings;
        private bool m_LoginSucceed;

        public FormLogin(FBAPIClient i_FBAPIClient, FormAppSettings i_FormAppSettings)
        {
            InitializeComponent();
            m_LoginSucceed = false;
            r_FBAPIClient = i_FBAPIClient;
            r_FromAppSettings = i_FormAppSettings;
            /// r_FromAppSettings = new FormAppSettings(r_FBAPIClient);
        }

        public bool LoginSucceed { get => m_LoginSucceed; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoginSucceed = false;
            string permissionsAuthText;

            try
            {
                r_FBAPIClient.Login();
                /*permissionsAuthText = CreatePermissionsAuthText();
                DialogResult permissionsAuthDialogResult = MessageBox.Show(
                    permissionsAuthText,
                    "Permissions Authorization",
                    MessageBoxButtons.OKCancel
                    );*/
                /*if (DialogResult == DialogResult.OK)
                {*/
                    m_LoginSucceed = true;
                    this.Close();
                /// }
            }
            catch(Exception ex)
            {
                m_LoginSucceed = false;
                MessageBox.Show(ex.Message);
            }
        }

        private string CreatePermissionsAuthText()
        {
            StringBuilder permissionsApprovalMessage = new StringBuilder();

            permissionsApprovalMessage.Append($"By login to {r_FBAPIClient.AppSettings.AppID} application, you authorize the app to get the following information:" +
                $"");
            foreach (string permission in r_FBAPIClient.AppSettings.Permissions)
            {
                permissionsApprovalMessage.Append($"{permission}" +
                    $"");
            }

            permissionsApprovalMessage.Append("If you want to modify these permissions, please press cancel, and select 'Settings' button");

            return permissionsApprovalMessage.ToString();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            /// Check??
            m_LoginSucceed = false;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            r_FromAppSettings.ShowDialog();
        }

        private void rememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            r_FBAPIClient.AppSettings.RememberUserActivated = true;
        }

        /*protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }*/
        /*private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClosed(e as F);
        }*/
    }
}
