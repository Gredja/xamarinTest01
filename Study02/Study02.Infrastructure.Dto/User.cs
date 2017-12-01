using MongoDB.Bson.Serialization.Attributes;
using Study02.Helpers;
using Study02.Infrastructure.Dto.Base;

namespace Study02.Infrastructure.Dto
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
