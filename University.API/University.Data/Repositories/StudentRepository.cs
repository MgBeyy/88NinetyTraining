using University.Data.Context;
using University.Data.Entities;
using University.Data.Repositories.Interfaces;

namespace University.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityDbContext _context;

        public StudentRepository(UniversityDbContext context)
        {
            _context = context;

        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int Id)
        {
            return _context.Students.First(t => t.Id == Id);
        }

        public void Add(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            student.CreatedAt = DateTime.Now;
            _context.Add(student);
        }

        public void Update(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            student.LastUpdatedAt = DateTime.Now;
            _context.Update(student);
        }

        public void Delete(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            _context.Remove(student);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}

