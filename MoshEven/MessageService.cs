using System;

namespace MoshEven
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service:" + e.Video.Title);
        }
    }
}
