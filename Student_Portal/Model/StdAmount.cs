using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Portal.Model
{
    public class StdAmount
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("StudentBasic")]
        public int StdId { get; set; }

        [Required]
        [ForeignKey("FeeHead")]
        public int FeeHeadId { get; set; }

        [Required]
        [Range(0, 100000, ErrorMessage = "Amount must be between 0 and 100000")]
        public float Amount { get; set; }

        [Range(0, 100000, ErrorMessage = "Pay amount must be between 0 and 100000")]
        public float PayAmount { get; set; }

        [Range(0, 100000, ErrorMessage = "Discount must be valid")]
        public float DiscountAmount { get; set; }

        [Required(ErrorMessage = "Payment date is required")]
        public DateTime PaymentDate { get; set; }

        public StudentBasic StudentBasic { get; set; }
        public FeeHead FeeHead { get; set; }
    }
}
