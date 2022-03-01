namespace AzureAPIManagementPolicy.Models
{
    public enum ProductState
    {
        NotPublished,
        Published
    }

    public class Product
    {
        public IEnumerable<IApi> Apis { get; set; }
        public bool ApprovalRequired { get; set; }
        public IEnumerable<IGroup> Groups { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public ProductState State { get; set; }
        public int? SubscriptionLimit { get; set; }
        public bool SubscriptionRequired { get; set; }
    }
}