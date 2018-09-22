using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public partial class Set<T> : IEnumerable<T>
    {
        public static Set<T> operator - (Set<T> items, T item)
        {
            if (items == null) throw new ArgumentNullException();


            Set<T> renewedItems = new Set<T>(items);
            
            renewedItems.Remove(item);
            return renewedItems;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {            
            IEnumerable<T> resultSet = set1.Intersect(set2);
            return resultSet.ToSet(); ;
        }

        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            return set1.SequenceEqual(set2);
        }

        public static bool operator > (Set<T> set1, Set<T> set2)
        {
            return set2.IsSubset(set1);
        }


        // возвращает объединение множеств(все элементы из двух множеств)
        public static Set<T> operator & (Set<T> set1, Set<T> set2)
        {
            Set<T> resultSet = new Set<T>(set1.Union(set2));
            return resultSet;
        }
    }
}
