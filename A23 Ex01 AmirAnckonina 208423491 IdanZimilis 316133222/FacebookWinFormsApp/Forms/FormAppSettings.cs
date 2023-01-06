using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBServiceLogic;

namespace FacebookWinFormsApp
{
	public partial class FormAppSettings : Form
	{
		private readonly AccountFacade r_AccountFacade;

		public bool WithDefaultPermissions { get; set; } = true;

		public FormAppSettings(AccountFacade i_AccountFacade)
        {
			InitializeComponent();
			r_AccountFacade = i_AccountFacade;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			SetAppSettings();
            DialogResult = DialogResult.OK;
			this.Close();
		}

		private void SetAppSettings()
        {
			WithDefaultPermissions = false;

			if (comboAppID.SelectedIndex == -1)
			{
				comboAppID.SelectedIndex = 0;
			}
			else
			{
				string appID = comboAppID.SelectedItem.ToString();

				//Facade
				r_AccountFacade.SetAppID(appID);
				//r_AccountFacade.AppSettings.AppID = appID;
			}

			UpdateAppPermissions();
		}

		private void UpdateAppPermissions()
        {
			//Facade
			r_AccountFacade.ClearAppPermissions();
			//r_FBAPIClient.AppSettings.Permissions.Clear();

			foreach (string checkedPermission in listBoxPermissions.CheckedItems)
            {
				//Facade
				r_AccountFacade.AddAppPermission(checkedPermission);
				//r_FBAPIClient.AppSettings.AddPermission(checkedPermission);
            }
		}

		private void buttonAddPermission_Click(object sender, EventArgs e)
		{
			listBoxPermissions.Items.Add(textBoxPermissionToAdd.Text);
		}

        private void FormAppSettings_Load(object sender, EventArgs e)
        {
			comboAppID.SelectedItem = comboAppID.Items[0];

			for (int i = 0; i < listBoxPermissions.Items.Count; i++)
			{
				listBoxPermissions.SetItemChecked(i, true);
			}
		}
    }
}
