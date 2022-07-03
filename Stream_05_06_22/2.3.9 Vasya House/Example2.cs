using System;

namespace _2._3._9_Vasya_House
{
	class Example2
	{
		public static void Solve()
		{
            Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            double length = Convert.ToDouble(splitString[0]); // длина
            double width = Convert.ToDouble(splitString[1]); // ширина
            double landArea = 0;                             // переменная для площади
            int count = (int)length / 5;
            double length_new_2 = length - (count * 5) - 0.2;
            double length_new_3 = 4.8 * count + length_new_2;
            int width_new_1 = (int)width / 5;
            double width_new_2 = width - (width_new_1 * 5) - 0.2;
            double width_new_3 = 4.8 * width_new_1 + width_new_2;
            landArea = length_new_3 * width_new_3;

            //Тут будет Ваш код


            Console.WriteLine($"Площадь участка: {landArea}");
        }
    }
}
