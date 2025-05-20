using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Portal.Model
{
    public class Semester
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Semester name is required")]
        [StringLength(50, ErrorMessage = "Semester name can't exceed 50 characters")]
        public string Name { get; set; }
    }
    

}
