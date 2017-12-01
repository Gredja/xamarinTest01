using MongoDB.Bson.Serialization.Attributes;
using Study02.Infrastructure.Dto.Base;

namespace Study02.Infrastructure.Dto
{
    public class Debtor : BaseModel
    {
        [BsonRequired]
        public string Name { get; set; }
    }
}
