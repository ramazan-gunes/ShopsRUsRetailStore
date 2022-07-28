using ShopsRUsRetailStore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUsRetailStore.Entities.DTOs.Discount
{
    public class AddDiscountDto
    {
        public string? Description { get; set; }
        public decimal Rate { get; set; }
        public bool IsPercentage { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
