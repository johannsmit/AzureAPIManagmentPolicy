namespace AzureAPIManagementPolicy.Models
{
    public class LastError
    {
        public string Source { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
        public string Scope { get; set; }
        public string Section { get; set; }
        public string Path { get; set; }
        public string PolicyId { get; set; }
    }
}