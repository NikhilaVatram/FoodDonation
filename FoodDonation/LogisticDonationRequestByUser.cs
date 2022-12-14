using System.ComponentModel.DataAnnotations;

namespace FoodDonation
{
    public class LogisticDonationRequestByUser
    {
        //Users Willing to donate Logistics facility
        [Key]
        public int RequestId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string PurposeofDonation { get; set; }
    }
}
