using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.Entities;

namespace University.Data.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student GetById(int Id);
        List<Student> GetAll();
        void Add (Student student);
        void Update (Student student);
        void Delete (Student student);
        void SaveChanges();
    }
}
