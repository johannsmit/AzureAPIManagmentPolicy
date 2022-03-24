namespace AzureAPIManagementPolicy.Models
{
    public interface IApi
    {
        string Id { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        IEnumerable<string> Protocols { get; set; }
        Url ServiceUrl { get; set; }
        ISubscriptionKeyParameterNames SubscriptionKeyParameterNames { get; set; }
    }

    public class Api : IApi
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public IEnumerable<string> Protocols { get; set; }
        public Url ServiceUrl { get; set; }
        public ISubscriptionKeyParameterNames SubscriptionKeyParameterNames { get; set; }

        public bool IsCurrentVersion { get; set; }
        public string Revision { get; set; }
        public string Version { get; set; }
    }
}