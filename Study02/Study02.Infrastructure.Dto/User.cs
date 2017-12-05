using Study02.Helpers;
using Study02.Infrastructure.Dto.Base;

namespace Study02.Infrastructure.Dto
{
    public class User : BaseModel
    {
        public string ForeignId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
