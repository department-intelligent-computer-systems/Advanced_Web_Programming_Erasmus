using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group Group { get; set; } = default!;
        public int GroupId { get; set; } = default!;
        public IList<Grade> Grades { get; set; } = default!;
        public Parent Parent { get; set; } = default!;
        public int ParentId { get; set; } = default!;
        public double AvarageGrade { get; } = default!;
        public IDictionary<string, double> AvarageGradePerSubject { get; } = default!;
        public IDictionary<string, List<GradeScale>> GradePerSubject { get; } = default!;






    }
}
