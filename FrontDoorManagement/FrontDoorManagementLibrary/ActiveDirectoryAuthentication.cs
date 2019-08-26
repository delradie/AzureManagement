using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDoorManagement
{
    /// <summary>
    /// Simplified interface to Azure AD app authentication
    /// </summary>
    public class ActiveDirectoryAuthentication
    {
        public enum AuthMethod
        {
            ManagedIdentity,
            ServicePrincipal,
            Login
        }

        private ActiveDirectoryAuthentication.AuthMethod _authMethod;
        private String _aadTenant;
        private String _clientId;
        private String _clientSecret;

        private const String _defaultResource = "https://management.azure.com/";

        public ActiveDirectoryAuthentication(ActiveDirectoryAuthentication.AuthMethod authMethod, String aadTenant, String clientId, String clientSecret)
        {
            _authMethod = authMethod;
            _aadTenant = aadTenant;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// Gets an AD bearer token for the specified resource
        /// </summary>
        /// <param name="resource">Target resource identifier</param>
        /// <returns></returns>
        public async Task<String> GetBearerToken(String resource = _defaultResource)
        {
            switch(this._authMethod)
            {
                case AuthMethod.ManagedIdentity:
                    return await GetBearerTokenFromManagedIdentity(resource);
                case AuthMethod.ServicePrincipal:
                    return await GetBearerTokenFromServicePrincipal(resource);
                case AuthMethod.Login:
                    return await GetBearerTokenFromLogin(resource);
            }

            return null;
        }

        private async Task<String> GetBearerTokenFromManagedIdentity(String resource)
        {
            return await new AzureServiceTokenProvider().GetAccessTokenAsync(resource).ConfigureAwait(false);
        }

        private async Task<String> GetBearerTokenFromServicePrincipal(String resource)
        {
            String AadAuthority = $"https://login.microsoftonline.com/{_aadTenant}";
            ClientCredential ClientCred = new ClientCredential(_clientId, _clientSecret);

            AuthenticationContext AuthContext = new AuthenticationContext(AadAuthority);

            AuthenticationResult ServiceResult = await AuthContext.AcquireTokenAsync(resource, ClientCred).ConfigureAwait(false);

            return ServiceResult.AccessToken;
        }

        private async Task<String> GetBearerTokenFromLogin(String resource)
        {
            String AadAuthority = $"https://login.microsoftonline.com/{_aadTenant}";
            IPlatformParameters Params = new PlatformParameters(PromptBehavior.Auto, null);

            AuthenticationContext AuthContext = new AuthenticationContext(AadAuthority);

            AuthenticationResult ServiceResult = await AuthContext.AcquireTokenAsync(resource, _clientId, new Uri("https://login.live.com/oauth20_desktop.srf"), Params).ConfigureAwait(false);

            return ServiceResult.AccessToken;
        }
    }
}
