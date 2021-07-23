using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNet_101.Core.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
        [Required]
        public int UnitsOnOrder { get; set; }
        public string Barcode { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
