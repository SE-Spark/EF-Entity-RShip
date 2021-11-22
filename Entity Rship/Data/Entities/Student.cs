using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public String Name { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
