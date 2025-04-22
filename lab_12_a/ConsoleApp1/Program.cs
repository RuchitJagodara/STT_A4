using System;
using System.Threading;

namespace AlarmClockConsoleApp
{
    class Subscriber_class
    {
        public static void Ring()
        {
            Console.WriteLine("ALARM!!!!!!!!!!!!!");
            Thread.Sleep(1000);
        }
    }

    class Publisher_class
    {
        public event Alarm RaiseEvent;        
        public delegate void Alarm();         

        public void SetTime(string sTime)
        {
            string currTime = DateTime.Now.ToString("HH:mm:ss");
            while (currTime != sTime)
            {
                Console.WriteLine("Tick-Tock...");
                Thread.Sleep(1000);
                currTime = DateTime.Now.ToString("HH:mm:ss");
            }

            RaiseEvent(); // raise the event
        }

        static void Main(string[] args)
        {
            Publisher_class p = new Publisher_class();
            p.RaiseEvent += new Alarm(Subscriber_class.Ring);

            Console.WriteLine("Enter Time for Alarm (HH:mm:ss) =>");
            string t = Console.ReadLine();

            if (TimeSpan.TryParseExact(t, "hh\\:mm\\:ss", null, out _))
            {
                p.SetTime(t);
            }
            else
            {
                Console.WriteLine("❌ Invalid format! Please enter time in HH:mm:ss format.");
            }
        }
    }
}