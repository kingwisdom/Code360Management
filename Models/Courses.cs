using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.models
{
    public class Courses
    {
        public int Id { get; set; }
        public CourseName Course_Name { get; set; }
        public CourseLevel Level { get; set; }
        public double Cost { get; set; }
        public List<ProgramCourses> Programmes { get; set; }
    }
}
