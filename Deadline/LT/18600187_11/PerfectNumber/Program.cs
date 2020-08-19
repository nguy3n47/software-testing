using System;

namespace PerfectNumber
{
    public class PerfectNumber
    {
        public int number { get; set; }
        public int sum { get; set; } = 0;
        public bool check(int n)
        {
            number = n;
            for (int i = 1; i <= number / 2; i++)
            {
                 if (number % i == 0)
                    sum += i;
            }
            if (sum == number && number !=0) return true;
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PerfectNumber n = new PerfectNumber();
            Console.WriteLine("Check Perfect Number in console C#:");
            Console.WriteLine("--------------------------------------");
            int number;
            Console.Write("Input number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (n.check(number))
            {
                Console.WriteLine($"{number} is perfect number");
            }
            else
            {
                Console.WriteLine($"{number} is not perfect number");
            }
            Console.ReadKey();
        }
    }
}
