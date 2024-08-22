using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Students")]
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //navigation prop [one]
        [InverseProperty("students")]
        public Department department { get; set; }

        [InverseProperty("Students")]
        public ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();
    }
}
