namespace StudentManagement_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            CourseManager courseManager = new CourseManager();



            Course course1 = new Course(1,"Bsc Computer Science");
            Course course2 = new Course(2, "BCA");
            Course course3 = new Course(3, "Bsc Micro Biology");
            Course course4 = new Course(4, "Bsc Bio Technology");

            courseManager.AddCourse(course1);
            courseManager.AddCourse(course2);
            courseManager.AddCourse(course3);
            courseManager.AddCourse(course4);


            studentManager.AddStudent(new Student(1, "Vishnumaya", 18, "Bsc Computer Science"));
            studentManager.AddStudent(new Student(2, "Abhay pc", 18, "BCA"));
            studentManager.AddStudent(new Student(3, "Hrithic", 20, "Bsc Computer Science"));
            studentManager.AddStudent(new Student(4, "Ashiq", 19, "Bsc Micro Biology"));
            studentManager.AddStudent(new Student(5, "Shilpa", 19, "BCA"));

            studentManager.ViewStudent();

            studentManager.findStudentInCourse("Bsc Computer Science");

            studentManager.UpdateStudent(2, "Aseem", 22, "Bsc Bio Technology");
            studentManager.ViewStudent();

            studentManager.DeleteStudent(5);
            studentManager.ViewStudent();

            studentManager.findStudentAboveAge(18);

            courseManager.ViewAllCourse();

        }
    }
}
