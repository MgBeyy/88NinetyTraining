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
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILogger<ICourseRepository> _logger;

        public CourseService(ICourseRepository courseRepository, ILogger<ICourseRepository> logger)
        {
            _courseRepository = courseRepository;
            _logger = logger;
        }

        public void Create(CreateCourseForm Form)
        {
            // Validation
            if (Form == null)
                throw new ArgumentNullException(nameof(Form));

            var validation = FormValidator.Validate(Form);
            if (!validation.IsValid) {
                LoggingHelper.LogValidationFaild(_logger);
                throw new BusinessException(validation.Errors);
            }
            // Logic
            var course = new Course()
            {
                Title = Form.Title,
                Description = Form.Description,
            };


            //Saving 
            _courseRepository.Create(course);
            _courseRepository.SaveChanges();

        }

        public void Delete(int Id)
        {
            // Validation
            var course = _courseRepository.GetById(Id);
            if (course == null)
                throw new NotFoundException("Course not found");

            // Saving
            _courseRepository.Delete(course);
            _courseRepository.SaveChanges();

        }

        public List<CourseDto> GetAll()
        {
            // Logic
            var courses = _courseRepository.GetAll();
            var dtos = courses.Select(course => new CourseDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description
            }).ToList();

            // Return
            return dtos;


        }

        public CourseDto GetById(int Id)
        {
            // Validation
            var course = _courseRepository.GetById(Id);
            if (course == null)
                throw new NotFoundException("Course not found");

            // Logic
            var dto = new CourseDto()
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description
            };

            // Return
            return dto;
        }

        public void Update(int Id, UpdateCourseForm Form)
        {
            // Validation
            if (Form == null)
                throw new ArgumentNullException(nameof(Form));

            var validation = FormValidator.Validate(Form);
            if (!validation.IsValid) {
                LoggingHelper.LogValidationFaild(_logger);
                throw new BusinessException(validation.Errors);
            }
            var course = _courseRepository.GetById(Id);
            if (course == null)
                throw new NotFoundException("Course not found");

            // Logic
            course.Title = Form.Title;
            course.Description = Form.Description;


            //Saving 
            _courseRepository.Update(course);
            _courseRepository.SaveChanges();
        }
    }
}
