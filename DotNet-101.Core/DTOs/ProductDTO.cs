using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Qty { get; set; }
    }
}
