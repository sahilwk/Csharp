using System;
using System.Threading;
namespace delegateandevent{

    public class VideoEncoder{

        public delegate void VideoEncodedEventHandler(object source,EventArgs args);//defining a delegate
        public event VideoEncodedEventHandler VideoEncoded; //defining a event(VieoEncoded is the name of the event)
        public void Encode(video video){
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded(){
            if(VideoEncoded!=null){
                VideoEncoded(this,EventArgs.Empty);
            }
        }
    }
}