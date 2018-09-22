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
            Set<string> set1 = new Set<string>
            {
                "123",
                "qq"
            };
            //set.Add(null);



            Set<string> set2 = new Set<string>(set1.AddPoint());
            set2.Add("123");
           
            foreach (var el in set2)
            {
                Console.WriteLine(el);
            }

            
            Console.WriteLine("------------------");
            Set<string> newSet = set1 - "qq";
            
            foreach (var el in newSet)
            {
                Console.WriteLine(el);
            }

            foreach (var el in set1)
            {
                Console.WriteLine(el);
            }


            Set<int> list1 = new Set<int>() { 8,9,10};
            Set<int> list2 = new Set<int>() { 8,9,0,11,0};

            Set<int> list3 = new Set<int>(list2.DeleteZeroElements());

            Set<int>list = list1 & list3;

            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            
            Console.WriteLine(set1 > set2);
            Console.WriteLine(set2.IsSubset(set1));

        }
    }
}
