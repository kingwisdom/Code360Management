using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Student_Id { get; set; }
        public ProjectStatus Project_Status { get; set; }
        public string ProjectUrl { get; set; }
        public Student student { get; set; }
    }
}
