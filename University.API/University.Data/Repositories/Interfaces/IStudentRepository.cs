using System.Linq.Expressions;
using University.Data.Entities;

namespace University.Data.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student GetById(int Id);
        List<Student> GetAll();
        public List<Student> GetAll(Expression<Func<Student, bool>> where);

        void Create (Student student);
        void Update (Student student);
        void Delete (Student student);
        void SaveChanges();

    }
}
