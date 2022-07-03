using System;
using System.Collections.Generic;

namespace StrangeSequence
{
	class Program
	{
		/*
1 единица
11 одна единица
21 две единицы
1211 одна двойка одна единица
111221
312211
13112221

Пример последовательности

Входные данные
В единственной строке входного файла записаны два целых числа через пробел: x (0 <= x <= 100) - 
		первый член последовательности и n (1 <= n <= 25).

Выходные данные
Выведите n-ый ряд x-ой последовательности.
		 */

		static void Main(string[] args)
		{
			var input = new List<int> { 1 };
			var n = 4;

			for (int i = 0; i < n - 1; i++)
				input = BuildNextElement(input);
			Console.WriteLine(string.Concat(input));
		}

		static List<int> BuildNextElement(List<int> element)
		{
			var result = new List<int>();
			int count = 1;
			int currentNumber = element[0];

			for (int i = 1; i < element.Count; i++)
			{
				if (currentNumber == element[i])
					count++;
				else
				{
					result.Add(count);
					result.Add(currentNumber);

					count = 1;
					currentNumber = element[i];
				}
			}

			result.Add(count);
			result.Add(currentNumber);
			return result;
		}
	}
}
