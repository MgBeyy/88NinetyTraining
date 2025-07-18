using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using University.API.Filters;
using University.API.Helpers;
using University.Core.DTOs;
using University.Core.Forms;
using University.Core.Services.Interfaces;

namespace University.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ApiExceptionFilter))]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(IStudentService studentService, ILogger<StudentsController> logger)
        {
            _studentService = studentService;
            _logger = logger;
        }


        [HttpGet("{Id}")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(typeof(StudentDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse GetById(int Id)
        {
            LoggingHelper.LogController(_logger, $"id: {Id}");
            var dto = _studentService.GetById(Id);
            return new ApiResponse(dto);
        }


        [HttpGet()]
        [ProducesResponseType(typeof(List<StudentDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse GetAll()
        {
            LoggingHelper.LogController(_logger);

            var dtos = _studentService.GetAll();
            return new ApiResponse(dtos);
        }


        [HttpPost()]
        [ProducesResponseType(typeof(void), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Create([FromBody] CreateStudentForm Form)
        {
            LoggingHelper.LogController(_logger);

            _studentService.Create(Form);
            return new ApiResponse(HttpStatusCode.Created);

        }


        [HttpPut("{Id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Update([FromBody] UpdateStudentForm Form, int Id)

        {
            LoggingHelper.LogController(_logger, $"id: {Id}");

            _studentService.Update(Id, Form);
            return new ApiResponse(HttpStatusCode.OK);

        }


        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Delete(int Id)
        {
            LoggingHelper.LogController(_logger, $"id: {Id}");

            _studentService.Delete(Id);
            return new ApiResponse(HttpStatusCode.NoContent);

        }

    }
}
