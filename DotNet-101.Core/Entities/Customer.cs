using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.Entities
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}
