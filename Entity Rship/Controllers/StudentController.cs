using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Rship.Data.Db;
using Entity_Rship.Data.Dto;
using Entity_Rship.Data.Entities;
using Entity_Rship.Data.Interfaces;
using Entity_Rship.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Rship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentRepo _repo = new StudentRepo(new DatabaseContext());

        [HttpGet]
        public IEnumerable<StudentDto> Get()
        {
            return _repo.getAll();
        }
        [HttpPost]
        [Route("add")]
        public void insert(Student s)
        {
            _repo.insert(s);
        }

        
    }
}
