using System;

namespace VetClinic.Models.People
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDay;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }

        protected Person(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
        }

    }
}