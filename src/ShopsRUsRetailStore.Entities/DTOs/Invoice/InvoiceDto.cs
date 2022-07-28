using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Entities.DTOs.Invoice
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Number { get; set; } // must be a unique value
        public decimal TotalPrice { get; set; }

        public virtual Concrete.Order Order { get; set; }
        public virtual ICollection<InvoiceDetail> Details { get; set; }
    }
}
