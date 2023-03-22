using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Teacher
    {
        public string? Title { get; set; }
        public virtual IList<Subject>? Subjects { get; set; }
    }
}