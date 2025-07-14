using University.Core.DTOs;
using University.Core.Forms;
using University.Core.Services.Interfaces;
using University.Data.Entities;
using University.Data.Repositories.Interfaces;

namespace University.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(CreateStudentForm Form)
        {
            // Validation
            if (Form == null)
                throw new ArgumentNullException(nameof(Form));

            if (string.IsNullOrEmpty(Form.Name))
                throw new Exception("Name Is Required!");

            if (string.IsNullOrEmpty(Form.Email))
                throw new Exception("Email Is Required!");

            // Logic
            var student = new Student()
            {
                Name = Form.Name,
                Email = Form.Email
            };


            // Saving
            _studentRepository.Add(student);
            _studentRepository.SaveChanges();
        }

        public void Delete(int Id)
        {
            var student = _studentRepository.GetById(Id);
            
            if (student == null)
                throw new Exception("Unable to find Student");

            _studentRepository.Delete(student);
            _studentRepository.SaveChanges();
        }

        public List<StudentDto> GetAll()
        {
            var students = _studentRepository.GetAll();
            var dtos = students.Select(student => new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email
            }).ToList();
            return dtos;
        }

        public StudentDto GetById(int Id)
        {
            var student = _studentRepository.GetById(Id);
            if (student == null)
                throw new Exception("Unable to find Student");

            var dto = new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email
            };
            return dto;
            
        }

        public void Update(int Id, UpdateStudentForm Form)
        {
            // Validation
            if (Form == null)
                throw new ArgumentNullException(nameof(Form));

            if (string.IsNullOrEmpty(Form.Name))
                throw new Exception("Name Is Required!");
            var student = _studentRepository.GetById(Id);
            if (student == null)
                throw new Exception("Unable to find Student");

            // Logic
            student.Name = Form.Name;
            _studentRepository.Update(student);


            // Saving

            _studentRepository.SaveChanges();
        }
    }
}
