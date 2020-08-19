using System;

namespace BT03
{
    public class BT03
    {
     
        public bool BT03CN2muk(int n)
        {
            int k;
            int p = 1;

            for (k = 1; p < n; k++)
            {
                p *= 2;
            }

            if (p == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BT03 n = new BT03();
            int number;
            Console.Write("Input interger: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (n.BT03CN2muk(number))
            {
                Console.WriteLine($"{number} is 2^k ");
            }
            else
            {
                Console.WriteLine($"{number} is not 2^k ");
            }
            Console.ReadKey();
        }
    }
}
