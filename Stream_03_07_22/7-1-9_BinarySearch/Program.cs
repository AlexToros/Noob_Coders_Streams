using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_1_9_BinarySearch
{
	class Program
	{
		/* 1, 4, 6, 7 <-  6 -> 2
		 *			  <-  5 -> -3
 		 */

		// 1 3 5 3 0 2 7 5 0 2 4 5
		static void Main(string[] args)
		{
			var input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			var result = new List<int>();
			var reverseComparer = Comparer<int>.Create((x, y) => y - x);

			var betweenZeros = false;
			foreach (var number in input)
			{
				if (number == 0)
				{
					if (betweenZeros)
						break;
					else
					{
						betweenZeros = true;
						continue;
					}
				}

				if (betweenZeros)
				{
					var binarySearchResult = result.BinarySearch(number, reverseComparer);
					var resultIndex = binarySearchResult < 0
						? ~binarySearchResult
						: binarySearchResult;

					result.Insert(resultIndex, number);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}

