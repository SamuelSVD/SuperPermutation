using System;
using System.Collections.Generic;
using System.Text;

namespace SuperPermutation
{
    class ItemSequence
    {
        public List<PermutationItem> Items;
        public int Weight
        {
            get
            {
                int w = 0;
                for(int i = 0; i < Items.Count-1; i++)
                {
                    w += Items[i].Weight(Items[i + 1]);
                }
                return w;
            }
        }
        public int ItemLength
        {
            get { return Items[0].size * Items.Count - (Weight); }
        }
        public ItemSequence()
        {
            Items = new List<PermutationItem>();
        }
        override public string ToString()
        {
            List<int> output = new List<int>();
            foreach(int i in Items[0].Items)
            {
                output.Add(i);
            }
            for(int i = 1; i < Items.Count; i++)
            {
                int w = Items[i - 1].Weight(Items[i]);
                for(int j = w; j < Items[i].Items.Count; j++)
                {
                    output.Add(Items[i].Items[j]);
                }
            }
            string ret = "";
            foreach (int i in output)
            {
                ret += i.ToString() + ",";
            }
            return ret;
        }
    }
}
