using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Data.SeedData
{
    public static class OrderSeedData
    {

        public static List<Order> GetData()
        {

            List<Order> orders = new List<Order>();

            for (int i = 1; i <= 4; i++)
            {
                orders.Add(new Order
                {
                    Id=i,
                    CreatedDate = new DateTime(2022, 07, 28, i, 0, 0),
                    ModifiedDate = new DateTime(2022, 07, 28, i, 0, 0),
                    Number = $"RAM20202200002680{i}",
                    TotalPrice = 400 * i,
                    UserId = "f575f-a333-4d94-81f1-ad27652a146" + i
                });
            }

            return orders;

        }
    }
}
