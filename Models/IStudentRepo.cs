using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public interface IStudentRepo
    {
       Student GetStudent(int id);

        IEnumerable<Student> GetAllStudent();
        Student Add(Student student);
        Guarantor AddGuarantor(Guarantor guarantor);
        Student Update(Student student);
        Student Delete(int id);
    }
}
