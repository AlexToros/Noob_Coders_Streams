using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._1._1_VasyaCalculator
{
	class Program
	{
		static void Main(string[] args)
        {
            var result = CombinationsOf(3, new int[] { 1, 2, 3 }).ToList();


            int number = int.Parse(Console.ReadLine());
            VasyaStyle(number);
        }

        private static void VasyaStyle(int number)
        {
            // N = a * b + c; 
            var src = new[] { 2, 3, 7 };
            var srcMin = src.Min();
            var allNumbersForCheck = AllCombinationSequence(src)
                .TakeWhile(x => x * srcMin < number)
                .ToArray();

            for (int i = 0; i < allNumbersForCheck.Length; i++)
            {
                var firstMultiply = allNumbersForCheck[i];
                for (int j = i; j < allNumbersForCheck.Length; j++)
                {
                    var secondMultiply = allNumbersForCheck[j];

                    var reminder = number - (firstMultiply * secondMultiply);

                    if (ReminderValid(reminder, src))
                        Console.WriteLine($"{number} = {firstMultiply} * {secondMultiply} + {reminder}");
                }
            }
        }

        static IEnumerable<int> AllCombinationSequence(params int[] src)
        {
            for (int i = 1; true; i++)
            {
                foreach (var item in CombinationsOf(i, src))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<int> CombinationsOf(int neededLength, int[] src, int previewResult = 0)
        {
            foreach (var number in src)
            {
                var newNumber = previewResult * 10 + number;
                if (neededLength == 1)
                    yield return newNumber;
                else
                {
                    foreach (var combination in CombinationsOf(neededLength - 1, src, newNumber))
                        yield return combination;
                }
            }
        }

        private static bool ReminderValid(int reminder, int[] src)
        {
            return reminder.ToString().All(x => src.Contains(x - '0'));
        }
    }
}
