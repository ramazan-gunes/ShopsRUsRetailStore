using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.Abstract;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class Invoice : BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Number { get; set; } // must be a unique value
        public decimal TotalPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<InvoiceDetail> Details { get; set; }

    }
}
