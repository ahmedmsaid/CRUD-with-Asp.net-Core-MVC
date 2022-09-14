using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lab1.Models
{
    public class Project
    {
        [Key]
        public int Pnumber { get; set; }
        public string Pname { get; set; }
        public string Location { get; set; }
        [ForeignKey("Dnum")]
        public int Dnum { get; set; }
        public Department Department { get; set; }
        public List<WorkFor> WorkedOn { get; set; }
    }
}
