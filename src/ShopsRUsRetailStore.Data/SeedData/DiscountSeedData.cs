using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Data.SeedData
{
    public static class DiscountSeedData
    {

        public static List<Discount> GetData()
        {
            return new List<Discount>
            {
                new()
                {
                    Id = 1,
                    Description = "Affiliate D.",
                    UserType = Entities.Enums.UserTypeEnum.Affiliate,
                    Rate = 10,
                    IsPercentage = true
                },
                new()
                {
                    Id = 2,
                    Description = "Employee D.",
                    UserType = Entities.Enums.UserTypeEnum.Employee,
                    Rate = 30,
                    IsPercentage = false
                },
                new()
                {
                    Id = 3,
                    Description = "Loyal Customer D.",
                    UserType = Entities.Enums.UserTypeEnum.Customer,
                    Rate = 5,
                    IsPercentage = true
                },
                new()
                {
                    Id = 4,
                    Description = "Price D.",
                    UserType = Entities.Enums.UserTypeEnum.User,
                    Rate = 5,
                    IsPercentage = false
                }

            };
        }
    }
}
