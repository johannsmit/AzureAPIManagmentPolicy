namespace AzureAPIManagementPolicy.Models
{
    public class User
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public IEnumerable<IGroup> Groups { get; set; }
        public string Id { get; set; }
        public IEnumerable<IUserIdentity> Identities { get; set; }
        public string LastName { get; set; }
        public string Note { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}