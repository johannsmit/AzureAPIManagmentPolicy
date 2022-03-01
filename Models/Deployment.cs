using System.Security.Cryptography.X509Certificates;

namespace AzureAPIManagementPolicy.Models
{
    public class Deployment
    {
        public string GatewayId { get; set; }
        public string Region { get; set; }
        public string ServiceName { get; set; }
        public IReadOnlyDictionary<string, X509Certificate2> Certificates { get; set; }
    }
}