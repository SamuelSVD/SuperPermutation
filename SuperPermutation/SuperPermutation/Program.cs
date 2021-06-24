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
            Dictionary<string, List<PermutationItem>> uses = new Dictionary<string, List<PermutationItem>>();
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
                //Console.WriteLine(itemset[i].ToString());
            }
            ItemSequence seq = new ItemSequence();
            seq.Items.Add(itemset[0]);
            while(true)
            {
                PermutationItem pi = seq.Items[seq.Items.Count - 1].GetMaxItem(seq.Items);
                if (pi == null)
                {
                    Console.WriteLine(seq.ItemLength);
                    Console.WriteLine(seq.ToString());
                    break;
                } else
                {
                    seq.Items.Add(pi);
                }
            }
        }
    }
}
