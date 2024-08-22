using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_27.Entitys
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation property => [many]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
