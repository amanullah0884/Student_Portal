using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Student_Portal.Model
{

    public class StudentPortalDbContext : DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> options) : base(options)
        {
        }

        public DbSet<FeeHead> FeeHeads { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        //public DbSet<Shift> shifts { get; set; }
        public DbSet<StdAmount> StdAmounts { get; set; }
        public DbSet<StdSemester> StdSemesters { get; set; }
        public DbSet<StudentAcademic> StudentAcademics { get; set; }
        public DbSet<StudentBasic> StudentBasics { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Technology> Technologys { get; set; }
        public DbSet<TechwithSubject> TechwithSubjects
        {
            get; set;


        }
    }
}
