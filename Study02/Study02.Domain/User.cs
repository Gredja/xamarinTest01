using AzureMongoDbOnion03.Helpers;

namespace AzureMongoDbOnion03.Domain
{
    public class User
    {
        public string Id { get; set; }

        public string ForeignId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
