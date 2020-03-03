using EmployeeManagment.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Guarantor> guarantors { get; set; }
        
        public DbSet<AcademyProgram> AcademyPrograms { get; set; }
        public DbSet<Batches> Batches { get; set; }
        public DbSet<StudentInBatch> StudentsInBatches { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<ProgramCourses> ProgramCourses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Salary> Salaries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramCourses>()
                .HasKey(p => new { p.AcademyProgramId, p.CourseId });

            modelBuilder.Entity<ProgramCourses>()
                .HasOne(pc => pc.Programme)
                .WithMany(ap => ap.ProgrammeCourses)
                .HasForeignKey(pc => pc.AcademyProgramId);

            modelBuilder.Entity<ProgramCourses>()
                .HasOne(pc => pc.Course)
                .WithMany(c => c.Programmes)
                .HasForeignKey(pc => pc.CourseId);

            // ManyToMany(Student and Batch)
            modelBuilder.Entity<StudentInBatch>()
                .HasKey(s => new { s.StudentId, s.BatchId });

            modelBuilder.Entity<StudentInBatch>()
                .HasOne(sb => sb.student)
                .WithMany(s => s.BatchesIn)
                .HasForeignKey(sb => sb.StudentId);

            modelBuilder.Entity<StudentInBatch>()
                .HasOne(sb => sb.Batch)
                .WithMany(b => b.StudentsIn)
                .HasForeignKey(sb => sb.BatchId);

            // OneToMany(Student and Projects)
            modelBuilder.Entity<Project>()
                .HasOne(p => p.student)
                .WithMany(s => s.Projects);

            // OneToMany(Student and Guarantor)
            modelBuilder.Entity<Guarantor>()
                .HasOne(g => g.student)
                .WithMany(s => s.Guarantors);

            // ManyToMany(Student and Company)
            modelBuilder.Entity<Employment>()
                .HasKey(k => new { k.StudentId, k.CompanyId });

            modelBuilder.Entity<Employment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Employments)
                .HasForeignKey(e => e.StudentId);
            modelBuilder.Entity<Employment>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employments)
                .HasForeignKey(e => e.CompanyId);

        }
    }
}
