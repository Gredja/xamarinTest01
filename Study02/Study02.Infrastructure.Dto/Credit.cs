using MongoDB.Bson.Serialization.Attributes;
using Study02.Infrastructure.Dto.Base;

namespace Study02.Infrastructure.Dto
{
    public class Credit : BaseModel
    {
        [BsonRequired]
        public string ForeignId { get; set; }

        [BsonRequired]
        public string Currency { get; set; }

        [BsonRequired]
        public int Amount { get; set; }

        [BsonRequired]
        public bool Active { get; set; } = true;

        public string Comment { get; set; }
    }
}
