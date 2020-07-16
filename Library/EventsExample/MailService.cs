using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EventsExample
{
    public class MailService
    {
        public void OnvideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Mail sent for Video: {e.Video.Title}");
        }
    }
}
