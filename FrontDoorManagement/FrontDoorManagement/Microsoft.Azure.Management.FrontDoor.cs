using Microsoft.Azure.Management.FrontDoor;
using Microsoft.Azure.Management.FrontDoor.Models;
using Microsoft.Rest;
using Microsoft.Rest.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontDoorManagement
{
    public class FrontDoorManagement
    {
        private readonly ActiveDirectoryAuthentication _authenticationHandler;
        private readonly String _subscriptionId;

        public FrontDoorManagement(String subscriptionId, ActiveDirectoryAuthentication.AuthMethod authMethod, String aadTenant, String clientId, String clientSecret) : this(subscriptionId, new ActiveDirectoryAuthentication(authMethod, aadTenant, clientId, clientSecret))
        { }

        public FrontDoorManagement(String subscriptionId, ActiveDirectoryAuthentication authenticationHandler)
        {
            this._authenticationHandler = authenticationHandler;
            this._subscriptionId = subscriptionId;
        }

        public async Task<FrontDoorManagementClient> GetClientInstance()
        {
            String BearerToken = await this._authenticationHandler.GetBearerToken();
            ServiceClientCredentials Creds = new TokenCredentials(BearerToken);
            FrontDoorManagementClient Client = new FrontDoorManagementClient(Creds)
            {
                SubscriptionId = _subscriptionId
            };

            return Client;
        }

        public async Task<IEnumerable<FrontDoorModel>> GetFrontEnds()
        {
            FrontDoorManagementClient Interface = await this.GetClientInstance();

            IEnumerable<FrontDoorModel> Output = await Interface.FrontDoors.ListAsync();

            return Output?.ToList();
        }
    }

}
