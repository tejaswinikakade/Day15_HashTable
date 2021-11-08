using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Table_Day15
{
    class UC3_Remove
    {
        public void removeWord(string word)
        {
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr = para.Split(" ");
            int size = arr.Length;
            MyMapNode<string, string> hash = new MyMapNode<string, string>(size - 1);
            for (int i = 0; i < size; i++)
            {
                hash.Add(arr[i], i.ToString());
            }
            for (int i = 0; i < size; i++)
            {
                hash.Add(arr[i], i.ToString());
            }


          hash.Remove(hash.Get(word));
        }
    }
}