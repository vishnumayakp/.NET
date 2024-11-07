using System.Collections.Generic;
namespace FirstCoreMVCWebApplication.Models
{

    public interface IStudentRepository
    {
        Student GetStudentById(int id);
        List<Student> GetAllStudents();
    }
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Branch { get; set; }
        public string? Section { get; set; }
        public string? Gender { get; set; }
    }
}
