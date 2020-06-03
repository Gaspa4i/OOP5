using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{

    class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + Surname);
        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    class Employee : Person
    {
        private string company;

        public Employee(string name, string surname, string company) : base(name, surname)
        {
            this.company = company;
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public void Display2()
        {
            Console.WriteLine(Name + " " + Surname + " - " + Company);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Till", "Lindemann");
            Employee employee1 = new Employee("Gabe", "Newell", "VALVE");

            person1.Display();
            employee1.Display2();
            Console.ReadLine();
        }
    }
}
