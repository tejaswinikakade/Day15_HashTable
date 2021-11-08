using System;

namespace Hash_Table_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1

            UC1_LineFrequency hash1 = new UC1_LineFrequency();
            hash1.Freq();

            //UC2

            UC2_LargePara hash2 = new UC2_LargePara();
            hash2.FreqLarge();

            //UC3

            UC3_Remove hash3 = new UC3_Remove();
            hash3.removeWord("");
        }
    }
}
