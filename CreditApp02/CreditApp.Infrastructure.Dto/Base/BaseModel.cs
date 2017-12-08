using SQLite.Net.Attributes;

namespace CreditApp02.Infrastructure.Dto.Base
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
    }
}
