using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Instructors")]
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bounce { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public string Address { get; set; }
        public double Hour_Rate { get; set; }
        //Navigation prop [one]

        [InverseProperty("instructorOneToOne")]
        public Department departmentOneToOne { get; set; }

        [InverseProperty("instructorManyToOne")]
        public Department departmentManyToOne { get; set; }

        [InverseProperty("instructors")]
        public ICollection<Course_Inst> inst_course {  get; set; } = new HashSet<Course_Inst>();
    }
}
