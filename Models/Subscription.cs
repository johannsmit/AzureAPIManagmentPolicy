namespace AzureAPIManagementPolicy.Models
{
    public class Subscription
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public DateTime? StartDate { get; set; }
    }
}