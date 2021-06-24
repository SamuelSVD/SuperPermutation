using System;
using System.Collections.Generic;

namespace SuperPermutation
{
    class PermutationItem
    {
        Random r;
        public int ID;
        public List<int> Items;
        public int size { get { return Items.Count; } }
        private List<List<PermutationItem>> WeighedList;
        PermutationItem(int n)
        {
            Items = new List<int>();
            WeighedList = new List<List<PermutationItem>>();
            for(int i = 0; i < n; i++)
            {
                List<PermutationItem> sublist = new List<PermutationItem>();
                WeighedList.Add(sublist);
            }
        }
        public void Link(PermutationItem item2)
        {
            int weight = Weight(item2);
            
            WeighedList[weight].Add(item2);
        }
        public int Weight(PermutationItem item2)
        {
            int weight = 0;
            for (int i = 0; i < size; i++)
            {
                int a = Items[i];
                int b = item2.Items[0];
                if (a == b)
                {
                    for (int j = 0; j < size - i; j++)
                    {
                        a = Items[i + j];
                        b = item2.Items[j];
                        if (a == b)
                        {
                            weight++;
                        }
                        else
                        {
                            weight = 0;
                        }
                    }
                    break;
                }
            }
            return weight;
        }
        public PermutationItem GetMaxItem(List<PermutationItem> UsedItems)
        {
            for(int i = WeighedList.Count - 1; i >= 0; i--)
            {
                foreach(PermutationItem pi in WeighedList[i])
                {
                    if (UsedItems.IndexOf(pi) == -1)
                    {
                        return pi;
                    }
                }
            }
            return null;
        }
        public PermutationItem GetRandomItem(List<PermutationItem> UsedItems)
        {
            List<int> ints = new List<int>();
            for(int i = 0; i < WeighedList.Count - 1; i++)
            {
                ints.Add(i);
            }
            if (r == null)
            {
                r = new Random();
            }
            while(ints.Count > 0)
            {
                int ran = r.Next(2);
                if (ints.Count < 2)
                {
                    ran = 1;
                }
                int i = ints[ints.Count-(2-ran)];
                ints.Remove(i);
                foreach (PermutationItem pi in WeighedList[i])
                {
                    if (UsedItems.IndexOf(pi) == -1)
                    {
                        return pi;
                    }
                }
            }
            return null;
        }
        override public string ToString()
        {
            string ret = "{" + ID + ",{";
            for(int i = 0; i < Items.Count; i++)
            {
                ret += Items[i].ToString();
                if (i < Items.Count - 1) ret += ",";
            }
            ret += "},{";
            for(int i = 0; i < WeighedList.Count; i++)
            {
                ret += "{" + i.ToString() + ",{";
                for( int j = 0; j < WeighedList[i].Count; j++)
                {
                    ret += WeighedList[i][j].ID.ToString();
                    if (j < WeighedList[i].Count-1)
                    {
                        ret += ",";
                    }
                }
                ret += "}}";
                if (i < WeighedList.Count -1)
                {
                    ret += ",";
                }
            }
            ret += "}}";
            return ret;
        }
        public static List<PermutationItem> CreateSet(int size)
        {
            List<PermutationItem> result_set = new List<PermutationItem>();
            List<int> itemset = new List<int>();
            for (int i = 0; i < size; i++)
            {
                itemset.Add(i);
            }
            int f = factorial(size);
            for (int i = 0; i < f; i++)
            {
                List<int> copy = itemset.ConvertAll(new Converter<int, int>(delegate(int j) { return j; }) );
                PermutationItem item = new PermutationItem(size);
                item.ID = i;
                int index = i;
                int setcount = f;
                for (int j = 0; j < size; j++)
                {
                    int k = index / (setcount / (size-j));
                    item.Items.Add(copy[k]);
                    copy.RemoveAt(k);
                    index = index % (setcount / (size - j));
                    setcount = setcount / (size - j);
                }
                result_set.Add(item);
            }
            return result_set;
        }
        private static int factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            else { return i * factorial(i - 1); }
        }
    }
}
