using System.ComponentModel.DataAnnotations;
using WebApplication2.Shared;

namespace WebApplication2.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }

        public employeetype type { get; set; }



    }
}
