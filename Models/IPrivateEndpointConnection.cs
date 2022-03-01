namespace AzureAPIManagementPolicy.Models
{
    public interface IPrivateEndpointConnection
    {
        public string Name { get; set; }
        public string GroupId { get; set; }
        public string MemberName { get; set; }
    }
}