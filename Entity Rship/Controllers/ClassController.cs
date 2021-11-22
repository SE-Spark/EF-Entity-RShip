using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Rship.Data.Dto;
using Entity_Rship.Data.Entities;
using Entity_Rship.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Rship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private ClassRepository _repo;
        public ClassController()
        {
            _repo = new ClassRepository(new Data.Db.DatabaseContext());
        }
        [HttpGet]
        public IEnumerable<ClassDto> Get()
        {
            return _repo.getAll();
        }
        [HttpGet]
        [Route("les")]
        public ClassDto GetLess()
        {
            return _repo.get(1);
        }
        [HttpPost]
        [Route("add")]
        public void insert(ClassDto c)
        {
            _repo.insert(c);
        }
    }
}