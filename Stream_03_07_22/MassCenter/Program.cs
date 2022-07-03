using System;

namespace MassCenter
{

	/*
	 Центр тяжести

Выведите координаты центра тяжести данного множества точек.
Входные данные
	Программа получает на вход набор точек на плоскости. 
	Сначала задано количество точек n, затем идет последовательность из n строк, 
	каждая из которых содержит два числа: координаты точки. 
	Величина n не превосходит 100, все исходные координаты – целые числа, не превосходящие 103.
Выходные данные
	Выведите  координаты центра тяжести данного множества точек. 
	Ответ - пара действительных чисел с пробелом между ними, 
	необходимо выводить с точностью до 10 значащих цифр после запятой. 
	При этом ответ не надо округлять, лишние цифры просто отбрасываются.
Входные дынные:   * . . . *
2				  . . . . .
1 2				  . . . . .
2 3				  . . * . .
Выходные данные:  * . * . *
1.5 2.5
	 */
	class Program
	{
        public static void Main()
		{
			Example2();
		}

		private static void Example1()
		{
			//желательно использовать decimal - почему именно?
			int n = int.Parse(Console.ReadLine());
			double centerOfGravityX = 0.0;  
			double centerOfGravityY = 0.0;
			double d = 10000000000;

			for (int i = 0; i < n; i++)
			{
				string coordinate = Console.ReadLine();
				int[] coordinateXY = Array.ConvertAll<string, int>(coordinate.Split(' '), int.Parse);
				double x = coordinateXY[0];
				double y = coordinateXY[1];
				centerOfGravityX += x;
				centerOfGravityY += y;
			}
			Console.WriteLine($"{Math.Truncate(centerOfGravityX / n * d) / d:0.0#########} {Math.Truncate(centerOfGravityY / n * d) / d:0.0#########}");
		}

		private static void Example2()
		{
			int mantissaLength = 10;

			int pointsCount = int.Parse(Console.ReadLine());

			(decimal X, decimal Y) centerOfGravity = (0M, 0M);

			for (int i = 0; i < pointsCount; i++)
			{
				var point = ReadPoint();

				centerOfGravity.X += point.X;
				centerOfGravity.Y += point.Y;
			}
			centerOfGravity.X /= pointsCount;
			centerOfGravity.Y /= pointsCount;

			var result = TruncatePoint(centerOfGravity, mantissaLength);

			Console.WriteLine($"{result.X} {result.Y}");
		}

		private static (decimal X, decimal Y) ReadPoint()
		{
			string coordinate = Console.ReadLine();
			int[] coordinateXY = Array.ConvertAll<string, int>(coordinate.Split(' '), int.Parse);

			(decimal X, decimal Y) point = (coordinateXY[0], coordinateXY[1]);

			return point;
		}

		private static (decimal X, decimal Y) TruncatePoint((decimal X, decimal Y) centerOfGravity, int mantissaLength)
		{
			return (TruncateValue(centerOfGravity.X, mantissaLength), TruncateValue(centerOfGravity.Y, mantissaLength));
		}

		private static decimal TruncateValue(decimal value, int mantissaLength)
		{
			var multiplier = (decimal)Math.Pow(10, mantissaLength);
			return Math.Truncate(value * multiplier) / multiplier;
		}

		private static decimal TruncateValueV2(decimal value, int mantissaLength)
		{
			var rounded = Math.Round(value, mantissaLength);
			if (value > 0 && rounded > value)
				return rounded - new decimal(1, 0, 0, false, (byte)mantissaLength);

			if (value < 0 && rounded < value)
				return rounded + new decimal(1, 0, 0, false, (byte)mantissaLength);

			return rounded;
		}
	}
}
