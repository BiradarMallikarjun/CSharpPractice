using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EventsExample
{
    public class MailService
    {
        public void OnvideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mail sent...");
        }
    }
}
