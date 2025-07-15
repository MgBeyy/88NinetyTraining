using Microsoft.Extensions.Logging;
using University.Core.DTOs;
using University.Core.Exceptions;
using University.Core.Forms;
using University.Core.Helpers;
using University.Core.Services.Interfaces;
using University.Core.Validations;
using University.Data.Entities;
using University.Data.Repositories.Interfaces;

namespace University.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;


        public StudentService(IStudentRepository studentRepository, ILogger<StudentService> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public void Create(CreateStudentForm Form)
        {
            // Validation
            if (Form == null)
                throw new ArgumentNullException(nameof(Form));

            var validation = FormValidator.Validate(Form);
            if (!validation.IsValid) {
                LoggingHelper.LogValidationFaild(_logger);
                throw new BusinessException(validation.Errors);
            }
            var duplicateEmailStudents = _studentRepository.GetAll(s => s.Email == Form.Email);
            if (duplicateEmailStudents.Any())
                throw new BusinessException("This email already exists");

            // Logic
            var student = new Student()
            {
                Name = Form.Name,
                Email = Form.Email
            };


            // Saving
            _studentRepository.Create(student);
            _studentRepository.SaveChanges();
        }

        public void Delete(int Id)
        {
            var student = _studentRepository.GetById(Id);
            
            if (student == null)
                throw new NotFoundException("Unable to find Student");

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
                throw new NotFoundException("Unable to find Student");

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

            var validation = FormValidator.Validate(Form);
            if (!validation.IsValid)
            {
                LoggingHelper.LogValidationFaild(_logger);
                throw new BusinessException(validation.Errors);
            }


            var student = _studentRepository.GetById(Id);
            if (student == null)
                throw new BusinessException("Unable to find Student");

            // Logic
            student.Name = Form.Name;
            _studentRepository.Update(student);


            // Saving

            _studentRepository.SaveChanges();
        }
    }
}
