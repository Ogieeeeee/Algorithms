using System;
using System.Collections.Generic;

namespace Algorithms
{


    public static class Llist
    {

        public static int Search(LinkedList<int> l, int k)
        {
            var p = l.First;
            while(p != null && p.Next.Value != k){
                p = p.Next;
            }

            return p.Value ;

        }
    }
}