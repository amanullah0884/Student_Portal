using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class FeeHead
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fee head name is required")]
        [StringLength(100, ErrorMessage = "Name should not exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0, 100000, ErrorMessage = "Amount must be between 0 and 100000")]
        public float Amount { get; set; }
    }
}
