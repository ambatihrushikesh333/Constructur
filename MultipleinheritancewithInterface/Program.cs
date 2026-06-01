using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleinheritancewithInterface
{
    interface IphoneBasic
    {
        void Calling();
        void Recieving();
        void SendMesg();
        void EndCall();
    }
    class iphoneSE : IphoneBasic
    {
        public void Calling()
        {
            Console.WriteLine("IPhoneSE is Calling");
        }

        public void Recieving()
        {
            Console.WriteLine("IPhoneSE is Recieving the call");
        }
        public void SendMesg()
        {
            Console.WriteLine("IPhoneSE is Sending a message");
        }
        public void EndCall()
        {
            Console.WriteLine("IPhoneSE is Ending the call");
        }
    }
    interface IPhoneAvanced
    {
        void FaceID();
        void VideoCall();
        void AirDrop();
    }
    class iphone16 : IphoneBasic, IPhoneAvanced
    {
        public void AirDrop()
        {
            Console.WriteLine("IPhone16 is AirDropping");
        }
        public void Calling()
        {
            Console.WriteLine("IPhone16 is Calling");
        }
        public void EndCall()
        {
            Console.WriteLine("IPhone16 is Ending the call");
        }
        public void FaceID()
        {
            Console.WriteLine("IPhone16 is using FaceID");
        }
        public void Recieving()
        {
            Console.WriteLine("IPhone16 is Recieving the call");
        }
        public void SendMesg()
        {
            Console.WriteLine("IPhone16 is Sending a message");
        }
        public void VideoCall()
        {
            Console.WriteLine("IPhone16 is making a Video Call");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IphoneBasic obj = new iphoneSE();
            obj.Calling();
            obj.Recieving();
            obj.SendMesg();
            obj.EndCall();
            obj = new iphone16();
            obj.Calling();
            obj.Recieving();
            obj.SendMesg();
            obj.EndCall();
             IPhoneAvanced obj1 = new iphone16();
            obj1.FaceID();
            obj1.VideoCall();
            obj1.AirDrop();
        }
    }
}
