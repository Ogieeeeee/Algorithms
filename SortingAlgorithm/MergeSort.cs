using System;

namespace Algorithms
{
    public static class Merge
    {

        public static void Sort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                Sort(a, p, q);
                Sort(a, q + 1, r);
                MERGE(a, p, q, r);
            }


        }

        public static void MERGE(int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
        
            int[] L = new int[n1+1];
            int[] R = new int[n2+1];
            int i,j,k;                      
        

            for (i = 0; i < n1; i++)
            {
                L[i] = a[p + i ];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = a[q + j + 1];
            }

            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;

            i = 0;
            j = 0;
            

            for (k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i = i + 1;
                }
                else
                {
                    a[k] = R[j];
                    j = j + 1;
                }
            }

        }
    }

}