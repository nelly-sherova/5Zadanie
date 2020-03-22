using System;

namespace _5zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество полных минут : {n/60}");
            Console.WriteLine($"Количество полных часов : {n/3600}");
        }
    }
}
