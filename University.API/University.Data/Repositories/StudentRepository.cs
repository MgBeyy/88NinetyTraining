﻿using System.Linq.Expressions;
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
            return _context.Students.Find(Id);
        }

        public void Create(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            student.CreatedAt = DateTime.Now;
            student.LastUpdatedAt = DateTime.Now;
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

        public List<Student> GetAll(Expression<Func<Student, bool>> where)
        {
            return _context.Students.Where(where).ToList();
        }
    }
}

