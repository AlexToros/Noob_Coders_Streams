using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._9_Vasya_House
{
	class Example1
	{
		public static void Solve()
		{
            Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            double length = Convert.ToDouble(splitString[0]); // длина
            double width = Convert.ToDouble(splitString[1]); // ширина
            double landArea = 0;                             // переменная для площади

            double rightLength = GetRightValue(length);

            //Тут будет Ваш код
            if (length > 5 && width > 5 && length % 5 == 0 && width % 5 == 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2)) * (width - (Math.Floor(width / 5) * 0.2))), 2);
            }
            if (length > 5 && width > 5 && length % 5 != 0 && width % 5 != 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2) - 0.2) * (width - (Math.Floor(width / 5) * 0.2) - 0.2)), 2);
            }
            if (length > 5 && width <= 5 && length % 5 == 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2)) * (width - 0.2)), 2);
            }
            if (length <= 5 && width > 5 && width % 5 == 0)
            {
                landArea = Math.Round((length - 0.2) * (width - (Math.Floor(width / 5) * 0.2)), 2);
            }
            if (length <= 5 && width > 5 && width % 5 != 0)
            {
                landArea = Math.Round((length - 0.2) * (width - (Math.Floor(width / 5) * 0.2) - 0.2), 2);
            }
            if (length > 5 && width <= 5 && length % 5 != 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2) - 0.2) * (width - 0.2)), 2);
            }
            if (length <= 5 && width <= 5)
            {
                landArea = Math.Round((length - 0.2) * (width - 0.2), 2);
            }
            if (length > 5 && width > 5 && length % 5 != 0 && width % 5 == 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2) - 0.2) * (width - (Math.Floor(width / 5) * 0.2))), 2);
            }
            if (length > 5 && width > 5 && length % 5 == 0 && width % 5 != 0)
            {
                landArea = Math.Round(((length - (Math.Floor(length / 5) * 0.2)) * (width - (Math.Floor(width / 5) * 0.2) - 0.2)), 2);
            }


            Console.WriteLine($"Площадь участка: {landArea}");
        }

		private static double GetRightValue(double value)
		{
            var count = Math.Ceiling(value / 5);
            return count * 4.8;
		}
	}
}
