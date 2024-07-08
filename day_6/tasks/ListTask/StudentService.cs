using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();


        public void GetAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}, {student.DateOfBirth}".ToString());
            }
        }

        //public void AddStudent(Student student)
        //{
        //    students.Add(student);
        //}

        public void AddStudent(int id, string firstName, string lastName, DateTime dateOfBirth)
        {
            if (students.Any(s => s.Id == id))
            {
                throw new InvalidOperationException();
            }
            students.Add(new Student { DateOfBirth = dateOfBirth, FirstName = firstName, LastName = lastName, Id = id });
        }
        public void AddStudents(Student[] student)
        {
            students.AddRange(student);
        }
        public void RemoveStudent(int id)
        {
            var studentToRemove = students.Find(s => s.Id == id);
            if (studentToRemove == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                students.Remove(studentToRemove);
            }
        }
        public void RemoveStudents(Student[] student)
        {
            foreach (var remove in student)
            {
                RemoveStudent(remove.Id);
            }
        }
    }
}
