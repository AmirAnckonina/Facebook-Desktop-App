using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public sealed class AppManager
    {
        private static AppManager s_Instance = null;
        private static object s_Lock = new object();

        private readonly FormMain r_FormMain;
        private readonly FormLogin r_FormLogin;
        private readonly FormAppSettings r_FormAppSettings;
        private FBAPIClient r_FBAPIClient;

        private AppManager()
        {
            this.r_FBAPIClient = new FBAPIClient();
            this.r_FormAppSettings = new FormAppSettings(r_FBAPIClient);
            this.r_FormLogin = new FormLogin(r_FBAPIClient, r_FormAppSettings);
            this.r_FormMain = new FormMain(r_FBAPIClient);
        }

        public static AppManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_Lock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppManager();
                        }
                    }
                }

                return s_Instance;
            }
        }
        public void Run()
        {
            if (r_FBAPIClient.AppSettings.RememberUserActivated)
            {
                r_FBAPIClient.AutomaticLogin();
                r_FormMain.CheckRememberMe();
                RunApp();
            }
            else
            {
                RunLogin();
            }
        }

        private void RunFormAppSettings()
        {
            r_FormAppSettings.ShowDialog();
        }

        private void RunLogin()
        {
            r_FormLogin.ShowDialog();
            /// if (m_FormLogin.LoginSucceed)
            if (r_FBAPIClient.CurrentUser != null)
            {
                RunApp();
            }
        }

        private void RunApp()
        {
            r_FormMain.ShowDialog();
            if (r_FBAPIClient.AppSettings.RememberUserActivated == false)
            {
                RunLogin();
            }
        }
    }
}
