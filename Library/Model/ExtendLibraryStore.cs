using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Library.Model
{
    public static class ExtendLibraryStore
    {
        public static void TernaryConditionsNew(this LibraryStore store)
        {
            store.TernaryConditions();
            Console.WriteLine("Extended Method for LibrayStore");
        }
    }
}
