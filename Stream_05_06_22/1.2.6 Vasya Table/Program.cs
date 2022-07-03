using System;

namespace _1._2._6_Vasya_Table
{
	class Program
	{
        public static void Main()
		{
			Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
			string line = Console.ReadLine();
			string[] splitString = line.Split(' ');

			int length = Convert.ToInt32(splitString[0]); // длина
			int width = Convert.ToInt32(splitString[1]); // ширина

			int length1 = GetRightValue(length);
			int width1 = GetRightValue(width);
			double S = (length1 * width1) / 10000.0;

			Console.WriteLine($"Площадь стола: {S} ");
		}

		private static int GetRightValue(int value)
		{
			int error = 20;

			return GetSantimeters(value) - error;
		}

		private static int GetSantimeters(int value)
		{
			return value * 100;
		}
	}
}
