using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class User : IdentityUser
    {
        public UserTypeEnum Type { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserAgent { get; set; }
        public string? IpAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
