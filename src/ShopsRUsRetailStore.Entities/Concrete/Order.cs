using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
