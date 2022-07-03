using System;

namespace _1._2._9_Hex
{
	class Program
	{
		public static void Main()
		{

			int i = 4;
			int y = 5;
			int result = NewMethod(i, y);
			int result2 = NewMethod(i, y);

			Console.WriteLine(result);

			//Example1.Solve();
			Example2.Solve();
		}

		private static int NewMethod(int i, int y)
		{
			return i + y;
		}
	}
}
