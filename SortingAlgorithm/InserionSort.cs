using System;

namespace Algorithms
{

    public static class Insertion
    {
        public static void Sort(int[] a)
        {

            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i-1;
                
                while(j >= 0 && a[j] > key ){
                    a[j+1] = a[j];
                    j = j-1;
                }
                a[j+1] = key;

                
            }


        }
    }
}