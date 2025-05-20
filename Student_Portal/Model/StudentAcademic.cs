using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Portal.Model
{
    public class StudentAcademic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the board roll")]
        [StringLength(50)]
        public string BoardRoll { get; set; }

        [StringLength(100)]
        public string Registration { get; set; }

        [StringLength(50)]
        public string Session { get; set; }

        [Required(ErrorMessage = "Please select shift")]
        public Shift ShiftInfo { get; set; } 

        [Required]
        [ForeignKey("StudentBasic")]
        public int StudentId { get; set; }

        [StringLength(20)]
        public string Semester { get; set; }

        [StringLength(10)]
        public string Year { get; set; }

       
        public StudentBasic StudentBasic { get; set; }
    }
   
}
