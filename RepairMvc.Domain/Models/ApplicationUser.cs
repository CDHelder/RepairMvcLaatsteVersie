using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RepairMvc.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAdress")]
        public string Emailadress { get; set; }

        public ICollection<Order> Orders { get; set; } // Order
    }
}
