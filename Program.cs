using System;
using System.Collections.Generic;

namespace Collection5
{
class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = { "один", "два", "три", "пять", "восемь", "шесть" };
            string[] stringArray2 = { "пять", "семь", "одинадцать", "два", "один", "четыре" };

            Console.Write("Первый массив - ");
            ShowArray(stringArray1);
            Console.Write("Второй массив - ");
            ShowArray(stringArray2);

            List<string> unity = new List<string>();

            MergeArrays(unity, stringArray1, stringArray2);

            Console.Write("Объединенная коллекция - ");
            ShowUnity(unity);

            Console.ReadKey();
        }

        static void ShowUnity(List<string> list)
        {
            foreach (string word in list)
            {
                Console.Write(word + " ");
            }
            Console.Write("\n");
        }

        static void ShowArray(string[] array)
        {
            foreach(string word in array)
            {
                Console.Write(word + " ");
            }
            Console.Write("\n");
        }

        static void MergeArrays(List<string> list, string[] array1, string[] array2)
        {
            list.AddRange(array1);

            foreach(string word in array2)
            {
                if(list.Contains(word)!=true)
                {
                    list.Add(word);
                }
            }
        }
    }
}
