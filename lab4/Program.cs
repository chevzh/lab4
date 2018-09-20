using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<string> set = new Set<string>();

            set.Add("123");
            set.Add("qq");
            //set.Add(null);

          
            foreach(var el in set)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("------------------");
            Set<string> newSet = set - "qq";
            foreach (var el in newSet)
            {
                Console.WriteLine(el);
            }

            foreach(var el in set)
            {
                Console.WriteLine(el);
            }


            Set<int> list1 = new Set<int>() { 8,9,10};
            Set<int> list2 = new Set<int>() { 8};
            Set<int> list3 = new Set<int>();
            list3 = list1.Intersect(list2).ToList();

            foreach (var el in list3)
            {
                Console.WriteLine(el);
            }

        }
    }
}
