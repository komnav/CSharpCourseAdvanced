using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask
{
    public class TeacherService
    {
        private Dictionary<Guid, Teacher> teachers = new Dictionary<Guid, Teacher>();

        public void AddTeacher(Guid id, string lastName, string firstName)
        {
            Teacher teacher = new Teacher();
            teacher.Id = id;
            teacher.LastName = lastName;
            teacher.FirstName = firstName;

            if (teachers.ContainsKey(id))
            {
                teachers[id] = teacher;
            }
            else
            {
                teachers.Add(id, teacher);
            }
        }
        public bool TryDeleteTeacher(Guid id)
        {
            if (teachers.ContainsKey(id))
            {
                teachers.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GetAllTeachers()
        {
            foreach (var teacher in teachers.Values)
            {
                Console.WriteLine(teacher.FirstName, teacher.LastName);
            }
        }
    }
}
