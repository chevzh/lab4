using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    partial class Set<T> : IEnumerable<T>
    {
        public static Set<T> operator - (Set<T> items, T item)
        {
            if (items == null) throw new ArgumentNullException();


            Set<T> renewedItems = new Set<T>(items);
            
            renewedItems.Remove(item);
            return renewedItems;
        }

        //public static Set<T> operator +()
        //{

        //}
    }
}
