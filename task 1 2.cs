using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK--1

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //TASK--2

            var number = 95;

            if (number < 65)
            {
                Console.WriteLine("Kesildin");
            }
            else if (number >= 65 && number < 85)
            {
                Console.WriteLine("Adi Diplom");
            }
            else if (number >= 85 && number < 95)
            {
                Console.WriteLine("Seref diplomu");
            }
            else
            {
                Console.WriteLine("Yuksek seref diplomu");
            }
        }
    }
}
