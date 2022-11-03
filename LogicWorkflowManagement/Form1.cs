using Microsoft.Extensions.Options;

using System.Configuration;

using Windows.System;

namespace LogicWorkflowManagement
{
    public partial class Form1 : Form
    {
        private TestbedSecrets _secrets;

        public Form1(TestbedSecrets secrets)
        {
            this._secrets = secrets;
            InitializeComponent();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            textBoxOut.Clear();

            if (String.IsNullOrWhiteSpace(textBoxSubscriptionId.Text) ||
                String.IsNullOrWhiteSpace(textBoxResourceGroup.Text))
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFromSecrets();
        }

        private void PopulateFromSecrets()
        {
            textBoxSubscriptionId.Text = _secrets?.SubscriptionId;
            textBoxResourceGroup.Text = _secrets?.ResourceGroup;
            textBoxWorkflow.Text = _secrets?.Workflow;
            textBoxAuthTenant.Text = _secrets?.AuthTenant;
            textBoxAuthAppId.Text = _secrets?.AuthAppId;
            textBoxAuthAppKey.Text = _secrets?.AuthAppKey;
        }
    }
}