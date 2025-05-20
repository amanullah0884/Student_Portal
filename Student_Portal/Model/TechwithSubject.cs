using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class TechwithSubject
    {
            public int Id { get; set; }

            [Required]
            [ForeignKey("Technology")]
            public int TechId { get; set; }

            [Required]
            [ForeignKey("Subject")]
            public int SubId { get; set; }

            // Navigation Properties
            public Technology Technology { get; set; }
            public virtual Subject Subject { get; set; }
        }
    }