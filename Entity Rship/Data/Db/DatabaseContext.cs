using Entity_Rship.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Db
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (local)\\SQL2019; Database = r_ship_test; User Id = superadmin; Password = samuel4300;");
            }
        }

        public DbSet<Class> classes { get; set; }

        public DbSet<Student> students { get; set; }

        public DbSet<Subject> subjects { get; set; }
        public DbSet<Teacher> teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubject>()
                .HasKey(t => new { t.StudentId, t.SubjectId });
            modelBuilder.Entity<StudentSubject>()
                .HasOne(st => st.Student)
                .WithMany(ss => ss.StudentSubjects)
                .HasForeignKey(st => st.StudentId);

            modelBuilder.Entity<StudentSubject>()
                .HasOne(sb => sb.Subject)
                .WithMany(ss => ss.StudentSubjects)
                .HasForeignKey(sb => sb.SubjectId);
        }
    }
}
