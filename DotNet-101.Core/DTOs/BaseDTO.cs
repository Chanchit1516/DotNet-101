using System;
using System.Collections.Generic;
using System.Text;
using DotNet_101.SharedKernel.Helpers;

namespace DotNet_101.Core.DTOs
{
    public class BaseDTO
    {
        public BaseDTO()
        {
            CreatedDateTime = DateTimeHelper.Now();
        }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
