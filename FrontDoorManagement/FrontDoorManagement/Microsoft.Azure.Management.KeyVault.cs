using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Management.KeyVault;
using Microsoft.Azure.Management.KeyVault.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontDoorManagement
{
    public class KeyVaultManagementSdk
    {
        private readonly ActiveDirectoryAuthentication _authenticationHandler;
        private readonly String _subscriptionId;

        public String LastError { get; private set; }

        public KeyVaultManagementSdk(String subscriptionId, ActiveDirectoryAuthentication.AuthMethod authMethod, String aadTenant, String clientId, String clientSecret) : this(subscriptionId, new ActiveDirectoryAuthentication(authMethod, aadTenant, clientId, clientSecret))
        { }

        public KeyVaultManagementSdk(String subscriptionId, ActiveDirectoryAuthentication authenticationHandler)
        {
            this._authenticationHandler = authenticationHandler;
            this._subscriptionId = subscriptionId;
        }

        public async Task<KeyVaultClient> GetClientInstance()
        {
            String BearerToken = await this._authenticationHandler.GetBearerToken();
            ServiceClientCredentials Creds = new TokenCredentials(BearerToken);
            KeyVaultClient Client = new KeyVaultClient(Creds);

            return Client;
        }

        public async Task<KeyVaultManagementClient> GetManagementClientInstance()
        {
            String BearerToken = await this._authenticationHandler.GetBearerToken();
            ServiceClientCredentials Creds = new TokenCredentials(BearerToken);
            KeyVaultManagementClient Client = new KeyVaultManagementClient(Creds)
            {
                SubscriptionId = _subscriptionId
            };

            return Client;
        }

        public async Task<IEnumerable<Resource>> GetKeyVaults()
        {
            using (KeyVaultManagementClient Client = await GetManagementClientInstance())
            {
                IEnumerable<Resource> Vaults = await Client.Vaults.ListAsync();

                return Vaults;
            }
        }

        public async Task<Vault> GetKeyVault(String resourceGroup, String vaultName)
        {
            using (KeyVaultManagementClient Client = await GetManagementClientInstance())
            {
                Vault TargetVault = await Client.Vaults.GetAsync(resourceGroup, vaultName);

                return TargetVault;
            }
        }
        public async Task<object> GetKeyVaultCertificates(Vault targetVault)
        {
            using (KeyVaultClient Client = await GetClientInstance())
            {
                Client.GetCertificatesAsync(targetVault.)
            }
        }
    }
}
