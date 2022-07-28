using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class InvoiceDetail : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //TODO : We need all product detail because product always changing.
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}
