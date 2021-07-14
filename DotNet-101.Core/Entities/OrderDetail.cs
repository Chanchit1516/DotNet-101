using DotNet_101.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderDetailId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Qty { get; set; }
    }
}
