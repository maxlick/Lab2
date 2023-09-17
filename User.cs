using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            registrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("Логiн: " + login);
            Console.WriteLine("Iм'я: " + firstName);
            Console.WriteLine("Прiзвище: " + lastName);
            Console.WriteLine("Вiк: " + age);
            Console.WriteLine("Дата заповнення анкети: " + registrationDate);
        }
    }
}