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
    public class FrontDoorManagementSdk
    {
        private readonly ActiveDirectoryAuthentication _authenticationHandler;
        private readonly String _subscriptionId;

        public String LastError { get; private set; }

        public FrontDoorManagementSdk(String subscriptionId, ActiveDirectoryAuthentication.AuthMethod authMethod, String aadTenant, String clientId, String clientSecret) : this(subscriptionId, new ActiveDirectoryAuthentication(authMethod, aadTenant, clientId, clientSecret))
        { }

        public FrontDoorManagementSdk(String subscriptionId, ActiveDirectoryAuthentication authenticationHandler)
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

        public async Task<IEnumerable<FrontDoorModel>> GetFrontDoors()
        {
            FrontDoorManagementClient Interface = await GetClientInstance();

            IEnumerable<FrontDoorModel> Output = await Interface.FrontDoors.ListAsync();

            return Output?.ToList();
        }

        public async Task<IEnumerable<FrontendEndpoint>> GetFrontEnds(String resourceGroup, String frontDoor)
        {
            FrontDoorManagementClient Interface = await GetClientInstance();

            IEnumerable<FrontendEndpoint> Output = await Interface.FrontendEndpoints.ListByFrontDoorAsync(resourceGroup, frontDoor);

            return Output?.ToList();
        }

        public async Task<Boolean> CreateFrontEnd(String resourceGroup, String frontDoor, String endpointName, String hostName)
        {
            FrontDoorManagementClient Interface = await GetClientInstance();

            FrontendEndpoint Parameters = new FrontendEndpoint()
            {
                HostName = hostName,
                Name = endpointName,
                SessionAffinityEnabledState = "Enabled",
                WebApplicationFirewallPolicyLink = null,
            };

            AzureOperationResponse<FrontDoorModel> Response;

            try
            {
                FrontDoorModel TargetFrontDoor = Interface.FrontDoors.Get(resourceGroup, frontDoor);

                TargetFrontDoor.FrontendEndpoints.Add(Parameters);

                Response = await Interface.FrontDoors.CreateOrUpdateWithHttpMessagesAsync(resourceGroup, frontDoor, TargetFrontDoor);
            }
            catch (ErrorResponseException exc)
            {
                this.LastError = exc.Response?.Content;

                if (String.IsNullOrWhiteSpace(this.LastError))
                {
                    this.LastError = exc.ToString();
                }

                return false;
            }

            return (Response.Response.IsSuccessStatusCode);
        }

        public async Task<Boolean> EnableCustomHttps(String resourceGroup, String frontDoor, String endpointName, String vaultId, String secretName, String secretVersion)
        {
            CustomHttpsConfiguration EndpointHttpsConfiguration = new CustomHttpsConfiguration();

            EndpointHttpsConfiguration.CertificateSource = "AzureKeyVault";
            EndpointHttpsConfiguration.Vault = new KeyVaultCertificateSourceParametersVault(vaultId);
            EndpointHttpsConfiguration.SecretName = secretName;
            EndpointHttpsConfiguration.SecretVersion = secretVersion;
            EndpointHttpsConfiguration.ProtocolType = "ServerNameIndication";

            AzureOperationResponse Response = null;

            using (FrontDoorManagementClient Interface = await GetClientInstance())
            {
                Response = await Interface.FrontendEndpoints.EnableHttpsWithHttpMessagesAsync(resourceGroup, frontDoor, endpointName, EndpointHttpsConfiguration);
            }

            return (Response.Response.IsSuccessStatusCode);
        }
    }

}
