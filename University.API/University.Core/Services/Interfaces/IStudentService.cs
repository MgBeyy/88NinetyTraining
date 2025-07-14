using University.Core.DTOs;
using University.Core.Forms;

namespace University.Core.Services.Interfaces
{
    public interface IStudentService
    {
        List<StudentDto> GetAll();
        StudentDto GetById(int Id);
        void Create(CreateStudentForm Form);
        void Update(int Id, UpdateStudentForm Form);
        void Delete(int Id);
    }
}

