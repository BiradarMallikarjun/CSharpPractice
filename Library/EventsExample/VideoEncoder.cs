using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EventsExample
{
    public class VideoEncoder
    {
        //1. declaring contract
        public event videoEncodedEventhandler VideoEncoded;

        //2. declaring event handler
        public delegate void videoEncodedEventhandler(object sender, EventArgs args);

        //3. raise event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }

        public void Encode()
        {
            Console.WriteLine("Video encoded");           
            OnVideoEncoded();
        }

        //4. call this contract method signature(subscriber)
        //5. registerthen in main method
    }
}
