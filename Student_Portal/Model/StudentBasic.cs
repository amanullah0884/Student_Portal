using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class StudentBasic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Father's name is required")]
        [StringLength(100)]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Mother's name is required")]
        [StringLength(100)]
        public string MotherName { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [Phone(ErrorMessage = "Invalid mobile number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Present address is required")]
        [StringLength(200)]
        public string PresentAdd { get; set; }

        [Required(ErrorMessage = "Permanent address is required")]
        [StringLength(200)]
        public string PermanentAdd { get; set; }

        [StringLength(250)]
        public string ImagePath { get; set; }
    }
}
