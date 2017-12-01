using System.ComponentModel.DataAnnotations;
using Study02.Domain.Models.Base;

namespace Study02.Domain.Models
{
    public class Debtor : BaseModel
    {
        [Required(ErrorMessage = "Name cannot be empty!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name cannot be empty!")]
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
