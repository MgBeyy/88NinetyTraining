using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using University.Core.Forms;
using University.Core.Services.Interfaces;

namespace University.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("{id}")]
        public ApiResponse GetById(int id)
        {
            var dto = _studentService.GetById(id);
            return new ApiResponse(dto);
        }

        [HttpGet()]
        public ApiResponse GetAll()
        {
            var dtos = _studentService.GetAll();
            return new ApiResponse(dtos);
        }


        [HttpPost()]
        public ApiResponse Create([FromBody]CreateStudentForm Form)
        {
            _studentService.Create(Form);
            return new ApiResponse(HttpStatusCode.Created);

        }

        [HttpPut("{Id}")]
        public ApiResponse Update([FromBody]UpdateStudentForm Form, int Id)
        {
            _studentService.Update(Id, Form);
            return new ApiResponse(HttpStatusCode.OK);

        }


        [HttpDelete("{Id}")]
        public ApiResponse Delete(int Id)
        {
            _studentService.Delete(Id);
            return new ApiResponse(HttpStatusCode.NoContent);

        }

    }
}
