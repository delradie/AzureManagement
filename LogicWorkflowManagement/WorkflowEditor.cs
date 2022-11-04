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
        public WorkflowEditor(LogicAppInterface managementInterface)
        {
            InitializeComponent();
        }

        public WorkflowEditor(LogicAppInterface managementInterface, LogicWorkflowResource targetWorkflow)
        {
            InitializeComponent();
        }
    }
}
