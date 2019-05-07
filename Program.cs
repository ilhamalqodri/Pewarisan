using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "kacchan";
            person.Age = 16;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "All Might";
            teacher.Age = 35;
            teacher.TeacherId = "12345";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "deku";
            student.Age = 16;
            student.StudentId = "11111";
            student.Email = "deku123@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
