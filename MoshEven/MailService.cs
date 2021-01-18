using System;

namespace MoshEven
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail service: Sending an email.....   " + e.Video.Title);
        }
    }
}
