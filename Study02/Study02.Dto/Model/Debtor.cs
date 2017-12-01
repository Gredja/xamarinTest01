using MongoDB.Bson.Serialization.Attributes;
using Study02.Infrastructure.Data.Model.Base;

namespace Study02.Infrastructure.Data.Model
{
    public class Debtor : BaseModel
    {
        [BsonRequired]
        public string Name { get; set; }
    }
}
