using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public class AppManager
    {
        private FormLogin m_FormLogin;
        private FormMain m_FormMain;
        private FBAPIClient m_FBAPIClient;
        /// <summary>
        ///  Change
        /// </summary>
        public AppManager()
        {
            this.m_FBAPIClient = new FBAPIClient();
            this.m_FormLogin = new FormLogin(m_FBAPIClient);
            this.m_FormMain = new FormMain(m_FBAPIClient);
        }

        public void Run()
        {
            RunLogin();
        }

        public void RunLogin()
        {
            m_FormLogin.ShowDialog();
            if (m_FormLogin.LoginSucceed)
            {
                RunApp();
            }
        }

        public void RunApp()
        {
            m_FormMain.ShowDialog();
            if (m_FBAPIClient.CurrentUser == null)
            {
                RunLogin();
            }
        }
    }
}
