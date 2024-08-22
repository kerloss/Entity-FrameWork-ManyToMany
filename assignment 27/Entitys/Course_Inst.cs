using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Course_Insts")]
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public double Evaluation { get; set; }

        //Navigatoin prop
        [InverseProperty("course_Insts")]
        public Course courses { get; set; }

        [InverseProperty("inst_course")]
        public Instructor instructors { get; set; }
    }
}
