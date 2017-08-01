using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> things = new List<object>();
            things.Add(7);
            things.Add(28);
            things.Add(-1);
            things.Add(true);
            things.Add("chair");

            int sum = 0;
            for(int i = 0;i<things.Count;i++){
                Console.WriteLine(things[i]);
                if(things[i] is int){
                    sum = sum + (int)things[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
