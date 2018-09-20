using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    partial class Set<T> : IEnumerable<T>
    {
        private List<T> _items;

        public Set()
        {
            _items = new List<T>();
        }

        public Set(IEnumerable<T> items)
        {
            _items = new List<T>(items);
        }

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException();
            if (_items.Contains(item)) throw new Exception();//добавить своё исключение!!
            
            _items.Add(item);
        }

        public void Remove(T item)
        {
            if (item == null) throw new ArgumentNullException();
            _items.Remove(item);
        }


        public  Set<T> Intersect(Set<T> set1, Set<T> set2)
        {
            if (set1 == null) throw new ArgumentNullException();
            if (set2 == null) throw new ArgumentNullException();

            List<T> list1 = new List<T>(set1);
            List<T> list2 = new List<T>(set2);
            List<T> list3 = new List<T>();

            list3 = list1.Intersect(list2).ToList();

            Set<T> resultSet = new Set<T>(list3);

            return resultSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

       
    }
}
