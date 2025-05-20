using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Portal.Model
{
    public class Subject
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="please Enter your name")]
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsCommon { get; set; }
    }
}
