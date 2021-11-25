using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class IListExtensions
    {
        public static bool ContainsIndex<T>(this IList<T> source, int index)
        {
            return index < source.Count;
        }
    }
}
