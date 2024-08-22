using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    [Table("Departments")]
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        //Navigation prop [one]
        [InverseProperty("departmentOneToOne")]
        public Instructor instructorOneToOne { get; set; }

        [InverseProperty("departmentManyToOne")]
        public ICollection<Instructor> instructorManyToOne {  get; set; } = new HashSet<Instructor>();

        //navigation prop [many with student]
        [InverseProperty("department")]
        public ICollection<Student> students { get; set; } = new HashSet<Student>();
    }
}
