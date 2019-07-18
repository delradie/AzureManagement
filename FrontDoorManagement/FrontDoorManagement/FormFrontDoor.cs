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
            if(!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultSubscriptionId"]))
            {
                _subscriptionId = ConfigurationManager.AppSettings["DefaultSubscriptionId"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultAadTenant"]))
            {
                _aadTenant = ConfigurationManager.AppSettings["DefaultAadTenant"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultClientId"]))
            {
                _clientId = ConfigurationManager.AppSettings["DefaultClientId"];
            }

            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DefaultClientSecret"]))
            {
                _clientSecret = ConfigurationManager.AppSettings["DefaultClientSecret"];
            }

            if(!String.IsNullOrWhiteSpace(_clientId) && !String.IsNullOrWhiteSpace(_clientSecret))
            {
                _managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal;
            }
            else if (!String.IsNullOrWhiteSpace(_clientId))
            {
                _managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.Login;
            }
            else
            {
                _managementAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity;
            }

            SetUiSate();
        }

        private async void buttonLoadFrontDoors_Click(object sender, EventArgs e)
        {
            this.dataGridViewFrontDoors.DataSource = null;

            IEnumerable<FrontDoorModel> FrontDoorRecords = await this._managementHandler.GetFrontEnds();

            this.dataGridViewFrontDoors.DataSource = FrontDoorRecords;
        }

        private void SetUiSate()
        {
            Boolean Valid = true;

            if (String.IsNullOrWhiteSpace(_subscriptionId))
            {
                Valid = false;
            }
            else
            {
                switch(_managementAuthenticationMethod)
                {
                    case ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal:
                        Valid = !String.IsNullOrWhiteSpace(_clientId) && !String.IsNullOrWhiteSpace(_clientSecret);
                        break;
                    case ActiveDirectoryAuthentication.AuthMethod.Login:
                        Valid = !String.IsNullOrWhiteSpace(_clientId);
                        break;
                }
            }

            if(Valid)
            {
                _managementHandler = new FrontDoorManagement(_subscriptionId, _managementAuthenticationMethod, _aadTenant, _clientId, _clientSecret);
                tabControlAreas.Enabled = true;
            }
            else
            {
                tabControlAreas.Enabled = false;
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

            if(OptionForm.ShowDialog(this) == DialogResult.OK)
            {
                _managementAuthenticationMethod = OptionForm.SelectedAuthenticationMethod;
                _subscriptionId = OptionForm.SubscriptionId;
                _clientId = OptionForm.ClientId;
                _clientSecret = OptionForm.ClientSecret;
                _aadTenant = OptionForm.AadTenant;

                SetUiSate();
            }
        }
    }
}
