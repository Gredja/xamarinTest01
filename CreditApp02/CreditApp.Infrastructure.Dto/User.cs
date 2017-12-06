using CreditApp.Infrastructure.Dto.Base;
using CreditApp02.Helpers;

namespace CreditApp.Infrastructure.Dto
{
   public class User : BaseModel
    {
        public string ForeignId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
