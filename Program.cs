using System;

namespace delegateandevent
{
    class Program
    {
        static void Main(string[] args)
        {
           var video=new video(){Title="video 1"};
           var videoEncoder=new VideoEncoder();  //publisher
            var mailService =new MailService();  //subscriber

            videoEncoder.VideoEncoded+=mailService.xyz;
           videoEncoder.Encode(video);

        } 
    }

    public class MailService{

        public void xyz(object source,EventArgs e){
            System.Console.WriteLine("sending an email");
        }
    }
}
