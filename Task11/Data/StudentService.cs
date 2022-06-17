using System;
using System.Collections.Generic;

namespace Task11.Data
{
    public class StudentService : IStudentService
    {
        private static string defualtPicture = "https://cdn.icon-icons.com/icons2/1879/PNG/512/iconfinder-8-avatar-2754583_120515.png";

        public static List<Student> Students = new List<Student>()
        {
            new Student{ StudentID = 1, Avatar=defualtPicture, FirstName="Jan", LastName="Kowalski", BirthDate=new DateTime(2021,5,24), Studies="Informatyka" },
            new Student{ StudentID = 2, Avatar=defualtPicture, FirstName="Anna", LastName="Malewska", BirthDate=new DateTime(2021,5,25), Studies="Informatyka" },
            new Student{ StudentID = 3, Avatar=defualtPicture, FirstName="Aleksander", LastName="Adamkowski", BirthDate=new DateTime(2002,6,20), Studies="Fizyka" },
            new Student{ StudentID = 4, Avatar=defualtPicture, FirstName="Giorgio", LastName="Giovanni", BirthDate=new DateTime(1940,4,26), Studies="Informatyka" },
            new Student{ StudentID = 5, Avatar=defualtPicture, FirstName="Donald", LastName="Trump", BirthDate=new DateTime(1946,6,14), Studies="Polityka" },
            new Student{ StudentID = 6, Avatar=defualtPicture, FirstName="Elvis", LastName="Presley", BirthDate=new DateTime(1935,1,8), Studies="Artysta" },

        };

        //CRUD
        public void CreateStudent(int studentID)
        {
            // To:do implementation
        }
        public Student FindStudent(int studentID)
        {
            return Students.Find(student => student.StudentID == studentID);
        }
        public void UpdateStudent(int studentID)
        {
            // To:do implementation technically allready implemented
        }
        public void DeleteStudent(int studentID)
        {
            var student = FindStudent(studentID);
            if (student != null) Students.Remove(student);
        }
    }
}
