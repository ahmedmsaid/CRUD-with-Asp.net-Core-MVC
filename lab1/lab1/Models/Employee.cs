using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lab1.Models
{
    public class Employee
    {
        [Key]
        public int SSN { get; set; }

        [Required(ErrorMessage = "Employee name is rquired")]
        [MinLength(3, ErrorMessage = "Name must be more than 3 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is rquired")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age is rquired")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Salary cannot be empty")]
        public float Salary { get; set; }

        [NotMapped]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Phone Number must match regex")]
        public string PhoneNumber { get; set; }

        [ForeignKey("Dnum")]
        public int? Dnum { get; set; }

        public Department Departments { get; set; }
        public List<WorkFor> WorksOn { get; set; }
    }
}
