using Library.EventsExample;
using Library.EventsExample.RadioBroadcast;
using Library.Factory;
using Library.Model;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Library
{

    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        public delegate int AddMethods(params int[] numbers);
        public BusinessLogic(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessData()
        {
            _logger.Log("BusinessLogic.ProcessData() started...");


            //TODO:
            //Delegates.EventExample();
            //Delegates.EventRadioExample();
            //YieldExample.YieldMethod();

            //Delegates.DelegateMethod();

            //Reflections.ReflectionMethod();

            //var ls = FactoryClass.GetLibraryStore();
            //ls.TernaryConditions();
            ////Extension Method
            //ls.TernaryConditionsNew();

            _logger.Log("BusinessLogic.ProcessData() ended...");
        }      
    }
}