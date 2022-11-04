using Azure.Core;
using Azure.ResourceManager.Logic;

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
            listBoxWorkflows.Items.Clear();

            if (String.IsNullOrWhiteSpace(textBoxSubscriptionId.Text) ||
                String.IsNullOrWhiteSpace(textBoxResourceGroup.Text) ||
                String.IsNullOrWhiteSpace(textBoxAuthTenant.Text))
            {
                return;
            }

            TokenCredential ManagementCredential = CredentialHelper.GetCredential(textBoxAuthTenant.Text, textBoxAuthAppId.Text, textBoxAuthAppKey.Text);

            LogicAppInterface ManagementInterface = new LogicAppInterface(textBoxSubscriptionId.Text, textBoxResourceGroup.Text, ManagementCredential);

            LogicWorkflowCollection LogicApps = ManagementInterface.ListLogicApps();

            if(LogicApps is null)
            {
                textBoxOut.Text = "Null Return";
            }
            else if(LogicApps.Count() == 0)
            {
                textBoxOut.Text = "No Logic Apps Returned";
            }
            else
            {
                textBoxOut.Text = $"{LogicApps.Count()} Logic Apps Returned:{Environment.NewLine + Environment.NewLine}";

                listBoxWorkflows.DataSource = LogicApps.Cast<LogicWorkflowResource>().ToList();
                listBoxWorkflows.DisplayMember = "Id";
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