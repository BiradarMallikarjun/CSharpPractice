using Library.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EventsExample
{
    public class VideoEncoder
    {
        //1. declaring contract
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //2. declaring event handler
            //automated by .net framework

        //3. raise event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this,new VideoEventArgs() { Video = video});
        }

        public void Encode()
        {
            Video video = FactoryClass.GetVideo();
            video.Title = "The Matrix";

            Console.WriteLine("Video encoded");           
            OnVideoEncoded(video);
        }

        //4. call this contract method signature(subscriber)
        //5. registerthen in main method
    }
}
