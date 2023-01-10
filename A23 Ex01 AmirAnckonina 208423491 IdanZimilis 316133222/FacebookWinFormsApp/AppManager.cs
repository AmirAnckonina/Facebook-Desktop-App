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
        private readonly FbApiClient r_FbApiClient;
        private readonly AccountFacade r_AccountFacade;

        private AppManager()
        {
            r_FbApiClient = new FbApiClient();
            r_AccountFacade = new AccountFacade(r_FbApiClient);
            r_FormLogin = new FormLogin(r_AccountFacade);
            r_FormMain = new FormMain(r_FbApiClient);
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
            if (r_AccountFacade.RememberUserActivatedInApp())
            {
                r_AccountFacade.AutomaticLogin();
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
            if (r_AccountFacade.UserCurrentlyActivated())
            {
                RunApp();
            }
        }

        private void RunApp()
        {
            r_FormMain.ShowDialog();
            if (!r_AccountFacade.RememberUserActivatedInApp())
            {
                RunLogin();
            }
        }
    }
}
