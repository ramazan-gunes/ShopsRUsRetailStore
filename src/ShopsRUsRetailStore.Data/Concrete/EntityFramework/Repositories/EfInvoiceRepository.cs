using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopsRUsRetailStore.Core.Concrete.EntityFramework;
using ShopsRUsRetailStore.Data.Abstract;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Repositories
{
    public class EfInvoiceRepository : EfEntityRepositoryBase<Invoice>, IInvoice
    {
        public EfInvoiceRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
