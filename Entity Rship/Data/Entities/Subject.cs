using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public String Name { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
