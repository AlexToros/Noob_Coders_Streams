using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._7_Min_number
{
	class Example1
	{
		public static void Solve()
		{
            try
            {
                string line = Console.ReadLine();
                string[] splitString = line.Split(' ');

                int a = Convert.ToInt32(splitString[0]);
                int b = Convert.ToInt32(splitString[1]);
                int c = Convert.ToInt32(splitString[2]);

                int minValue = 0;

                if (a <= b && a <= c)
                {
                    minValue = a;
                    Console.WriteLine(minValue);
                }
                else if (b <= a && b <= c)
                {
                    minValue = b;
                    Console.WriteLine(minValue);
                }
                else 
                {
                    minValue = c;
                    Console.WriteLine(minValue);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Не рпвильно введено число!");
            }
        }
    }
}
