using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ManagementApiExecute
{
    public partial class FormExecute : Form
    {
        private ActiveDirectoryAuthentication _auth;

        private String _subscriptionId;
        private ActiveDirectoryAuthentication.AuthMethod _managementAuthenticationMethod;
        private String _aadTenant;
        private String _clientId;
        private String _clientSecret;

        public FormExecute()
        {
            InitializeComponent();
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

        private void FormExecute_Load(object sender, EventArgs e)
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

            CBMethod.SelectedIndex = 0;

            SetUiSate();
        }

        private void CBMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Method = CBMethod.SelectedItem as String;

            if(String.IsNullOrEmpty(Method))
            {
                return;
            }

            TBInput.Enabled = (Method == "PUT" || Method == "POST");
        }

        private async void BExecute_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();

            String Url = TBUrl.Text;
            String AuthenticationToken =await _auth.GetBearerToken();

            Url = Url.Replace("{subscriptionId}", _subscriptionId);

            try
            {
                HttpClient ManagementClient = new HttpClient();
                ManagementClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthenticationToken);

                HttpResponseMessage Response;

                StringContent Content = null;

                if(TBInput.Enabled && String.IsNullOrWhiteSpace(TBInput.Text))
                {
                    Content = new StringContent(TBInput.Text.Trim(), Encoding.UTF8, "application/json");
                }
             
                switch(CBMethod.SelectedItem as String)
                {
                    case "GET":
                        Response = await ManagementClient.GetAsync(Url);
                        break;
                    case "PUT":
                        Response = await ManagementClient.PutAsync(Url, Content);
                        break;
                    case "POST":
                        Response = await ManagementClient.PostAsync(Url, Content);
                        break;
                    case "DELETE":
                        Response = await ManagementClient.DeleteAsync(Url);
                        break;
                    default:
                        return;
                }

                StringBuilder OutputBuilder = new StringBuilder(500);

                if(Response.IsSuccessStatusCode)
                {
                    OutputBuilder.AppendLine("SUCCESS");
                }
                else
                {
                    OutputBuilder.AppendLine("FAILED");
                }

                OutputBuilder.AppendLine($"{Response.StatusCode}");

                if(Response.Content.Headers.ContentLength > 0)
                {
                    String ResponseContent = await Response.Content.ReadAsStringAsync();

                    OutputBuilder.AppendLine(ResponseContent);
                }

                TBOutput.Text = OutputBuilder.ToString();
            }
            catch(Exception exc)
            {
                TBOutput.Text = exc.ToString();
            }
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
                this._auth = new ActiveDirectoryAuthentication(this._managementAuthenticationMethod, this._aadTenant, this._clientId, this._clientSecret);
                this.BExecute.Enabled = true;
            }
            else
            {
                this.BExecute.Enabled = false;
            }

        }
    }
}
