using Library.Factory;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public delegate bool AdultPerson(Person person);
    public delegate bool Kids(Person person);
    public delegate decimal Tax(decimal amount, decimal taxPercent);
    public class Delegates : IDelegates
    {
        Person person = FactoryClass.GetPerson();
        public void GetAdultPerson()
        {
            var people = person.GetPeople();
            var adults = person.GetAdultPerson(people, e => e.Age > 18);
            Console.WriteLine();
            Console.WriteLine("Adults:");
            foreach (var adult in adults)
            {
                Console.WriteLine($"{adult.FirstName}, Age={adult.Age}");
            }

        }

        public void GetKids()
        {
            var people = person.GetPeople();
            var kids = person.GetKids(people, e => e.Age < 18);
            Console.WriteLine();
            Console.WriteLine("Kids:");
            foreach (var kid in kids)
            {
                Console.WriteLine($"{kid.FirstName}, Age={kid.Age}");
            }
        }

        public static void DelegateMethod()
        {
            var delExample = FactoryClass.GetDelegates();
            delExample.GetAdultPerson();
            delExample.GetKids();
        }
    }
}
