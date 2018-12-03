using System;

namespace Algorithms
{

    public static class Sequential
    {
        public static int Search(int[] a, int v)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == (v)){
                    return v;
                }
            }

            return -1;
        }
    }
}
