using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUsRetailStore.Entities.Enums
{
    public enum UserTypeEnum
    {
        [Display(Name = "User")]
        User = 0,
        [Display(Name = "Employee")]
        Employee = 1,
        [Display(Name = "Affiliate")]
        Affiliate = 2,
        [Display(Name = "Customer")]
        Customer = 3,
    }
}
