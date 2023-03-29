using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        [Key]
        public int Id {get; set;} = default!;
        [Required]
        public string Name { get; set;} = default!;
        public IList<Student> Students {get; set;} = default!;
        public IList<SubjectGroup> SubjectGroups {get; set;} = default!;
    }
}