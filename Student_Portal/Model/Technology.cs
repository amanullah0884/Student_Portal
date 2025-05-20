using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class Technology
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Technology name is required")]
        [StringLength(100, ErrorMessage = "Name can't exceed 100 characters")]
        public string Name { get; set; }
    }
}
