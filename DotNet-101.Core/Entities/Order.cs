using DotNet_101.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderDetail = new List<OrderDetail>();
        }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShippedId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; }
    }
}
