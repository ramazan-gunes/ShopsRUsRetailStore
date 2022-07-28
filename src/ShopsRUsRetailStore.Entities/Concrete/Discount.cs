using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.Abstract;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class Discount : BaseEntity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Rate { get; set; }
        public bool IsPercentage { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
