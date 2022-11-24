using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FbGUI
{
    public partial class LoginForm : Form
    {

        private User m_LoggedInUser { get; set; }
        private LoginResult m_LoginResult { get; set; }

        private FormsController m_FormsController;
        public LoginForm()
        {
            InitializeComponent();
        }

        internal void setController(FormsController i_FormsController)
        {
            m_FormsController = i_FormsController;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            m_LoginResult = FacebookService.Login(
                    AppSettings.s_AppID,
                    //"3456972604533289",
                    /// requested permissions:
                    "email",
                    "public_profile"
                    //AppSettings.GetAllowedPermissions();
                    );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                this.Close();
                //r_GameSettingsForm.FormClosed += this.r_GameSettingsForm_Closed;


                //fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_FormsController.setLoginResult(m_LoginResult);
                m_FormsController.openMainForm();
                

                //fetchUserInfo();
            }
           /* else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }*/
        }
    }
}
