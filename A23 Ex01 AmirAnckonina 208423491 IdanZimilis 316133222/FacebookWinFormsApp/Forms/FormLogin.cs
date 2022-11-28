using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        private readonly FBAPIClient r_FBAPIClient;
        private readonly FormAppSettings r_FromAppSettings;

        public FormLogin(FBAPIClient i_FBAPIClient, FormAppSettings i_FormAppSettings)
        {
            InitializeComponent();
            LoginSucceed = false;
            r_FBAPIClient = i_FBAPIClient;
            r_FromAppSettings = i_FormAppSettings;
        }

        public bool LoginSucceed { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CreateLoginRequest();
        }

        private void CreateLoginRequest()
        {
            LoginSucceed = false;

            try
            {
                if (r_FromAppSettings.WithDefaultPermissions == true)
                {
                    r_FBAPIClient.AppSettings.SetDefaultAppSettings();
                }

                r_FBAPIClient.Login();
                LoginSucceed = true;
                this.Close();
            }
            catch (Exception ex)
            {
                LoginSucceed = false;
                MessageBox.Show(ex.Message);
            }
        }

        private string CreatePermissionsAuthText()
        {
            StringBuilder permissionsApprovalMessage = new StringBuilder();

            permissionsApprovalMessage.Append($"By login to {r_FBAPIClient.AppSettings.AppID} application, you authorize the app to get the following information:" +
                string.Empty);
            foreach (string permission in r_FBAPIClient.AppSettings.Permissions)
            {
                permissionsApprovalMessage.Append($"{permission}" +
                    string.Empty);
            }

            permissionsApprovalMessage.Append("If you want to modify these permissions, please press cancel, and select 'Settings' button");

            return permissionsApprovalMessage.ToString();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoginSucceed = false;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            r_FromAppSettings.ShowDialog();
        }

        private void rememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            r_FBAPIClient.AppSettings.RememberUserActivated = true;
        }
    }
}
