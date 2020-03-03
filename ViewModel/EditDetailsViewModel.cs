using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class EditDetailsViewModel : CreateStudentModel
    {
        
        public int Id { get; set; }
        public string ExistingPath { get; set; }
    }
}
