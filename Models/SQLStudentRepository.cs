using EmployeeManagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public class SQLStudentRepository : IStudentRepo, IGuarantorRepo
    {
        private readonly AppDbContext context;

        public SQLStudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

       
        public Student Delete(int id)
        {
            Student employee = context.Students.Find(id);
            if (employee != null)
            {
                context.Students.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

 

        public IEnumerable<Student> GetAllStudent()
        {
            return context.Students;
        }

        public Student GetStudent(int id)
        {
            return context.Students.Find(id);
        }

        public Student Update(Student student)
        {
            var employ = context.Students.Attach(student);
            employ.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return student;
        }

        //guarantor process
        public Guarantor AddGuarantor(Guarantor guarantor)
        {
            context.guarantors.Add(guarantor);
            context.SaveChanges();
            return guarantor;
        }
        public Guarantor GetGuarantor(int Id)
        {
            return context.guarantors.Find(Id);
        }

        public IEnumerable<Guarantor> GetGuarantors()
        {
            return context.guarantors;
        }

        public Guarantor UpdateGuarantor(Guarantor guarantorChanges)
        {
            var guarantor = context.guarantors.Attach(guarantorChanges);
            guarantor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return guarantorChanges;
        }

        public Guarantor DeleteGuarantor(int id)
        {
            Guarantor guarantor = context.guarantors.Find(id);
            if (guarantor != null)
            {
                context.guarantors.Remove(guarantor);
                context.SaveChanges();
            }
            return guarantor;
        }

    }
}
