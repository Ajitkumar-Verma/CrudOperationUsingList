using CrudOperation.Model.Model;
using System.Collections.Generic;

namespace CrudOperation.Services.Repository
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        bool SaveStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudentById(int id);
    }
}
