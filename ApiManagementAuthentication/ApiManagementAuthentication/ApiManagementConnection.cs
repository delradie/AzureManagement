using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiManagementAuthentication
{
    /// <summary>
    /// Factory for authenticated instances of the API management interface
    /// </summary>
    public class ApiManagementConnection
    {
        //Bearer token generated from Azure AD
        private String _bearerToken;
        //ID of the Azure subscription that contains the API Management service
        private String _subscriptionId;

        /// <summary>
        /// Creates an authenticated API Management client
        /// </summary>
        public ApiManagementClient Instance
        {
            get
            {
                //Create a token authorization header
                SubscriptionCloudCredentials Creds = new TokenCloudCredentials(this._subscriptionId, this._bearerToken);

                //Create the management client with the specified credentials
                return new ApiManagementClient(Creds);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bearerToken">Bearer token generated from Azure AD</param>
        /// <param name="subscriptionId">ID of the Azure subscription that contains the API Management service</param>
        public ApiManagementConnection(String bearerToken, String subscriptionId)
        {
            this._bearerToken = bearerToken;
            this._subscriptionId = subscriptionId;
        }
    }
}
