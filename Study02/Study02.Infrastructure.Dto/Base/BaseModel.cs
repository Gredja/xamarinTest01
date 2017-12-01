using MongoDB.Bson.Serialization.Attributes;

namespace Study02.Infrastructure.Dto.Base
{
    public class BaseModel
    {
        [BsonId]
        public string Id { get; set; }
    }
}
