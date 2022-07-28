using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Entities.Concrete
{
    public class Role : IdentityRole
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }


    }
}
