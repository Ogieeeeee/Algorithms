using System;

namespace Algorithms
{
    public static class Bubble
    {
        public static void Sort(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = a.Length - 1; j >= i + 1; j--)
                {
                    if (a[j] < a[j-1]){
                        int temp = a[j];
                        a[j] = a[j-1];
                        a[j-1] = temp;
                    }
                }
            }
        }
    }
}