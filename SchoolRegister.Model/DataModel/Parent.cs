using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Parent
    {
        public virtual IList<Student>? Students { get; set; }
    }
}