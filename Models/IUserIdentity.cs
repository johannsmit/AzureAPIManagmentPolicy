namespace AzureAPIManagementPolicy.Models
{
    public interface IUserIdentity
    {
        string Id { get; set; }
        string Provider { get; set; }
    }
}