using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModel
{
    public class Role : IdentityRole<int>
    {
        public RoleValue RoleValue { get; set; }
        public Role(String Name,
                    RoleValue roleValue):base(Name)
        {
            RoleValue=roleValue;
        }
     
    }
}