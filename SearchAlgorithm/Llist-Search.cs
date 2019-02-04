using System;
using System.Collections.Generic;

namespace Algorithms
{


    public static class Llist
    {

        public static int Search(LinkedList<int> l, int k)
        {
            var p = l.First;
            while (p != null && p.Value != k)
            {
                p = p.Next;
            }

            return p.Value;

        }

        public static void Insert(LinkedList<int> l, int k)
        {
            if(l.First == null || l.First.Value > k){ 
                l.AddFirst(k);
                return;
            }

            var p = l.First;
            while (p.Next != null && p.Next.Value <= k)
            {
                p = p.Next;
            }

            p.List.AddAfter(p,k);

            
            
        }
    }
}