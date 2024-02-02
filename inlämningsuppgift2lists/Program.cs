using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace listinlämning_1
{
    class Program
    {


        static void Main(string[] args)
        {
            List<int> tal = new List<int>();
            tal.Add(1);
            tal.Add(2);
            tal.Add(7);
            tal.Add(3);
            tal.Add(5);
            tal.Add(1);
            Max(tal);
        }

        static void Max(List<int>tal)
        {
            int störst = 0;
            foreach (int item in tal)
            {
                if (item > störst) 
                {
                    störst = item;
                }
            }
            Console.WriteLine(störst);
        }

    }
}
