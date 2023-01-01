using Azure.Core;
using Azure.ResourceManager.Logic;

namespace LogicWorkflowManagement
{
    public partial class WorkflowEditor : Form
    {
        LogicAppInterface _managementInterface;
        LogicWorkflowResource? _targetWorkflow;

        public WorkflowEditor(LogicAppInterface managementInterface)
        {
            this._managementInterface = managementInterface;

            InitializeComponent();

            this.buttonCreate.Enabled = true;
            this.buttonUpdate.Enabled = false;

            DisplayDefinition();
        }

        public WorkflowEditor(LogicAppInterface managementInterface, LogicWorkflowResource targetWorkflow)
        {
            this._managementInterface = managementInterface;
            this._targetWorkflow = targetWorkflow;

            InitializeComponent();

            this.buttonCreate.Enabled = false;
            this.buttonUpdate.Enabled = true;

        }

        private void DisplayDefinition()
        {
            textBoxDefinition.Text = _targetWorkflow?.Data?.Definition?.ToString();
            textBoxID.Text = _targetWorkflow?.Data?.Id?.ToString();
            textBoxName.Text = _targetWorkflow?.Data?.Name?.ToString();

            List<String> Locations = LocationHelper.GetAzureLocationNames().ToList();

            comboBoxLocation.DataSource = Locations;

            if (!String.IsNullOrWhiteSpace(_targetWorkflow?.Data?.Location.Name))
            {
                String? LocationName = Locations.FirstOrDefault(x => String.Equals(x, _targetWorkflow.Data.Location.Name, StringComparison.InvariantCultureIgnoreCase));
                
                if(!String.IsNullOrWhiteSpace(LocationName))
                    comboBoxLocation.SelectedItem = LocationName;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AzureLocation TargetLocation = new AzureLocation(comboBoxLocation.SelectedItem as String);

            this._managementInterface.SetLogicWorkflowResource(textBoxName.Text, textBoxDefinition.Text, TargetLocation);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AzureLocation TargetLocation = new AzureLocation(comboBoxLocation.SelectedItem as String);

            this._managementInterface.SetLogicWorkflowResource(textBoxName.Text, textBoxDefinition.Text, TargetLocation);
        }

        private void WorkflowEditor_Load(object sender, EventArgs e)
        {
            DisplayDefinition();
        }
    }
}
