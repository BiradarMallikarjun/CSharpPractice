using System;

namespace Library.EventsExample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Message sent for Video: {e.Video.Title}");
        }
    }
}