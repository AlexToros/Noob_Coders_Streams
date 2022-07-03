using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1._2._9_Hex
{
    class Example2
	{
		public static void Solve()
		{
			string line = Console.ReadLine();

			int x = int.Parse(line);

			string answer = NumeralSystemConverter.ConvertFromDecimalToBase(x, 16);

			Console.WriteLine(answer);
		}

        public static class NumeralSystemConverter
        {
            private const string NewBaseEqualsSourceNumber = "10";

            public static string ConvertFromDecimalToBase(int decimalNumber, int radix)
            {
                string result;

                return GetHex((uint)decimalNumber, (uint)radix);

                if (decimalNumber < radix)
                {
                    if (decimalNumber > 0 && decimalNumber <= 9)
                    {
                        return decimalNumber.ToString();
                    }

                    return GetHexForLittleNumber(decimalNumber);
                }

                if (decimalNumber == radix)
                {
                    result = NewBaseEqualsSourceNumber;
                    return result;
                }

                bool isNegative = decimalNumber < 0;

                result = radix <= 9 ? GetUpTo9(GetDigits((uint)decimalNumber, (uint)radix)) : GetHex((uint)decimalNumber, (uint)radix);

                if (!isNegative)
                {
                    return result;
                }

                return "-" + result;
            }

            private static string GetHex(uint decimalNumber, uint radix)
            {
                StringBuilder stringBuilder = new StringBuilder();

                List<int> results = GetDigits(decimalNumber, radix);

                foreach (var num in results)
                {
                    string hexDigit = GetHexForLittleNumber(num);

                    stringBuilder.Append(hexDigit);
                }

                return stringBuilder.ToString();
            }

            private static string GetHexForLittleNumber(int decimalNumber)
            {
                switch (decimalNumber)
                {
                    case 10:
                        return "a";

                    case 11:
                        return "b";

                    case 12:
                        return "c";

                    case 13:
                        return "d";

                    case 14:
                        return "e";

                    case 15:
                        return "f";

                    case 16:
                        return "g";

                    default:
                        return decimalNumber.ToString("D", CultureInfo.InvariantCulture);
                }
            }

            private static List<int> GetDigits(uint decimalNumber, uint radix)
            {
                List<int> digits = new List<int>();
                uint reminder = decimalNumber;

                while (reminder >= radix)
                {
                    digits.Add((int)(reminder % radix));
                    reminder /= radix;
                }

                digits.Add((int)reminder);
                digits.Reverse();

                return digits;
            }

            private static string GetUpTo9(List<int> number)
            {
                return string.Join(string.Empty, number);
            }
        }
    }
}
