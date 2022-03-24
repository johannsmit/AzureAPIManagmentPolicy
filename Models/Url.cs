namespace AzureAPIManagementPolicy.Models
{
    public interface IUrl
    {
        string Host { get; set; }
        string Path { get; set; }
        int Port { get; set; }
        IReadOnlyDictionary<string, string[]> Query { get; set; }
        string QueryString { get; set; }
        string Scheme { get; set; }
    }

    public class Url : IUrl
    {
        public string Host { get; set; }
        public string Path { get; set; }
        public int Port { get; set; }
        public IReadOnlyDictionary<string, string[]> Query { get; set; }
        public string QueryString { get; set; }
        public string Scheme { get; set; }
    }
}