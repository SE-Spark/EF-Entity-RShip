using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Dto
{
    public class ClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}
