using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class SemesterwithSubject
    {
        
            public int Id { get; set; }

            [Required]
            [ForeignKey("Subject")]
            public int SubId { get; set; }

            [Required]
            [ForeignKey("Semester")]
            public int SemesterId { get; set; }

            [Required(ErrorMessage = "Year is required")]
            [StringLength(10, ErrorMessage = "Year should not exceed 10 characters")]
            public string Year { get; set; }

            
            public Subject Subject { get; set; }
            public Semester Semester { get; set; }
        }
    
}
