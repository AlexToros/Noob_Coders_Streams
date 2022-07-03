using System;

namespace VasyaClock
{
    class Program
    {
        static void Main(string[] args)
		{
			while (true)
			{
				FixedExample();
			}

		}

		private static void RawExample()
		{
			int n = int.Parse(Console.ReadLine());
			int hour = 2;
			int minute = 24;
			int b = 0;
			int d = n * 160;

			for (int i = 0; i < d; i++)
			{
				minute = minute + 1;

				if (minute == 12 || minute == 24 || minute == 32 || minute == 48 || minute == 60)
				{
					hour = hour + 1;
				}
				if (minute >= 60)
				{
					minute = 60 % 60;
				}
				if (hour >= 60)
				{
					hour = 60 % 60;
				}
				if (minute - hour == 5)
				{
					// Console.WriteLine($"{hour / 5}:{minute}");

					b++;
					if (b == n)
					{
						if (b == 5)
						{
							Console.WriteLine($"{hour / 5}:{minute - 1}");
							break;

						}
						Console.WriteLine($"{hour / 5}:{minute}");
					}

				}
			}
		}

		private static void FixedExample()
		{
			//Переделали на грабусы, а не на деления
			//Проблема была все аки в том, что изменения положения часовой стрелки видимо были не плавными
			//Все градусы умножены на 100, чтобы избежать работы с дробными числами
			int n = int.Parse(Console.ReadLine());
			int hour = 150;
			int minute = 1800;
			var hourStep = 5;
			var minuteStep = 60;
			var neededDifference = 300;
			var clockPoint = 30;

			int b = 0;

			while (true)
			{
				hour = (hour + hourStep) % 3600;
				minute = (minute + minuteStep) % 3600;

				var difference = minute - hour;

				if (difference > neededDifference && difference < neededDifference + minuteStep)
				{
					b++;
					if (b == n)
						break;
				}

				clockPoint++;
			}

			Console.WriteLine($"{clockPoint / 60}:{clockPoint % 60}");
		}
	}
}
