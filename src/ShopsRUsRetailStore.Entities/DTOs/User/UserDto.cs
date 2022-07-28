using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Entities.DTOs.User
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserTypeEnum Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
