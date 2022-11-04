using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic;
using Azure.ResourceManager.Resources;

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicWorkflowManagement
{
    internal class LogicAppInterface
    {
        private String _subscriptionId;
        private String _resourceGroup;
        private TokenCredential _credentials;

        public LogicAppInterface(String subscriptionId, String resourceGroup, TokenCredential credentials) { 
            this._subscriptionId = subscriptionId;
            this._resourceGroup = resourceGroup;
            this._credentials = credentials;
        }

        public LogicWorkflowCollection ListLogicApps()
        {
            //Create an authenticated instance of the core SDK client
            ArmClient Client = new ArmClient(this._credentials);

            //Generate the resource identified for the resource group
            //Each of the key model types that can be retreived from the API should have an appropriate static CreateResourceIdentifier method
            //  so you don't have to manually figure out the structure
            ResourceIdentifier ResourceGroupIdentifier = ResourceGroupResource.CreateResourceIdentifier(_subscriptionId, _resourceGroup);

            //Get a reference to the target Resource Group
            ResourceGroupResource ResourceGroup = Client.GetResourceGroupResource(ResourceGroupIdentifier);
            LogicWorkflowCollection Workflows = ResourceGroup.GetLogicWorkflows();

            return Workflows;
        }
    }
}
