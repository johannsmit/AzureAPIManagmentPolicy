namespace AzureAPIManagementPolicy.Models
{
    public class Response
    {
        public IMessageBody Body { get; set; }
        public IReadOnlyDictionary<string, string[]> Headers { get; set; }
        public int StatusCode { get; set; }
        public string StatusReason { get; set; }
    }
}