using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        private readonly FBAPIClient r_FBAPIClient;
        FormAppSettings m_FromAppSettings;
        private bool m_LoginSucceed;

        public FormLogin(FBAPIClient i_FBAPIClient)
        {
            InitializeComponent();
            m_LoginSucceed = false;
            r_FBAPIClient = i_FBAPIClient;
            m_FromAppSettings = new FormAppSettings(r_FBAPIClient);
        }

        public bool LoginSucceed
        { 
            get
            {
                return m_LoginSucceed;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_FBAPIClient.Login();
                m_LoginSucceed = true;
                this.Close();
            }
            catch(Exception ex)
            {
                m_LoginSucceed = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            /// Check??
            m_LoginSucceed = false;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            m_FromAppSettings.ShowDialog();
        }

        private void rememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            r_FBAPIClient.AppSettings.RememberUserActivated = true;
        }
    }
}
