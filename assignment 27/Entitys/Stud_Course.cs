using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Stud_Courses")]
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public string Course_Id { get;set; }
        public double Grade { get; set; }

        //navigation property
        [InverseProperty("Stud_Course")]
        public Student Students { get; set; }

        [InverseProperty("course_stud")]
        public Course course { get; set; }
    }
}
