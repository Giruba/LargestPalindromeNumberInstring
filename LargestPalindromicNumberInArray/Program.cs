using System;

namespace LargestPalindromicNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Palindromic Number in an array!");
            Console.WriteLine("-------------------------------");

            long[] array = ArrayUtility.GetArrayFromInput();
            Console.WriteLine("Largest palidromic number in an array is "+
                ArrayUtility.GetPalindromicNumberInArray(array));
            Console.ReadLine();
        }
    }
}
