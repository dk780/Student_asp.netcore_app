using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Services
{
    public interface IStudentRepository
    {
        Stud GetStud(int StudId);
        IEnumerable<Stud> GetAllStud();

        Stud AddStud(Stud stud);

        Stud Update(Stud studChanges);
        Stud Delete(int StudId);
    }
}
