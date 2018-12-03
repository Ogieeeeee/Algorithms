using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5 };
            int[] unsortedArray = new int[] { 5, 1, 3, 6, 6, 5 };

            //SequentialSearch
            Console.WriteLine(Sequential.Search(sortedArray, 5));

            //BinarySearch (Only works on sorted arrays)
            Console.WriteLine(Binary.Search(sortedArray, 5));

            //InsertionSort
            Insertion.Sort(unsortedArray);

            foreach (var item in unsortedArray)
            {
                System.Console.WriteLine(item);
            }


            //BubbleSort
            unsortedArray = new int[] { 5, 1, 3, 6, 6, 5 };
            Console.WriteLine();Console.WriteLine("BubbleSort");
            Bubble.Sort(unsortedArray);
            foreach (var item in unsortedArray)
            {
                System.Console.WriteLine(item);
            }





        }
    }
}
