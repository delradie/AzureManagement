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

using Windows.Media.Protection.PlayReady;

namespace LogicWorkflowManagement
{
    public class LogicAppInterface
    {
        private String _subscriptionId;
        private String _resourceGroup;
        private TokenCredential _credentials;

        private ArmClient _client;

        public LogicAppInterface(String subscriptionId, String resourceGroup, TokenCredential credentials)
        {
            this._subscriptionId = subscriptionId;
            this._resourceGroup = resourceGroup;
            this._credentials = credentials;

            //Create an authenticated instance of the core SDK client
            this._client = new ArmClient(this._credentials);
        }

        public LogicWorkflowCollection ListLogicApps()
        {
            //Generate the resource identified for the resource group
            //Each of the key model types that can be retreived from the API should have an appropriate static CreateResourceIdentifier method
            //  so you don't have to manually figure out the structure
            ResourceIdentifier ResourceGroupIdentifier = ResourceGroupResource.CreateResourceIdentifier(_subscriptionId, _resourceGroup);

            //Get a reference to the target Resource Group
            ResourceGroupResource ResourceGroup = this._client.GetResourceGroupResource(ResourceGroupIdentifier);
            LogicWorkflowCollection Workflows = ResourceGroup.GetLogicWorkflows();

            return Workflows;
        }

        public LogicWorkflowResource GetLogicWorkflowResource(String name)
        {
            //Generate the resource identified for the workflow
            //Each of the key model types that can be retreived from the API should have an appropriate static CreateResourceIdentifier method
            //  so you don't have to manually figure out the structure
            ResourceIdentifier WorkflowIdentifier = LogicWorkflowResource.CreateResourceIdentifier(_subscriptionId, _resourceGroup, name);

            //Get the specified workflow resource - this actually just creates a "placeholder" that is not necessarily valid
            LogicWorkflowResource Workflow = this._client.GetLogicWorkflowResource(WorkflowIdentifier);

            return Workflow;
        }

        public LogicWorkflowResource SetLogicWorkflowResource(String name, String definition, String azureLocation)
        {
            AzureLocation Location = new AzureLocation(azureLocation);

            LogicWorkflowCollection ResourceGroupWorkflows = ListLogicApps();

            LogicWorkflowData WorkflowData = new LogicWorkflowData(Location)
            {
                Definition = BinaryData.FromString(definition),
            };

            ArmOperation<LogicWorkflowResource> Response = ResourceGroupWorkflows.CreateOrUpdate(WaitUntil.Completed, name, WorkflowData);

            return Response.Value;
        }

        public void DeleteWorkflow(String name)
        {
            ResourceIdentifier WorkflowIdentifier = LogicWorkflowResource.CreateResourceIdentifier(_subscriptionId, _resourceGroup, name);

            LogicWorkflowResource TargetResource = this._client.GetLogicWorkflowResource(WorkflowIdentifier);

            TargetResource.Delete(WaitUntil.Completed);
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
            if (source.HasData)
            {
                return source;
            }

            try
            {
                var FullResponse = source.Get();

                return FullResponse.Value;
            }
            catch (RequestFailedException)
            {
                return null;
            }
        }
    }
}
