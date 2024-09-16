﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domin
{
    public class Review
    {
        public int Id { get; set; }
       
        public int  Rating  { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
