using System;

namespace Library.EventsExample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Message sent...");
        }
    }
}