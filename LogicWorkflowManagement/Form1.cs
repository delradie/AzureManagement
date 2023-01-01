using Azure.Core;
using Azure.ResourceManager.Logic;

namespace LogicWorkflowManagement
{
    public partial class Form1 : Form
    {
        private TestbedSecrets _secrets;
        private LogicAppInterface _managementInterface;

        public Form1(TestbedSecrets secrets)
        {
            this._secrets = secrets;
            InitializeComponent();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            textBoxOut.Clear();
            listBoxWorkflows.DataSource = null;

            if (String.IsNullOrWhiteSpace(textBoxSubscriptionId.Text) ||
                String.IsNullOrWhiteSpace(textBoxResourceGroup.Text) ||
                String.IsNullOrWhiteSpace(textBoxAuthTenant.Text))
            {
                return;
            }

            TokenCredential ManagementCredential = CredentialHelper.GetCredential(textBoxAuthTenant.Text, textBoxAuthAppId.Text, textBoxAuthAppKey.Text);

            _managementInterface = new LogicAppInterface(textBoxSubscriptionId.Text, textBoxResourceGroup.Text, ManagementCredential);

            if (String.IsNullOrWhiteSpace(textBoxWorkflow.Text))
            {
                LogicWorkflowCollection LogicApps = _managementInterface.ListLogicApps();

                if (LogicApps is null)
                {
                    textBoxOut.Text = "Null Return";
                }
                else if (LogicApps.Count() == 0)
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
            else
            {
                LogicWorkflowResource LogicApp = _managementInterface.GetLogicWorkflowResource(textBoxWorkflow.Text);

                if (LogicApp is null)
                {
                    textBoxOut.Text = "Null Return";
                }
                else
                {
                    textBoxOut.Text = "Logic App Returned";

                    if (!LogicApp.HasData)
                    {
                        Azure.Response<LogicWorkflowResource> Response = LogicApp.Get();

                        if (Response.Value is null)
                        {
                            textBoxOut.Text = "Logic App Is Invalid";
                        }
                        else
                        {
                            LogicApp = Response.Value;
                        }
                    }


                    listBoxWorkflows.DataSource = new List<LogicWorkflowResource>() { LogicApp };
                    listBoxWorkflows.DisplayMember = "Id";
                }
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

        private void buttonEditWorkflow_Click(object sender, EventArgs e)
        {
            LogicWorkflowResource? SelectedWorkflow = (listBoxWorkflows.SelectedItem as LogicWorkflowResource)?.EnsureData();

            if (SelectedWorkflow is not null)
            {

                WorkflowEditor Editor = new WorkflowEditor(this._managementInterface, SelectedWorkflow);

                Editor.ShowDialog(this);
            }
        }

        private void buttonAddWorkflow_Click(object sender, EventArgs e)
        {
            WorkflowEditor Editor = new WorkflowEditor(this._managementInterface);

            Editor.ShowDialog(this);

        }

        private void buttonDeleteWorkflow_Click(object sender, EventArgs e)
        {
            LogicWorkflowResource? SelectedWorkflow = (listBoxWorkflows.SelectedItem as LogicWorkflowResource)?.EnsureData();

            if (SelectedWorkflow is not null)
            {
                SelectedWorkflow.EnsureData();

                DialogResult Result = MessageBox.Show($"Are you sure you wish to delete workflow {SelectedWorkflow.Data.Name}?", "Delete Workflow", MessageBoxButtons.YesNo);

                if(Result == DialogResult.Yes)
                {
                    this._managementInterface.DeleteWorkflow(SelectedWorkflow.Data.Name);
                }
            }
        }        
    }
}