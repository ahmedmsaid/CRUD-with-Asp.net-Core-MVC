using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab1.Models
{
    public class Department
    {
        [Key]
        public int Dnum { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }
    }
}
