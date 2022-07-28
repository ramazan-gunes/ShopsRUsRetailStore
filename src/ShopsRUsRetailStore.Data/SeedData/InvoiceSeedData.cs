using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Data.SeedData
{
    public static class InvoiceSeedData
    {

        public static List<Invoice> GetData()
        {
            List<Invoice> invoices = new List<Invoice>();

            for (int i = 1; i <= 4; i++)
            {
                invoices.Add(new Invoice
                {
                    Id = i,
                    CreatedDate = new DateTime(2022, 07, 28, i, 0, 0),
                    ModifiedDate = new DateTime(2022, 07, 28, i, 0, 0),
                    Number = $"INV20202200002680{i}",
                    TotalPrice = 100 * i,
                    OrderId = i,

                });
            }
            return invoices;
        }

    }
}
