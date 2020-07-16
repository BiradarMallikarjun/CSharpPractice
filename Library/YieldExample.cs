using Library.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class YieldExample : IYieldExample
    {
        public IEnumerable<int> YeildExampleMethod(IEnumerable<int> list)
        {
            //List<int> ls = new List<int>();
            foreach (var item in list)
            {                            
                if (item > 2)
                {
                    yield return item; 
                    //ls.Add(item);
                }
            }
            //return ls;
        }

        private static IEnumerable<int> GetListIntegers()
        {
            return new List<int>() { 1, 2, 3, 4, 5 };
        }

        private static void PrintMethod(IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void YieldMethod()
        {
            var yeildExample = FactoryClass.GetYield();
            var list = yeildExample.YeildExampleMethod(GetListIntegers());
            PrintMethod(list);
        }
    }
}
