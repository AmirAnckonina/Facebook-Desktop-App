using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBServiceLogic
{
    public class AccountFacade
    {
        private readonly FBAPIClient r_FBAPIClient;

        public AccountFacade(FBAPIClient i_FBAPIClient)
        {
            r_FBAPIClient = i_FBAPIClient;
        }

        public void Login()
        {
            r_FBAPIClient.Login();
        }

        public void AutomaticLogin()
        {
            r_FBAPIClient.AutomaticLogin();
        }

        public void SetAppID(string i_AppID)
        {
            r_FBAPIClient.AppSettings.AppID = i_AppID;
        }

        public void ClearAppPermissions()
        {
            r_FBAPIClient.AppSettings.Permissions.Clear();
        }

        public void AddAppPermission(string i_Permission)
        {
            r_FBAPIClient.AppSettings.AddPermission(i_Permission);
        }

        public void SetDefaultSettingsInApp()
        {
            r_FBAPIClient.AppSettings.SetDefaultAppSettings();
        }

        public bool UserCurrentlyActivated()
        {
            return r_FBAPIClient.CurrentUser != null;
        }
        
        public bool RememberUserActivatedInApp()
        {
            return r_FBAPIClient.AppSettings.RememberUserActivated;
        }

        /*public void EnableRememberUserInApp()
        {

        }

        public void DisableRememberUserInApp()
        {

        }*/
    }
}