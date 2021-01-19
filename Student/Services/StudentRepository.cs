using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Services
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentContext Context;

        public StudentRepository(StudentContext context)
        {
            Context = context;

        }

        public Stud AddStud(Stud stud)
        {

            var students = new Stud()
            {
                StudId = stud.StudId,
                Name = stud.Name,
                PhoneNumber = stud.PhoneNumber,
                Address = stud.Address,
                

            };
            Context.Set<Stud>().Add(stud);
            Context.SaveChanges();
            return stud;
        }

        public Stud Delete(int StudId)
        {
            var stud = Context.Set<Stud>().Find(StudId);
            if (stud == null)
            {
                return stud;
            }

            Context.Set<Stud>().Remove(stud);
            Context.SaveChanges();
            return stud;
        }

        public IEnumerable<Stud> GetAllStud()
        {
            return Context.Set<Stud>().ToList();
        }

        

        public Stud GetStud(int StudId)
        {
            return Context.Set<Stud>().Find(StudId);
        }

        public Stud Update(Stud studChanges)
        {
            var stud = Context.Students.Attach(studChanges);
            stud.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return studChanges;
        }
    }
}

