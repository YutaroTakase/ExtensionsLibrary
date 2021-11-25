using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class IListExtensions
    {
        public static bool ContainsIndex<T>(this IList<T> self, int index)
        {
            return index < self.Count;
        }
    }
}
