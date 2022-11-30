using Azure.ResourceManager;
using Azure.ResourceManager.Logic;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public WorkflowEditor(LogicAppInterface managementInterface, LogicWorkflowResource targetWorkflow)
        {
            this._managementInterface = managementInterface;
            this._targetWorkflow = targetWorkflow;

            InitializeComponent();

            DisplayDefinition();
        }

        private void DisplayDefinition()
        {
            textBoxDefinition.Text = _targetWorkflow?.Data?.Definition?.ToString();
            textBoxID.Text = _targetWorkflow?.Data?.Id?.ToString();
            textBoxName.Text = _targetWorkflow?.Data?.Name?.ToString();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
