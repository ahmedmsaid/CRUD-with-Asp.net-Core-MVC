using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lab1.Models
{
    public class WorkFor
    {
        [ForeignKey("ESSN")]
        public int ESSN { get; set; }
        [ForeignKey("Pno")]
        public int Pno { get; set; }
        public int Hours { get; set; }
        public Employee? Emp { get; set; }
        public Project? Projects { get; set; }
    }
}
