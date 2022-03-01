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
}