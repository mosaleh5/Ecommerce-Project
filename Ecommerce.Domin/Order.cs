﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domin
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

       // public OrderStatus Status { get; set; }
  
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
     
    }
}
