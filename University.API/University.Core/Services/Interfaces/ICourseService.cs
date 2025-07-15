using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Core.DTOs;
using University.Core.Forms;

namespace University.Core.Services.Interfaces
{
    public interface ICourseService
    {
        List<CourseDto> GetAll();
        CourseDto GetById(int Id);
        void Create(CreateCourseForm Form);
        void Update(int Id, UpdateCourseForm Form);
        void Delete(int Id);
    }
}
