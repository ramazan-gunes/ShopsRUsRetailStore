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
    public class EfDiscountRepository : EfEntityRepositoryBase<Discount>, IDiscount
    {
        public EfDiscountRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
