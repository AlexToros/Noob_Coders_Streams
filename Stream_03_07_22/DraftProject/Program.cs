using System;

namespace DraftProject
{

	class MyClass
	{
		public int MyProperty { get; set; }

		public MyClass(int myProperty)
		{
			MyProperty = myProperty;
		}
	}

	class Program
	{
		private void Method(int i)
		{
			
		}

		static void Main(string[] args)
		{
			TTT();
		}

		private static void TTT(MyClass d)
		{
			d.ToString();

			int i = 4;



			string p = i.ToString();

			Console.WriteLine(p);
		}
	}
}
