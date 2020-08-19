using System;

namespace BT05
{
	public class BT05
	{
		


		public bool BT05_KTtangdan(long n)
		{
			if (n >= -1000000000 && n <= 1000000000)
			{
				long s1 = n % 10, ss, kt1 = 0, kt2 = 0;
				n = n / 10;
				while (n != 0)
				{
					ss = n % 10;
					if (s1 < ss) kt1 = 1;
					if (s1 > ss) kt2 = 1;
					s1 = ss;
					n = n / 10;
				}
				if (kt1 == 0 && kt2 == 1) Console.WriteLine("La so tang dan tu phai qua trai ");
				if (kt2 == 0 && kt1 == 1) Console.WriteLine("La so giam dan tu phai qua trai");
				if (kt1 == 1 && kt2 == 1 || kt1 == 0 && kt2 == 0) Console.WriteLine("La so khong tang va khong giam");
				return true;
			}
			return false;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			BT05 n = new BT05();

			int number;
			Console.Write("Input interger: ");
			number = Convert.ToInt32(Console.ReadLine());
			if (n.BT05_KTtangdan(number))
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
