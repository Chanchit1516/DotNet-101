using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.DTOs
{
    public class BaseDTO
    {
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
