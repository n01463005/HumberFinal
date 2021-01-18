using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MoshEven
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    class VideoEncoder
    {
        // 1 /define a delegate
        // 2- Degine an event based on that delegate.
        // 3- Raise the event.
       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // syntactic suger avoid Delegate and use "EventHandler<>"
        //  public event  VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....") ;
            Thread.Sleep(2000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video  }); 
        }
    }
}
