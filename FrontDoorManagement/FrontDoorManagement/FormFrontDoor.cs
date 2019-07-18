using Microsoft.Azure.Management.FrontDoor.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace FrontDoorManagement
{
    public partial class FormFrontDoor : Form
    {
        private FrontDoorManagement _managementHandler;
        private String _subscriptionId;
        private ActiveDirectoryAuthentication.AuthMethod _managementAuthenticationMethod;
        private String _aadTenant;
        private String _clientId;
        private String _clientSecret;

        public FormFrontDoor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultSubscriptionId"]))
            {
                this._subscriptionId = ConfigurationManager.AppSettings["DefaultSubscriptionId"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultAadTenant"]))
            {
                this._aadTenant = ConfigurationManager.AppSettings["DefaultAadTenant"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultClientId"]))
            {
                this._clientId = ConfigurationManager.AppSettings["DefaultClientId"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultClientSecret"]))
            {
                this._clientSecret = ConfigurationManager.AppSettings["DefaultClientSecret"];
            }

            if (!String.IsNullOrWhiteSpace(this._clientId) && !String.IsNullOrWhiteSpace(this._clientSecret))
            {
                this._managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal;
            }
            else if (!String.IsNullOrWhiteSpace(this._clientId))
            {
                this._managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.Login;
            }
            else
            {
                this._managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity;
            }

            SetUiSate();
        }

        private void SetUiSate()
        {
            Boolean Valid = true;

            if (String.IsNullOrWhiteSpace(this._subscriptionId))
            {
                Valid = false;
            }
            else
            {
                switch (this._managementAuthenticationMethod)
                {
                    case ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal:
                        Valid = !String.IsNullOrWhiteSpace(this._clientId) && !String.IsNullOrWhiteSpace(this._clientSecret);
                        break;
                    case ActiveDirectoryAuthentication.AuthMethod.Login:
                        Valid = !String.IsNullOrWhiteSpace(this._clientId);
                        break;
                }
            }

            if (Valid)
            {
                this._managementHandler = new FrontDoorManagement(this._subscriptionId, this._managementAuthenticationMethod, this._aadTenant, this._clientId, this._clientSecret);
                this.tabControlAreas.Enabled = true;
            }
            else
            {
                this.tabControlAreas.Enabled = false;
            }

        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions OptionForm = new FormOptions()
            {
                SelectedAuthenticationMethod = _managementAuthenticationMethod,
                SubscriptionId = _subscriptionId,
                ClientId = _clientId,
                ClientSecret = _clientSecret,
                AadTenant = _aadTenant
            };

            if (OptionForm.ShowDialog(this) == DialogResult.OK)
            {
                this._managementAuthenticationMethod = OptionForm.SelectedAuthenticationMethod;
                this._subscriptionId = OptionForm.SubscriptionId;
                this._clientId = OptionForm.ClientId;
                this._clientSecret = OptionForm.ClientSecret;
                this._aadTenant = OptionForm.AadTenant;

                SetUiSate();
            }
        }

        #region Front Doors
        private async void buttonLoadFrontDoors_Click(object sender, EventArgs e)
        {
            this.dataGridViewFrontDoors.DataSource = null;

            IEnumerable<FrontDoorModel> FrontDoorRecords = await this._managementHandler.GetFrontDoors();

            this.dataGridViewFrontDoors.DataSource = FrontDoorRecords;
        }

        private void DataGridViewFrontDoors_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridViewFrontEnds.DataSource = null;

            DataGridViewRow SelectedRow = this.dataGridViewFrontDoors.Rows[e.RowIndex];

            FrontDoorModel SelectedFrontDoor = SelectedRow?.DataBoundItem as FrontDoorModel;

            if (SelectedFrontDoor != null)
            {
                this.dataGridViewFrontEnds.DataSource = SelectedFrontDoor.FrontendEndpoints;
            }
        }
        #endregion

        #region Front Ends
       
        #endregion

    }
}
