using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._7_Min_number
{
	class Example2
	{
		public static void Solve()
		{
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            int a = Convert.ToInt32(splitString[0]);
            int b = Convert.ToInt32(splitString[1]);
            int c = Convert.ToInt32(splitString[2]);

            int minValue = 0;

            // a = 3;
            // b = 4;
            // c = 1;

            if (a <= b)
            {
                if (b <= c)
                    minValue = a;
            }
            else if (b <= a)
                minValue = b;
            else
                minValue = c;


            Console.WriteLine(minValue);
        }
    }
}
