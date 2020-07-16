using Library.EventsExample;
using Library.Model;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Factory
{
    public static class FactoryClass
    {  
        public static BusinessLogic GetBusinessLogic()
        {
            return new BusinessLogic(new Logger());
        }

        public static Person GetPerson()
        {
            return new Person(new Logger());
        }

        public static VideoEncoder GetVideoEncoder()
        {
            return new VideoEncoder();
        }

        public static MailService GetMailService()
        {
            return new MailService();
        }

        public static MessageService GetMessageService()
        {
            return new MessageService();
        }

        public static LibraryStore GetLibraryStore()
        {
            return new LibraryStore();
        }
        public static Reflections GetReflections()
        {
            return new Reflections();
        }
        public static Delegates GetDelegates()
        {
            return new Delegates();
        }

        public static YieldExample GetYield()
        {
            return new YieldExample();
        }
    }
}
