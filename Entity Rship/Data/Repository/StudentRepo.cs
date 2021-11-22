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
    public class StudentRepo : IRepo<Student>
    {
        private readonly DatabaseContext _context;
        

        public StudentRepo(DatabaseContext databaseContext)
        {
            this._context = databaseContext;
        }
        public void delete(object Tid)
        {
            throw new NotImplementedException();
        }

        public Student get()
        {
            throw new NotImplementedException();
        }

        public IList<StudentDto> getAll()
        {
            var res = _context.students
                .ToList();

            var rees2 = (from s in _context.students.Include("Class").ToList()
                         select new StudentDto {
                             Class=new ClassDto
                             {
                                 Id=s.Class.Id,
                                 Name=s.Class.Name
                             },
                             ClassId=s.ClassId,
                             Name=s.Name,
                             StudentId=s.StudentId
                         }).ToList();
            return rees2;
        }

        public void insert(Student T)
        {
            _context.students.Add(T);
            _context.SaveChanges();
        }

        public void update(Student T)
        {
            throw new NotImplementedException();
        }

        IList<Student> IRepo<Student>.getAll()
        {
            throw new NotImplementedException();
        }
    }
}
