using Code360StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.models
{
    public interface IGuarantorRepo
    {
        Guarantor GetGuarantor(int Id);
        IEnumerable<Guarantor> GetGuarantors();
        Guarantor AddGuarantor(Guarantor guarantor);
        Guarantor UpdateGuarantor(Guarantor guarantorChanges);
        Guarantor DeleteGuarantor(int id);
    }
}
