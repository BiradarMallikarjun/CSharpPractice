using Library.Factory;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Model
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public Gender gender { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        ILogger _logger;
        public Person(ILogger logger)
        {
            _logger = logger;
        }

        public Person()
        {

        }
        public List<Person> GetAdultPerson(List<Person> people, AdultPerson adultPerson)
        {
            List<Person> result = new List<Person>();
            foreach (var person in people)
            {
                if (adultPerson(person))
                {
                    result.Add(person);
                }
            }

            return result;
        }

        public List<Person> GetKids(List<Person> people, Kids kid)
        {
            List<Person> result = new List<Person>();
            foreach (var person in people)
            {
                if (kid(person))
                {
                    result.Add(person);
                }
            }

            return result;
        }       

        public List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person() { FirstName = "Mallu", LastName = "Biradar", Age = 33, Address = "Bidar", gender = Gender.Male, Salary=80000,Id = 1 },
                new Person() { FirstName = "Mahesh", LastName = "Biradar", Age = 35, Address = "Benagluru", gender = Gender.Male, Salary=140000, Id = 2 },
                new Person() { FirstName = "Manjunath", LastName = "Biradar", Age = 31, Address = "Mysore", gender = Gender.Male, Salary=40000, Id = 3 },
                new Person() { FirstName = "Govind", LastName = "Biradar", Age = 29, Address = "Lucknow", gender = Gender.Male, Salary=80000, Id = 4 },
                new Person() { FirstName = "Akshit", LastName = "Tengli", Age = 10, Address = "Mysore", gender = Gender.Male, Id = 5 },
                new Person() { FirstName = "Sanidhya", LastName = "Tengli", Age = 6, Address = "Mysore", gender = Gender.Female, Id = 6 }
            };
        }
    }
}