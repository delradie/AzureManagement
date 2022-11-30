using Azure.Core;

namespace LogicWorkflowManagement
{
    public static class LocationHelper
    {
        public static IEnumerable<String> GetAzureLocationNames()
        {
            return typeof(AzureLocation).GetProperties().Select(p => p.Name);
        }
    }
}
