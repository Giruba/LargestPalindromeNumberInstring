using System;
using System.Collections.Generic;
using System.Text;

namespace LargestPalindromicNumberInArray
{
    class ArrayUtility
    {
        public static long[] GetArrayFromInput() {
            long[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberOfElements = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the elements separated by space, comma " +
                    "or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ',',',';');
                array = new long[numberOfElements];
                for (int index = 0; index < numberOfElements; index++) {
                    array[index] = long.Parse(elements[index]);
                }

            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        public static long GetPalindromicNumberInArray(long[] array){
            long result = 0;
            int maxLength = int.MinValue;
            for (int index = 0; index < array.Length; index++) {
                long actualnumber = array[index];
                if (actualnumber < 0) {
                    array[index] = -array[index];
                }
                if (isPalindrome(array[index])) {
                    int length = GetLengthOfnumberAsAString(array[index]);
                    if (length > maxLength) {
                        maxLength = length;
                        result = actualnumber;
                    }
                }
            }

            return result;
        }

        private static bool isPalindrome(long number) {
            bool result = true;

            Char[] charArray = number.ToString().Trim().ToCharArray();
            for (int index = 0; index < charArray.Length/2; index++) {
                if (charArray[index] != charArray[charArray.Length - 1 - index]) {
                    return false;
                }
            }


            return result;
        }

        private static int GetLengthOfnumberAsAString(long number) {
            int length = 0;
            try
            {
                char[] charArray = number.ToString().Trim().ToCharArray();
                length = charArray.Length;
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return length;
        }
    }
}
