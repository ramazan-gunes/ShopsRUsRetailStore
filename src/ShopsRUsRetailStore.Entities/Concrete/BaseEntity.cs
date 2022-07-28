using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.Abstract;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class BaseEntity : IEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
