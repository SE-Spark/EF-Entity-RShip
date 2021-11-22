using Entity_Rship.Data.Db;
using Entity_Rship.Data.Dto;
using Entity_Rship.Data.Entities;
using Entity_Rship.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Repository
{
    public class ClassRepository : IRepo<ClassDto>
    {
        public readonly DatabaseContext _context;
        public ClassRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }


        public void delete(object Tid)
        {
            throw new NotImplementedException();
        }

        public ClassDto get(int id)
        {
            var res2 = _context.classes.Where(c => c.Id == id).SingleOrDefault();
          
            return new ClassDto
            {
                Id =res2.Id,
                Name = res2.Name,
                Students = (from s in _context.students.Where(b => b.ClassId == res2.Id).ToList()
                            select new StudentDto
                            {
                                Name = s.Name,
                                StudentId = s.StudentId,
                                ClassId = s.ClassId
                            }).ToList(),
            };
        }

        public ClassDto get()
        {
            throw new NotImplementedException();
        }

        public IList<ClassDto> getAll()
        {
            //var res = _context.classes//.Include("Students")
            //    .ToList();
            var res2 = (from a in _context.classes.ToList()
                        select new ClassDto
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Students=(from s in _context.students.Where(b=>b.ClassId==a.Id).ToList() 
                                      select new StudentDto {
                                          Name=s.Name,
                                          StudentId=s.StudentId,
                                          ClassId=s.ClassId
                                      }).ToList(),
                        }).ToList();

                
            return res2;
        }

        public void insert(ClassDto T)
        {
            _context.classes.Add(new Class { Name=T.Name});
            _context.SaveChanges();
        }

        public void update(ClassDto T)
        {
            throw new NotImplementedException();
        }
    }
}
