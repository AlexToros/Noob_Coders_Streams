using System;
using System.Collections.Generic;

namespace TestProfiler
{
	class Program
	{
		static void Main(string[] args)
		{
			HardWork();
			Console.ReadKey();
		}

		static void HardWork()
		{
			var tempLongLivingArray = new List<List<int>>();
			for (int i = 0; i < 100_000; i++)
			{
				if (i % 20_000 == 0)
				{
					Console.ReadKey();
					var tempArray = new List<int>(2_000);
				}
				tempLongLivingArray.Add(new List<int>(2_000));
			}
		}
	}
}
