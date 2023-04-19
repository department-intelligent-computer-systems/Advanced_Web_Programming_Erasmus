using System;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public virtual RoleValue RoleValue {get; set;} = default!;
        public Role(string name, RoleValue roleValue) {}
    }
    
}