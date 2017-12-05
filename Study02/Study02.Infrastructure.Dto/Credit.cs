using Study02.Infrastructure.Dto.Base;

namespace Study02.Infrastructure.Dto
{
    public class Credit : BaseModel
    {
        public string ForeignId { get; set; }

        public string Currency { get; set; }

        public int Amount { get; set; }

        public bool Active { get; set; } = true;

        public string Comment { get; set; }
    }
}
