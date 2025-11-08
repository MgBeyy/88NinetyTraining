using University.Data.Entities;

namespace University.Data.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Course GetById(int Id);
        List<Course> GetAll();
        void Create(Course course);
        void Update(Course course);
        void Delete(Course course);
        void SaveChanges();
    }
}
