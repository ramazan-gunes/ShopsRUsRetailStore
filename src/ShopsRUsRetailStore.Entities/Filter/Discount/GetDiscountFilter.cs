using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Entities.Filter.Discount
{
    public class GetDiscountFilter
    {
        public int? Id { get; set; }
        public UserTypeEnum? UserType { get; set; }
    }
}
