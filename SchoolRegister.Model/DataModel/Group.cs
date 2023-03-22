using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual IList<SubjectGroup>? SubjectGroups { get; set; }
        public Teacher? Teacher { get; set; }
        public int? TeacherId { get; set; }
        public virtual IList<Grade>? Grades { get; set; }

       

    }
}