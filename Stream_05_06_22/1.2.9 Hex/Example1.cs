using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._9_Hex
{
	class Example1
	{
		public static void Solve()
		{
			string line = Console.ReadLine(); // ввод числа в десятеричной системе 

			int x = int.Parse(line);
			bool Znak;
			if (x >= 0) { Znak = true; }
			else { Znak = false; x = x * (-1); }

			string answer = "";

			while (x > 0)
			{
				var reminder = x % 16;
				string temp = "";
				if (reminder >= 0 && reminder <= 9) { temp = (reminder).ToString(); }
				else if (reminder == 10) { temp = "a"; }
				else if (reminder == 11) { temp = "b"; }
				else if (reminder == 12) { temp = "c"; }
				else if (reminder == 13) { temp = "d"; }
				else if (reminder == 14) { temp = "e"; }
				else if (reminder == 15) { temp = "f"; }
				answer = temp + answer;
				x = x / 16;
			}

			if (!Znak)
				answer = "-" +  answer;

			Console.WriteLine(answer);
		}
	}
}
