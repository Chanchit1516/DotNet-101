using System.ComponentModel.DataAnnotations;

namespace DotNet_101.Core.DTOs
{
    public class CustomerDTO : BaseDTO
    {
        public int CustomerId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string Phone { get; set; }
        [Required]
        public string Country { get; set; }
    }
}