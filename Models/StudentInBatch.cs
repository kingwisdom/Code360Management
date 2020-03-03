using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.models
{
    public class StudentInBatch
    {
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int BatchId { get; set; }
        public Batches Batch { get; set; }
        public Status StdStatus { get; set; }
        public Grade StdGrade { get; set; }
    }
}
