using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public DateTime DateOfIssue {get; set;}
        public GradeScale GradeValue {get; set;} = default!;
        public virtual Subject Subject {get; set;} = default!;
        [ForeignKey("Subject")]
        public int SubjectId {get; set;} = default!;
        public int StudentId {get; set;} = default!;
        public Student Student {get; set;} = default!;
    }
}