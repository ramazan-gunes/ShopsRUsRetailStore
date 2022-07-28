using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUsRetailStore.Entities.DTOs.Invoice
{
    public class AddInvoiceDto
    {
        public int OrderId { get; set; }
        public string Number { get; set; } // must be a unique value
        public decimal TotalPrice { get; set; }
    }
}
