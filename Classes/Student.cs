using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student
    {
        public Student(DateTime birthday,string FirstName, string LastName)
        {
            this.birthday=birthday;
            this.FirstName=FirstName;
            this.LastName = LastName;
        }
        public  Student(DateTime birthday, string FirstName,string LastName,string Group):this(birthday, FirstName, LastName)
        {   
           this.Group = Group;
        }

        public Student(Student student)
        {
            
        }

        public Guid Id;
        private DateTime birthday;
        private string FirstName;
        private string LastName;
        private string Group;
        

        public void Print()
        {
            Console.WriteLine("Имя студента " + FirstName);
            Console.WriteLine("Фамилия студента " + LastName);
            Console.WriteLine("Возраст студента " + birthday);
            Console.WriteLine("ID студента " + Id);
        }
    }
}
