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
    public static class UserSeedData
    {

        public static List<User> GetData()
        {
            List<User> users = new List<User>();

            for (int i = 1; i <= 4; i++)
            {
                var user = new User()
                {
                    Id = "f575f-a333-4d94-81f1-ad27652a146" + i,
                    Type = (UserTypeEnum)Enum.Parse(typeof(UserTypeEnum), (i - 1).ToString()),
                    UserName = $"ramazan{i}",
                    NormalizedUserName = $"ramazan{i}".ToUpper(),
                    FirstName = $"Ramazan {i}",
                    LastName = $"Gunes {i}",
                    Email = $"ramazann{i}@gmail.com",
                    NormalizedEmail = $"ramazann{i}@gmail.com".ToUpper(),
                    ConcurrencyStamp = "79114edf-6c8d-494d-8e91-05caaadb920a",
                    SecurityStamp = "72545538-a690-40df-bdb5-10a8a24e06e4",
                    CreatedDate = new DateTime(2019 + i, i, i)
                };

                var passwordHasher = new PasswordHasher<User>();
                passwordHasher.HashPassword(user, "Password12*");


                users.Add(user);
            }
            return users;
        }
    }
}
