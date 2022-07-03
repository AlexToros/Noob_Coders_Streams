using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._12_Simple_Numbers
{
	class Example1
	{
		public static void Solve()
		{
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            int sum = 0;
            HashSet<int> firstPrimes = new HashSet<int>{
    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53,
    59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
    127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181,
    191, 193, 197, 199
            };

            for (int i = startValue; i <= endValue; i++)
            {
                if (firstPrimes.Contains(i))
                    sum += i;
            }
            Console.WriteLine($"Сумма простых чисел = {sum}");
        }
    }
}
