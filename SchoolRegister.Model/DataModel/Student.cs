using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Student
    {
        public Group? Group { get; set; }
        public int? GroupId { get; set; }
        public virtual IList<Grade>? Grades { get; set; }
        public Parent? Parent { get; set; }
        public int? ParentId { get; set; }
        public double AvarageGrade { get; }
        public IDictionary<string,double>? AvarageGradePerSubject { get; set; }
        public IDictionary<string,List<GradeScale>>? GradesPerSubject { get; set; }

    }
}