using System.Collections.Generic;
    using System.Linq;
namespace FirstCoreMVCWebApplication.Models
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
               new Student{ Id = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student{ Id = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student{ Id = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student{ Id = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student{ Id = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
        }

        public Student GetStudentById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id) ?? new Student();

        }
        public List<Student> GetAllStudents()
        {
            return DataSource().ToList();
        }
    }
}
