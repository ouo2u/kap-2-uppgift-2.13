using System;

namespace kap_2_uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vad är lönen för den första anställd? ");
            string anställd1 = (Console.ReadLine());
            int lön1 = int.Parse(anställd1);
            Console.WriteLine("Vad är lönen för den andra anställd? ");
            string anställd2 = (Console.ReadLine());
            int lön2 = int.Parse(anställd2);
            Console.WriteLine("Vad är lönen för den trdje anställd? ");
            string anställd3 = (Console.ReadLine());
            int lön3 = int.Parse(anställd3);
            Console.WriteLine("summan av de tre anställda är " + (lön1 + lön2 + lön3) + "kr");

        }
    }
}
