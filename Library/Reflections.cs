using Library.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Library
{
    public class Reflections : IReflections
    {
        public void ClassInfoMethod()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                Console.WriteLine($" Class Details: ");
                Print(typeInfo);
            }
        }

        public void ClassInfoMethod2()
        {           
            Console.WriteLine($" Class Details: {GetType().GetTypeInfo().FullName}");           
        }


        private void Print(TypeInfo types)
        {
            Console.WriteLine($"Full Name : {types.FullName}");
            Console.WriteLine($" Name : {types.Name}");
        }

        private void Print(ConstructorInfo[] ctors)
        {
            foreach (var ctor in ctors)
            {
                Console.WriteLine($" Constroctor : {ctor.ToString()}");
                foreach (var item in ctor.GetParameters())
                {

                    Console.WriteLine($" ParameterInfo : {item.Name}");
                }
                Console.WriteLine();
            }
        }

        internal static void ReflectionMethod()
        {
            Reflections reflections = FactoryClass.GetReflections();
            reflections.ClassInfoMethod2();
        }

        private void Print(PropertyInfo[] properties)
        {
            foreach (var property in properties)
            {
                Console.WriteLine($" Name : {property.Name}");
                Console.WriteLine($" Property Type : {property.PropertyType}");
                Console.WriteLine();
            }
        }
    }
}
