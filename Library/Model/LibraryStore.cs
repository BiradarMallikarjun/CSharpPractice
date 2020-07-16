using Library.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Model
{
    public class LibraryStore
    {
        public int Id { get; set; }

        public string LibName { get; set; }

        public string  Address { get; set; }

        public LibraryStore()
        {
            //System.Console.WriteLine("LibraryStore" + ".ctor");
        }

        public List<LibraryStore> GetLibraryStores()
        {
            return new List<LibraryStore>() { 
                new LibraryStore() { Id=1, LibName="Vivekanad Library", Address="Bidear"},
                new LibraryStore() { Id=2, LibName="Subhash Library", Address="Bhalki"},
                new LibraryStore() { Id=3, LibName=null, Address="Bidar"}
            };
        }

        public void TernaryConditions()
        {
            LibraryStore libraryStore = FactoryClass.GetLibraryStore();

            var libs = libraryStore.GetLibraryStores().OrderByDescending(e => e.Id).First();

            LibraryStore newLib = libs;
            Console.WriteLine("newLib: " + (!string.IsNullOrEmpty(newLib.LibName) ? newLib.LibName : "") + newLib?.Address);
        }
    }
}
