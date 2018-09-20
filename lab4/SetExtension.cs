using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class SetExtension
    {
        public static Set<T> ToSet<T>(this IEnumerable<T> source)
        {
            return new Set<T>(source);
        }



    }
}
