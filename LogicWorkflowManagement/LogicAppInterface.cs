using Azure;
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

        public LogicWorkflowResource GetLogicWorkflowResource(String name)
        {
            //Create an authenticated instance of the core SDK client
            ArmClient Client = new ArmClient(this._credentials);

            //Generate the resource identified for the workflow
            //Each of the key model types that can be retreived from the API should have an appropriate static CreateResourceIdentifier method
            //  so you don't have to manually figure out the structure
            ResourceIdentifier WorkflowIdentifier = LogicWorkflowResource.CreateResourceIdentifier(_subscriptionId, _resourceGroup, name);

            //Get the specified workflow resource - this actually just creates a "placeholder" that is not necessarily valid
            LogicWorkflowResource Workflow = Client.GetLogicWorkflowResource(WorkflowIdentifier);

            if(Workflow is not null)
            {
                Workflow = Workflow.EnsureData();
            }

            return Workflow;
        }        
    }

    /// <summary>
    /// Additional utility extension methods
    /// </summary>
    internal static class LogicAppExtensions
    {
        /// <summary>
        /// Ensures that the source workflow is fully populated. If the resource is not populated and is invalid this will return null
        /// </summary>
        /// <param name="source">Workflow to operate on</param>
        /// <returns>A fully data-populated worflow if valid, or null if not</returns>
        public static LogicWorkflowResource EnsureData(this LogicWorkflowResource source)
        {
            if(source.HasData)
            {
                return source;
            }

            try
            {
                var FullResponse = source.Get();

                return FullResponse.Value;
            }
            catch(RequestFailedException)
            {
                return null;
            }
        }
    }
}
