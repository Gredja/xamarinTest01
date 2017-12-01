using MongoDB.Bson.Serialization.Attributes;
using Study02.Helpers;
using Study02.Infrastructure.Data.Model.Base;

namespace Study02.Infrastructure.Data.Model
{
    public class User : BaseModel
    {
        [BsonRequired]
        public string ForeignId { get; set; }

        [BsonRequired]
        public string Email { get; set; }

        [BsonRequired]
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
