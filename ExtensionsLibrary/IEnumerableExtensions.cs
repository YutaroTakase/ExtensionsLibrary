using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class IEnumerableExtensions
    {
        public static void AsParallelForAll<T>(this IEnumerable<T> source, Action<T> action)
        {
            source.AsParallel().ForAll(x => action(x));
        }

        public static IEnumerable<IEnumerable<T>> Chunks<T>(this IEnumerable<T> source, int chunkSize)
        {
            while (source.Any())
            {
                yield return source.Take(chunkSize);
                source = source.Skip(chunkSize);
            }
        }

        public static Dictionary<TKey, TSource> ToDistinctDictionary<TKey, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) where TKey : notnull
        {
            var result = new Dictionary<TKey, TSource>();

            foreach (var item in source)
            {
                var key = keySelector(item);
                if (!result.ContainsKey(key))
                {
                    result.Add(key, item);
                }
            }

            return result;
        }

        public static Dictionary<TKey, TValue> ToDistinctDictionary<TKey, TValue, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector) where TKey : notnull
        {
            var result = new Dictionary<TKey, TValue>();

            foreach (var item in source)
            {
                var key = keySelector(item);
                if (!result.ContainsKey(key))
                {
                    result.Add(key, valueSelector(item));
                }
            }

            return result;
        }
    }
}
