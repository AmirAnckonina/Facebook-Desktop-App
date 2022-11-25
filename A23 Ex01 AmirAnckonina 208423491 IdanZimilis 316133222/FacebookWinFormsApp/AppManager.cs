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
        private readonly FormMain r_FormMain;
        private readonly FormLogin r_FormLogin;
        private readonly FormAppSettings r_FormAppSettings;
        private FBAPIClient r_FBAPIClient;
        /// <summary>
        ///  Change
        /// </summary>
        public AppManager()
        {
            this.r_FBAPIClient = new FBAPIClient();
            this.r_FormAppSettings = new FormAppSettings(r_FBAPIClient);
            this.r_FormLogin = new FormLogin(r_FBAPIClient, r_FormAppSettings);
            this.r_FormMain = new FormMain(r_FBAPIClient);
            /// EventsRegistration();
        }

       /* private void EventsRegistration()
        {
            this.r_FormLogin.FormClosed += r_FormLogin_FormClosed;
            this.r_FormMain.FormClosed += r_FormMain_FormClosed;
        }

        private void r_FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMainObj = sender as FormMain;

            if (formMainObj != null)
            {
                if (r_FBAPIClient.AppSettings.RememberUserActivated == false)
                {
                    RunLogin();
                }
            }
        }

        private void r_FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formLoginObj = sender as FormLogin;

            if (formLoginObj != null)
            {
                if (r_FBAPIClient.CurrentUser != null)
                {
                    RunApp();
                }
            }
        }*/

        public void Run()
        {
            if (r_FBAPIClient.AppSettings.RememberUserActivated)
            {
                r_FBAPIClient.AutomaticLogin();
                RunApp();
            }

            else
            {
                RunLogin();
            }
        }

        public void RunFormAppSettings()
        {
            r_FormAppSettings.ShowDialog();
        }

        public void RunLogin()
        {
            r_FormLogin.ShowDialog();
            /// if (m_FormLogin.LoginSucceed)
            if (r_FBAPIClient.CurrentUser != null)
            {
                RunApp();
            }
        }

        public void RunApp()
        {
            r_FormMain.ShowDialog();
            if (r_FBAPIClient.AppSettings.RememberUserActivated == false)
            {
                RunLogin();
            }
            ///else close all...
        }
    }
}
