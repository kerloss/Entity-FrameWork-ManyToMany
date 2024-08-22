using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Courses")]
    internal class Course
    {
        public int Id { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Navigation property  => [one]
        public Topic Topic { get; set; }

        [InverseProperty("course")]
        public ICollection<Stud_Course> course_stud { get; set; } = new HashSet<Stud_Course>();

        [InverseProperty("courses")]
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
