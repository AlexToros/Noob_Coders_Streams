using System;
using System.Collections.Generic;

namespace _3._1._12_Simple_Numbers
{
	class Example2
	{
		public static void Solve()
		{
            int startValue = 2;
            int endValue = 2;

            List<int> primeNumbers = GetPrimeNumber(startValue, endValue);

            Console.WriteLine($"Сумма простых чисел = {GetSum(primeNumbers)}");

        }

        private static List<int> GetPrimeNumber(int startValue, int endValue)
        {
            List<int> primeNumbers = new List<int>();

			if (TryValidateParams(ref startValue, endValue, primeNumbers, out var ints))
			{
				return ints;
			}

			bool isPrime = true;
            for (int currentNumber = startValue; currentNumber <= endValue; currentNumber++)
            {
                for (int divider = 2; divider <= currentNumber; divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        if (currentNumber == divider)
                        {
                            continue;
                        }

                        isPrime = false;
                        break;
                    }

                    isPrime = true;
                }

                if (isPrime)
                {
                    primeNumbers.Add(currentNumber);
                }
            }

            return primeNumbers;
        }

        private static bool TryValidateParams(ref int startValue, int endValue, List<int> primeNumbers, out List<int> ints)
        {
            if (endValue < startValue)
            {
                throw new ArgumentException("The biggest value cannot be less than the smallest value.", nameof(endValue));
            }

            if (startValue <= 2 && endValue > 2)
            {
                startValue = 2;
                primeNumbers.Add(startValue);
                startValue = 3;
            }

            if (endValue == 2)
            {
                primeNumbers.Add(endValue);
                {
                    ints = primeNumbers;
                    return true;
                }
            }

            ints = null;
            return false;
        }

        private static int GetSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

    }
}
