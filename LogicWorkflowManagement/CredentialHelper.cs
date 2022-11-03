using Azure.Identity;

namespace LogicWorkflowManagement
{
    internal static class CredentialHelper
    {
        public static Azure.Core.TokenCredential GetCredential(String tenant)
        {
            return new DefaultAzureCredential(new DefaultAzureCredentialOptions()
            {
                ExcludeInteractiveBrowserCredential = false,
                InteractiveBrowserTenantId = tenant,
                SharedTokenCacheTenantId = tenant,
                VisualStudioCodeTenantId = tenant,
                VisualStudioTenantId = tenant
            });
        }

        public static Azure.Core.TokenCredential GetCredential(String tenant, String appId, String appKey)
        {
            if (String.IsNullOrWhiteSpace(appId) || String.IsNullOrWhiteSpace(appKey))
            {
                return GetCredential(tenant);
            }
            else
            {
                return new ClientSecretCredential(tenant, appId, appKey);
            }
        }
    }
}
