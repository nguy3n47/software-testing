using System;

namespace BT04
{
    public class BT04
    {

        int BT04_SNT(long a)
        {
            int i = 0;

            for (i = 2; i <= (int)Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        public bool SNT(long N)
        {
            long i, j;
            long a = 0, b = 0, S = 0;
            if (N >= 0 && N <= 1000000000)
            {
                if (BT04_SNT(N) == 1) S = N;
                else
                {
                    i = j = N;
                    i++;
                    if (BT04_SNT(i) == 1) a = i;
                    j--;
                    if (BT04_SNT(j) == 1) b = j;
                    if (Math.Abs(a - N) < Math.Abs(b - N)) S = a;
                    else S = b;
                }
                Console.WriteLine("So SNT gan nhat la: {0}", S);
                return true;
            }
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BT04 n = new BT04();
            int number;
            Console.Write("Input interger(>0): ");
            number = Convert.ToInt32(Console.ReadLine());
            if (n.SNT(number))
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
