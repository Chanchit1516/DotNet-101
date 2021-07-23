using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet_101.Core.DTOs
{
    public class OrderDTO : BaseDTO
    {
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        public int ShippedId { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}