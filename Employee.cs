using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string surname;
        private int age;

        public Employee() { }
        public Employee(string surname, int age)
        {
            if (age <= 0)
            {
                throw new ArgumentException();
            }
            this.surname = surname ?? throw new ArgumentNullException();
            this.age = age;
        }

        private string ShowAge()
        {
            return age.ToString();
        }
        public void ChangeSurname(string newSurname)
        {
            this.surname = newSurname ?? throw new ArgumentNullException();
        }
        public override string ToString()
        {
            return "Surname: " + this.surname + ", Age: " + this.age;
        }
    }
}
