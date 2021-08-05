using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        //public readonly string _firstName = "";
        //private string _lastName = "";
        private int _age;

        public int Age { get { return _age; } set { if (value < 0) { throw new ArgumentException(); } _age = value; } }
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";

        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName)
        {
            FirstName = firstName;
        }
        public Person()
        {

        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public override string ToString()
        {
            return $"{base.ToString()} Name : {GetFullName()} Age: {Age}";
        }

        public string Move()
        {
            return $"Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}