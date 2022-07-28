using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Entities.DTOs.Order
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserId { get; set; }
        public Concrete.User User { get; set; }
        public ICollection<Concrete.Invoice> Invoices { get; set; }
    }
}
