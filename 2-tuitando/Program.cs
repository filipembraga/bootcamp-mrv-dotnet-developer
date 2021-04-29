using System;

namespace _2_tuitando
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            if(arr.Length <= 140)
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
        }
    }
}
