using DotNet_101.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Order = new List<Order>();
        }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Order> Order { get; }

    }
}
