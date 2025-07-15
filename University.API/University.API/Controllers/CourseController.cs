using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using University.API.Filters;
using University.API.Helpers;
using University.Core.DTOs;
using University.Core.Forms;
using University.Core.Services.Interfaces;

namespace University.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ApiExceptionFilter))]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseService courseService, ILogger<CourseController> logger)
        {
            _courseService = courseService;
            _logger = logger;
        }





        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(CourseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse GetById(int Id)
        {
            LoggingHelper.LogController(_logger, $"id: {Id}");

            var dto = _courseService.GetById(Id);
            return new ApiResponse(dto);
        }




        [HttpGet()]
        [ProducesResponseType(typeof(List<CourseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse GetAll()
        {
            LoggingHelper.LogController(_logger);

            var dtos = _courseService.GetAll();
            return new ApiResponse(dtos);
        }






        [HttpPost()]
        [ProducesResponseType(typeof(void), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Create([FromBody] CreateCourseForm Form)
        {
            LoggingHelper.LogController(_logger);

            _courseService.Create(Form);
            return new ApiResponse(HttpStatusCode.Created);

        }





        [HttpPut("{Id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Update([FromBody] UpdateCourseForm Form, int Id)
        {
            LoggingHelper.LogController(_logger, $"id: {Id}");

            _courseService.Update(Id, Form);
            return new ApiResponse(HttpStatusCode.OK);

        }








        [HttpDelete("{Id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Delete(int Id)
        {
            LoggingHelper.LogController(_logger, $"id: {Id}");

            _courseService.Delete(Id);
            return new ApiResponse(HttpStatusCode.NoContent);

        }

    }
}
