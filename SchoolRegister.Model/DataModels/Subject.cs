using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        [Key]
        public int? Id {get; set;} = default!;
        public string Name {get; set;} = default!;
        public string Description {get; set;} = default!;
        public virtual IList<SubjectGroup> SubjectGroups {get; set;} = default!;
        public virtual Teacher Teacher {get; set; } = default!;
        [ForeignKey("Teacher")]
        public int? TeacherId{get; set;} = default; 
        public virtual IList<Grade> Grades {get; set;} = default!;

    }
}