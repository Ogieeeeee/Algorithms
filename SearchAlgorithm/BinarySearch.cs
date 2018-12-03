using System;

namespace Algorithms
{

    public static class Binary
    {

        public static int Search(int[] a, int v)
        {

            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;

                if (v < a[middle])
                {
                    high = middle - 1;
                }

                else if (v > a[middle])
                {
                    low = middle + 1;
                }

                else
                {
                    return a[middle];
                }

            }

            return -1;
        }
    }

}