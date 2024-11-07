using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_System
{
    public class Student
    {
        public int StId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int id,string name,int age,string course)
        {
            StId = id;
            Name = name;
            Age = age;
            Course = course;
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int cId,string cName)
        {
            CourseId = cId;
            CourseName = cName;

        }
    }

    public class StudentManager
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {

            students.Add(student);
            Console.WriteLine($"Successfully Added Student {student.Name}");
        }

        public void ViewStudent()
        {
            Console.WriteLine("List of Students");
            foreach(Student st in students)
            {
                Console.WriteLine($"Id:{st.StId} Name:{st.Name} Age:{st.Age} Course:{st.Course}");
            }
        }

        public void UpdateStudent(int id,string name,int age,string course)
        {
            var student = students.FirstOrDefault(s => s.StId == id);
            if(student != null)
            {
                student.Name = name;
                student.Age = age;
                student.Course = course;
                Console.WriteLine($"Updated student details with id:{id}");
            }
            else
            {
                Console.WriteLine($"Didn't find any student in {id} id");
            }
        }

        public void DeleteStudent(int id)
        {
            var delStudents = students.FirstOrDefault(s => s.StId == id);
            if (delStudents != null)
            {
                students.Remove(delStudents);
                Console.WriteLine($"Successfully deleted student with id:{id}");
            }
            else
            {
                Console.WriteLine($"The student with {id} Not found ");
            }

        }

        public void findStudentAboveAge(int age)
        {
            var findStudents = students.Where(s => s.Age > age);

            Console.WriteLine($"The Students which above {age} age");
            foreach(Student student in findStudents)
            {
                Console.WriteLine($"Name:{student.Name} Age:{student.Age}");
            }

        }

        public void findStudentInCourse(string course)
        {
            var findCoStudent = students.Where(s => s.Course == course);

            foreach(Student student in findCoStudent)
            {
                Console.WriteLine($"Name:{student.Name} Age:{student.Course}");
            }
        }
    }


    public class CourseManager
    {
        List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"Successfully Added the Course {course.CourseName}");
        }

        public void ViewAllCourse()
        {
            Console.WriteLine("List of All Course");

            foreach (var co in courses)
            {
                Console.WriteLine($"CourseId: {co.CourseId} CourseName:{co.CourseName}");
            }
        }
    }
}
