// thanks for understanding

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            Channel c1 = new Channel("ictv", 12);
            Channel c2 = new Channel("novii", 22);
            Channel c3 = new Channel("russia 1", 150);
            Channel c4 = new Channel("animal planet", 66);

            TV home = new TV("triolan", c1, c2, c3, c4);
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.NextChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.NextChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.NextChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.NextChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.NextChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number + "\n Previous: ");

            home.PreviousChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.PreviousChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.PreviousChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.PreviousChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number);
            home.PreviousChannel();
            Console.WriteLine(" " + home.CurrentChannel.Name + ",number: " + home.CurrentChannel.Number + "\n Offering: ");

            int number = Convert.ToInt32(Console.ReadLine());
           home.GoToChannel(number);
            Console.WriteLine(home.CurrentChannel.Name);

        }
    }
}
