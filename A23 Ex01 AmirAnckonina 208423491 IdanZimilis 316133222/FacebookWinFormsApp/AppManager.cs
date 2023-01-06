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
        //private readonly FormAppSettings r_FormAppSettings;
        private readonly FBAPIClient r_FBAPIClient;
        private readonly AccountFacade r_AccountFacade;

        private AppManager()
        {
            this.r_FBAPIClient = new FBAPIClient();
            this.r_AccountFacade = new AccountFacade(r_FBAPIClient);
            //this.r_FormAppSettings = new FormAppSettings(r_FBAPIClient);
            //this.r_FormLogin = new FormLogin(r_FBAPIClient, r_FormAppSettings);
            this.r_FormLogin = new FormLogin(r_AccountFacade);
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
            //Facade
            //if (r_FBAPIClient.AppSettings.RememberUserActivated)
            if (r_AccountFacade.RememberUserActivatedInApp())
            {
                //Facade
                r_AccountFacade.AutomaticLogin();
                //r_FBAPIClient.AutomaticLogin();
                r_FormMain.CheckRememberMe();
                RunApp();
            }
            else
            {
                RunLogin();
            }
        }

        private void RunLogin()
        {
            r_FormLogin.ShowDialog();
            //Facade
            //if (r_FBAPIClient.CurrentUser != null)
            if (r_AccountFacade.UserCurrentlyActivated())
            {
                RunApp();
            }
        }

        private void RunApp()
        {
            r_FormMain.ShowDialog();
            //Facade
            //if (r_FBAPIClient.AppSettings.RememberUserActivated == false)
            if (!r_AccountFacade.RememberUserActivatedInApp())
            {
                RunLogin();
            }
        }
    }
}
