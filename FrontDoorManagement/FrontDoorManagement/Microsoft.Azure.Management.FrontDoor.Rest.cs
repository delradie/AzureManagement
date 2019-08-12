using Microsoft.Rest;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FrontDoorManagement
{
    public class FrontDoorManagementApi
    {
        private readonly ActiveDirectoryAuthentication _authenticationHandler;
        private readonly String _subscriptionId;

        public String LastError { get; private set; }

        public FrontDoorManagementApi(String subscriptionId, ActiveDirectoryAuthentication.AuthMethod authMethod, String aadTenant, String clientId, String clientSecret) : this(subscriptionId, new ActiveDirectoryAuthentication(authMethod, aadTenant, clientId, clientSecret))
        { }

        public FrontDoorManagementApi(String subscriptionId, ActiveDirectoryAuthentication authenticationHandler)
        {
            this._authenticationHandler = authenticationHandler;
            this._subscriptionId = subscriptionId;
        }

        public async Task<HttpClient> GetClientInstance()
        {
            String BearerToken = await this._authenticationHandler.GetBearerToken();
            ServiceClientCredentials Creds = new TokenCredentials(BearerToken);

            AuthenticationHeaderValue AuthenticationHeader = new AuthenticationHeaderValue("Bearer", BearerToken);

            HttpClient Client = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = AuthenticationHeader }
            };

            return Client;
        }

    }
}
