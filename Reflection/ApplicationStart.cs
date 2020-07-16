using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Library
{
    public class ApplicationStart : IApplicationStart
    {
        IBusinessLogic _businessLogic;
        ILogger _logger;
        private readonly string ClassInfo; 
        public ApplicationStart(IBusinessLogic businessLogic, ILogger logger)
        {
            _businessLogic = businessLogic;
            _logger = logger;
            ClassInfo = GetType().GetTypeInfo().FullName;
        }

        public void Run()
        {
            _logger.Log($"{ClassInfo}.Run() Started... ");

            _businessLogic.ProcessData();

            _logger.Log($"{ClassInfo}.Run() Ended... ");
        }
    }
}
