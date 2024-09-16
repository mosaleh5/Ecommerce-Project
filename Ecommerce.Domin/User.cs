using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domin
{
    public class User
    {   
        public int Id { get; set; }
        [Required , MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]

        public string LastName { get; set; }
        [Required, EmailAddress]

        public string Email { get; set; }
        [Required]
          
        public string? Password { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Cart Cart { get; set; }
    }
}
