using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // In-place algorithm -> doesn't need extra memory (like creating a new array, etc.)
            // O(n^2) time complexity - quadratic
            // Unstable algorithm
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };


            for (int lastUndsortedIndex = intArray.Length -1; lastUndsortedIndex > 0; lastUndsortedIndex--)
            {
                int largestElementIndex = 0;
                for (int i = 1; i <= lastUndsortedIndex; i++)
                {
                    if (intArray[i] > intArray[largestElementIndex])
                    {
                        largestElementIndex = i;
                    }
                }
                swap(intArray, largestElementIndex, lastUndsortedIndex);
            }
















            //for (int lastUnsortedIndex = intArray.Length-1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            //{
            //    int largestElementIndex = 0;

            //    for (int i = 1; i <= lastUnsortedIndex; i++)
            //    {
            //        if (intArray[i] > intArray[largestElementIndex])
            //        {
            //            largestElementIndex = i;
            //        }
            //    }
            //    swap(intArray, largestElementIndex, lastUnsortedIndex);
            //}



            //for (int lastUnsortedIndex = intArray.Length -1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            //{
            //    int largestElementIndex = 0;

            //    for (int i = 1; i <= lastUnsortedIndex; i++)
            //    {
            //        if (intArray[i] > intArray[largestElementIndex])
            //        {
            //            largestElementIndex = i;
            //        }
            //    }
            //    swap(intArray, largestElementIndex, lastUnsortedIndex);
            //}





            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.Write(intArray[i] + " ");
            //}
            //Console.WriteLine();
            //foreach (var item in intArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Array.ForEach(intArray, Console.Write);
            //Console.WriteLine();
            Console.WriteLine(string.Join(" ", intArray));
            Console.ReadLine();            
        }

        public static void swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
