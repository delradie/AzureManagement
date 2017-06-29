using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiManagementAuthentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckAuthenticationInputs(object sender, EventArgs args)
        {
            BGetToken.Enabled = (!String.IsNullOrWhiteSpace(TBTenant.Text)
                                    && !String.IsNullOrWhiteSpace(TBClientId.Text)
                                    && !String.IsNullOrWhiteSpace(TBClientKey.Text));
        }

        private async void BGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveDirectoryAuthentication Authenticator = new ActiveDirectoryAuthentication(TBTenant.Text);

                String ReturnedBearerToken = await Authenticator.GetBearerToken(TBClientId.Text, TBClientKey.Text);

                TBBearerToken.Text = ReturnedBearerToken;

                GBApiManagement.Enabled = true;
            }
            catch(Exception exc)
            {
                GBApiManagement.Enabled = false;
                MessageBox.Show("Error getting bearer token:" + Environment.NewLine + exc.ToString());
            }
        }

        public void CheckApiManagementInputs(object sender, EventArgs args)
        {
            BGetSubscriptions.Enabled = (!String.IsNullOrWhiteSpace(TBSubscriptionId.Text)
                                    && !String.IsNullOrWhiteSpace(TBResourceGroup.Text)
                                    && !String.IsNullOrWhiteSpace(TBServiceName.Text));
        }

        private async void BGetSubscriptions_Click(object sender, EventArgs e)
        {
            ApiManagementConnection ClientFactory = new ApiManagementConnection(TBBearerToken.Text, TBSubscriptionId.Text);

            ApiManagementClient Client = ClientFactory.Instance;

            SubscriptionListResponse Response 
                = await Client.Subscriptions.ListAsync(TBResourceGroup.Text, TBServiceName.Text, null);

            DGVSubscriptions.DataSource = new BindingSource(Response.Result, "Values");
        }
    }
}
