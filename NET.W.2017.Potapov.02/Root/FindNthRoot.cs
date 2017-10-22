using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root
{
    public static class FindNthRoot
    {
		public static double FindRoot(double a, double n, double eps)
		{
			if (a < 0 && n % 2 == 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			double x = a / n;
			double nextX = (1 / n) * ((n - 1) * x + a / Math.Pow(x, (int)n - 1));
			while (Math.Abs(x - nextX) > eps)
			{
				x = nextX;
				nextX = (1 / n) * ((n - 1) * x + a / Math.Pow(x, (int)n - 1));
			}
			return Math.Round(nextX, eps.ToString().Length - 2);
		}
	}
}
