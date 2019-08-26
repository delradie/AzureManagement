using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontDoorManagement
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        ActiveDirectoryAuthentication.AuthMethod _selectedAuthenticationMethod
            = ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity;

        public ActiveDirectoryAuthentication.AuthMethod SelectedAuthenticationMethod
        {
            get => this._selectedAuthenticationMethod;
            set
            {
                this._selectedAuthenticationMethod = value;
                SetUi(value);
            }
        }
        public String SubscriptionId
        {
            get => this.textBoxSubscription.Text;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.textBoxSubscription.Clear();
                }
                else
                {
                    this.textBoxSubscription.Text = value;
                }
            }
        }
        public String AadTenant
        {
            get => this.textBoxAadTenant.Text;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.textBoxAadTenant.Clear();
                }
                else
                {
                    this.textBoxAadTenant.Text = value;
                }
            }
        }
        public String ClientId
        {
            get => this.textBoxClientId.Text;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.textBoxClientId.Clear();
                }
                else
                {
                    this.textBoxClientId.Text = value;
                }
            }
        }
        public String ClientSecret
        {
            get => this.textBoxClientSecret.Text;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.textBoxClientSecret.Clear();
                }
                else
                {
                    this.textBoxClientSecret.Text = value;
                }
            }
        }

        private void SetUi(ActiveDirectoryAuthentication.AuthMethod? authenticationMethod)
        {
            authenticationMethod = authenticationMethod ?? _selectedAuthenticationMethod;

            textBoxAadTenant.Enabled = (authenticationMethod != ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity);
            textBoxClientId.Enabled = (authenticationMethod != ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity);
            textBoxClientSecret.Enabled = (authenticationMethod == ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAuthLogIn.Checked)
            {
                SelectedAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.Login;
            }
            else if (radioButtonAuthServicePrincipal.Checked)
            {
                SelectedAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal;
            }
            else
            {
                SelectedAuthenticationMethod = ActiveDirectoryAuthentication.AuthMethod.ManagedIdentity;
            }
        }

        private Boolean ValidateForm()
        {
            List<String> MissingFields = new List<String>();

            if (textBoxAadTenant.Enabled && String.IsNullOrWhiteSpace(textBoxAadTenant.Text))
                MissingFields.Add("AAD Tenant");

            if (textBoxClientId.Enabled && String.IsNullOrWhiteSpace(textBoxClientId.Text))
                MissingFields.Add("Client ID");

            if (textBoxClientSecret.Enabled && String.IsNullOrWhiteSpace(textBoxClientSecret.Text))
                MissingFields.Add("Client Secret");

            if(MissingFields.Count > 0)
            {
                MessageBox.Show(this, "Missing values:" + Environment.NewLine + String.Join(Environment.NewLine, MissingFields));
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            switch(_selectedAuthenticationMethod)
            {
                case ActiveDirectoryAuthentication.AuthMethod.Login:
                    radioButtonAuthLogIn.Checked = true;
                    break;
                case ActiveDirectoryAuthentication.AuthMethod.ServicePrincipal:
                    radioButtonAuthServicePrincipal.Checked = true;
                    break;
                default:
                    radioButtonAuthManagedIdentity.Checked = true;
                    break;
            }

            SetUi(null);
        }
    }
}
