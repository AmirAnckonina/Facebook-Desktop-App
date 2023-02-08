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
        private readonly AccountFacade r_AccountFacade;
        private readonly FormAppSettings r_FromAppSettings;

        public FormLogin(AccountFacade i_AccountFacade)
        {
            InitializeComponent();
            LoginSucceed = false;
            r_AccountFacade = i_AccountFacade;
            r_FromAppSettings = new FormAppSettings(r_AccountFacade);
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
                    r_AccountFacade.SetDefaultSettingsInApp();
                }

                r_AccountFacade.RegularLogin();
                LoginSucceed = true;
                this.Close();
            }
            catch (Exception ex)
            {
                LoginSucceed = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoginSucceed = false;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            r_FromAppSettings.ShowDialog();
        }
    }
}
