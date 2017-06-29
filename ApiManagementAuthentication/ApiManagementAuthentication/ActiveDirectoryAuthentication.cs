using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiManagementAuthentication
{
    /// <summary>
    /// Simplified interface to Azure AD app authentication
    /// </summary>
    public class ActiveDirectoryAuthentication
    {
        //tenant name from Azure AD
        private String _tenant;
        //AD authentication URL
        private String _authority;
        //Resource being authenticated - specific URL for azure management interfaces
        private const String _adResource = "https://management.azure.com/";

        /// <summary>
        /// Tenant name from Azure AD
        /// </summary>
        /// <param name="tenant"></param>
        public ActiveDirectoryAuthentication(String tenant)
        {
            this._tenant = tenant;
            
            //Generate a standard form URL for Azure AD authentication, 
            //based on the tenant (domain) in Azure AD that the app is registered under
            this._authority = String.Format("https://login.microsoftonline.com/{0}", tenant);
        }

        /// <summary>
        /// Gets an AD bearer token based on the authentication credentials
        /// </summary>
        /// <param name="clientId">Client ID - Application ID from Essentials view in Azure AD App Registration</param>
        /// <param name="clientKey">Current Client Key - Generated in the Keys section of Azure AD App Registration</param>
        /// <returns></returns>
        public async Task<String> GetBearerToken(String clientId, String clientKey)
        {
            IPlatformParameters Params = new PlatformParameters(PromptBehavior.Auto, null);

            ClientCredential ClientCred = new ClientCredential(clientId, clientKey);

            AuthenticationContext Context = new AuthenticationContext(this._authority);
            AuthenticationResult ServiceResult = await Context.AcquireTokenAsync(_adResource, ClientCred);

            String Token = ServiceResult.AccessToken;

            return Token;
        }
    }
}
