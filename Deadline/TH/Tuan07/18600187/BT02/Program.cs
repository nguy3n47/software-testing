using System;

namespace BT02
{
    public class BT02
    {
    
        public bool UCLN(long a, long b)
        {
            if (a >=0 && a <= 1000000000 && b >= 0 && b <= 1000000000)
            {
                if (a == 0 || b == 0)
                {
                    Console.WriteLine("UCLN= {0}", a + b);
                }
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                Console.WriteLine("UCLN= {0}", a);
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BT02 bt02 = new BT02();
            int number1, number2;
            Console.Write("Input interger 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input interger 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            bool result = bt02.UCLN(number1, number2);
            if (bt02.UCLN(number1, number2))
            {
                Console.WriteLine("2 so a, b hop le");
            }
            else
            {
                Console.WriteLine("2 so a, b khong hop le");
            }
            Console.ReadKey();
        }
    }
}
