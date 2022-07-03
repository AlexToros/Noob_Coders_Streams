
using System;
using System.Linq;
using System.Collections.Generic;

namespace _7_1_15_SortAndFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            FastExample();
        }

        static void SlowExample()
        {
            string message = Console.ReadLine();  
            List<string> cod = message
                .Distinct()
                .Select(c => c.ToString())
                .OrderBy(x => x)
                .ToList();  
                        
            List<string> result = new List<string>();        

            for (int i = 0; i < cod.Count; i++)
            {
                result.Add(cod[i]);                         //добавление в список result  первой буквы из списка cod
                for (int x = 0; x < message.Length; x++)
                {
                    if (cod[i] == message[x].ToString())       //если проверяемые символы в списке cod и в введенной строке
                    {                                       //message  равны,то значение переменной (x) добавляется 
                        result.Add(x.ToString());                      //в список result
                    }
                }
            }

            foreach (var x in result)                       //вывод списка result на экран
            {
                Console.Write(x + " ");
            }
        }

        static void FastExample()
        {
            var input = Console.ReadLine();
            Dictionary<string, List<int>> letters = new Dictionary<string, List<int>>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!letters.ContainsKey(input[i].ToString()))
                    letters.Add(input[i].ToString(), new List<int> { i });
                else
                    letters[input[i].ToString()].Add(i);
            }
            var letterKeys = letters.Keys.OrderBy(n => n);
            foreach (string letter in letterKeys)
            {
                Console.Write(letter + " " + string.Join(" ", letters[letter]) + " ");
            }
        }
    }
}
