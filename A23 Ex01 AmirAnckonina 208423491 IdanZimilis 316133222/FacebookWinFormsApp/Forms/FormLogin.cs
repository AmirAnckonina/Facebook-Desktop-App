﻿using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        //private readonly FBAPIClient r_FBAPIClient;
        private readonly AccountFacade r_AccountFacade;
        private readonly FormAppSettings r_FromAppSettings;

        public FormLogin(AccountFacade i_AccountFacade)
        {
            InitializeComponent();
            LoginSucceed = false;
            r_AccountFacade = i_AccountFacade;
            r_FromAppSettings = new FormAppSettings(r_AccountFacade);
        }

        /*public FormLogin(FBAPIClient i_FBAPIClient, FormAppSettings i_FormAppSettings)
        {
            InitializeComponent();
            LoginSucceed = false;
            r_FBAPIClient = i_FBAPIClient;
            r_FromAppSettings = i_FormAppSettings;
        }*/

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
                    //Facade
                    r_AccountFacade.SetDefaultSettingsInApp();
                    //r_FBAPIClient.AppSettings.SetDefaultAppSettings();
                }

                //Facade
                r_AccountFacade.Login();
                //r_FBAPIClient.Login();
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

     /*   private void rememberMeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            r_FBAPIClient.AppSettings.RememberUserActivated = true;
        }*/
    }
}
