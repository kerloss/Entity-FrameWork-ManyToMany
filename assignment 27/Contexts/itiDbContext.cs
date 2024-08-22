using assignment_27.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Contexts
{
    internal class itiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = KERLOSS ; DataBase = ITIDbContext3 ; Trusted_Connection = true ; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API Configuration Realationships

            //getdate for table course
            modelBuilder.Entity<Course>(E => { E.Property(C => C.Duration).HasComputedColumnSql("GETDATE()"); });

            modelBuilder.Entity<Department>()
                .HasOne(i => i.instructorOneToOne)
                .WithOne(d => d.departmentOneToOne)
                .HasForeignKey<Instructor>(I => I.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasMany(i => i.instructorManyToOne)
                .WithOne(d => d.departmentManyToOne)
                .OnDelete(DeleteBehavior.Restrict);

            //Mant to Many to Course_Student
            modelBuilder.Entity<Stud_Course>()
                .HasKey(SC => new { SC.Stud_Id, SC.Course_Id });

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Stud_Course)
                .WithOne(sc => sc.Students)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.course_stud)
                .WithOne(cs => cs.course)
                .OnDelete(DeleteBehavior.Restrict);

            //Many To Many to Course_Instructor
            modelBuilder.Entity<Course_Inst>()
                .HasKey(CI => new { CI.Course_Id, CI.Inst_Id });

            modelBuilder.Entity<Course>()
                .HasMany(C => C.course_Insts)
                .WithOne(CI => CI.courses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Instructor>()
                .HasMany(I => I.inst_course)
                .WithOne(IC => IC.instructors)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.ApplyConfiguration(new CourseConfiguration());
            //modelBuilder.ApplyConfiguration(new Course_InstructorConfiguration());
            //modelBuilder.ApplyConfiguration(new Student_CourseConfiguration());

        }

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        //public DbSet<Course_Inst> course_Insts { get; set; }
        //public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
