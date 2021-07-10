using DotNet_101.SharedKernel.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTimeHelper.Now();
        }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
