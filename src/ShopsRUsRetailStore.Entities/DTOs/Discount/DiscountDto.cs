using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Enums;


namespace ShopsRUsRetailStore.Entities.DTOs.Discount
{
    public class DiscountDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Rate { get; set; }
        public bool IsPercentage { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
