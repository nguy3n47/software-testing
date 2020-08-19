using System;

namespace BTCN_186000187
{
    public class BT01
    {

        public bool Sn_BT01(long n)
        {
            long sum = 0, temp = 1;
            if (n >= -1000000000 && n <= 1000000000)
            {
                for (int i = 1; i <= n; i++)
                {
                    temp = temp * i;
                    sum = sum + temp;
                }
                Console.WriteLine("S(n)= {0} ", sum);
                return true;
            }

            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BT01 a = new BT01();
            int number;
            Console.Write("Input interger: ");
            number = Convert.ToInt32(Console.ReadLine());
            bool resultBT01 = a.Sn_BT01(number);
            if (resultBT01 == true)
            {
                Console.WriteLine("with true interger");
            }
            else
            {
                Console.WriteLine("with error interger");
            }
            Console.ReadKey();
        }
    }
}
