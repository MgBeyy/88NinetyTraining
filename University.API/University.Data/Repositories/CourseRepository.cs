using University.Data.Context;
using University.Data.Entities;
using University.Data.Repositories.Interfaces;

namespace University.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly UniversityDbContext _context;
        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public void Create(Course course)
        {
            if (course == null) 
                throw new ArgumentNullException(nameof(course));

            course.CreatedAt = DateTime.Now;
            course.LastUpdatedAt = DateTime.Now;
            _context.Add(course);
        }

        public void Delete(Course course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            _context.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
            
        }

        public Course GetById(int Id)
        {
            return _context.Courses.Find(Id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            course.LastUpdatedAt = DateTime.Now;
            _context.Update(course);
        }
    }
}
