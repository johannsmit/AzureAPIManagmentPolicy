using System.Security.Cryptography.X509Certificates;

namespace AzureAPIManagementPolicy.Models
{
    public class Request
    {
        public IMessageBody? Body { get; set; }
        public X509Certificate2 Certificate { get; set; }
        public IReadOnlyDictionary<string, string[]> Headers { get; set; }
        public string IpAddress { get; set; }
        public IReadOnlyDictionary<string, string> MatchedParameters { get; set; }
        public string Method { get; set; }
        public Url OriginalUrl { get; set; }
        public Url Url { get; set; }
        public IPrivateEndpointConnection? PrivateEndpointConnection { get; set; }
    }
}