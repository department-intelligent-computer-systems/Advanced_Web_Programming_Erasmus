using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class RoleValue
    {
        public enum RoleValues{
            User=0,
            Student=1,
            Parent=2,
            Teacher=3,
            Admin=4
        }
    }
}