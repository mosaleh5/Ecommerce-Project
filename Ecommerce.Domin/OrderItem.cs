﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domin
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public Product? Product { get; set; }
        public int? ProductId { get; set; }
        public int Quabtity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
    }
}
