using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] wordTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            int MaxChar = Math.Min(wordOne.Length, wordTwo.Length);
            for (int i = 0; i < MaxChar; i++)
            {
                if (wordOne[i] < wordTwo[i])
                {
                    Console.WriteLine(string.Join("", wordOne));
                    Console.WriteLine(string.Join("", wordTwo));
                    break;
                }
                else if (wordOne[i] > wordTwo[i])
                {
                    Console.WriteLine(string.Join("", wordTwo));
                    Console.WriteLine(string.Join("", wordOne));
                    break;
                }
                else if (wordOne.Length < wordTwo.Length)
                {
                    Console.WriteLine(string.Join("", wordOne));
                    Console.WriteLine(string.Join("", wordTwo));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", wordTwo));
                    Console.WriteLine(string.Join("", wordOne));
                    break;
                }
            }
        }
    }
}
