using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5 };
            int[] unsortedArray = new int[] {14,7,3,12,9,11,6,2};
            //SequentialSearch
            Console.WriteLine("Sequential Search");
            Console.WriteLine(Sequential.Search(sortedArray, 5));

            //BinarySearch (Only works on sorted arrays)
            Console.WriteLine();Console.WriteLine("Binary Search");
            Console.WriteLine(Binary.Search(sortedArray, 5));

            //InsertionSort
            Console.WriteLine(); Console.WriteLine("Insertion Sort");
            Insertion.Sort(unsortedArray);

            foreach (var item in unsortedArray)
            {
                System.Console.WriteLine(item);
            }

            //BubbleSort
            unsortedArray = new int[] {14,7,3,12,9,11,6,2};
            Console.WriteLine();Console.WriteLine("BubbleSort");
            Bubble.Sort(unsortedArray);
            foreach (var item in unsortedArray)
            {
                System.Console.WriteLine(item);
            }

            //MergeSort
            unsortedArray = new int[] {14,7,3,12,9,11,6,2};
            Console.WriteLine();Console.WriteLine("MergeSort");
            Merge.Sort(unsortedArray,0,unsortedArray.Length-1);
            foreach (var item in unsortedArray)
            {
             System.Console.WriteLine(item);   
            }

            //LinkedList-Search 
            LinkedList<int> sortedLlist = new LinkedList<int>(sortedArray);
            System.Console.WriteLine(); System.Console.WriteLine("LinkedList Search");
            Console.WriteLine(Llist.Search(sortedLlist, 5));




        }
    }
}
