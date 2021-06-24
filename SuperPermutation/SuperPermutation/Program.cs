using System;
using System.Collections.Generic;

namespace SuperPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            List<PermutationItem> itemset = PermutationItem.CreateSet(n);
            foreach (PermutationItem item in itemset)
            {
                foreach (PermutationItem item2 in itemset)
                {
                    if (item != item2)
                    {
                        item.Link(item2);
                    }
                }
            }
            for(int i = 0; i < itemset.Count; i++)
            {
                Console.WriteLine(itemset[i].ToString());
            }
        }
    }
}
