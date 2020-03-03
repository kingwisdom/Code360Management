using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.ViewModel
{
    public class GuarantorViewModel
    {

        public Student student { get; set; }
        public Guarantor guarantor { get; set; }
    }
}
