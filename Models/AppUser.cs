using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N0855975_assessment2.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
