using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic
{
    public class AccountFacade
    {
        private readonly FbApiClient r_FbApiClient;

        public AccountFacade(FbApiClient i_FbApiClient)
        {
            r_FbApiClient = i_FbApiClient;
        }

        public void Login()
        {
            r_FbApiClient.Login();
        }

        public void AutomaticLogin()
        {
            r_FbApiClient.AutomaticLogin();
        }

        public void SetAppID(string i_AppID)
        {
            r_FbApiClient.AppSettings.AppID = i_AppID;
        }

        public void ClearAppPermissions()
        {
            r_FbApiClient.AppSettings.Permissions.Clear();
        }

        public void AddAppPermission(string i_Permission)
        {
            r_FbApiClient.AppSettings.AddPermission(i_Permission);
        }

        public void SetDefaultSettingsInApp()
        {
            r_FbApiClient.AppSettings.SetDefaultAppSettings();
        }

        public bool UserCurrentlyActivated()
        {
            return r_FbApiClient.CurrentUser != null;
        }
        
        public bool RememberUserActivatedInApp()
        {
            return r_FbApiClient.AppSettings.RememberUserActivated;
        }

        /*public void EnableRememberUserInApp()
        {

        }

        public void DisableRememberUserInApp()
        {

        }*/
    }
}