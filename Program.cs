using System;

namespace ASP_currency_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate, vnd, usd;
            Console.WriteLine("Enter the exchange rate");
            rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of USD");
            usd = float.Parse(Console.ReadLine());
            vnd = rate*usd;
            Console.WriteLine("Amount VND respectively " + vnd);
        }
    }
}
