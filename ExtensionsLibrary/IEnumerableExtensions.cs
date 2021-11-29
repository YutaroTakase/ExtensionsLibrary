namespace ExtensionsLibrary
{
    public static class IEnumerableExtensions
    {
        public static string StringJoin<T>(this IEnumerable<T> source, string separator)
        {
            return string.Join(separator, source);
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

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source is null || !source.Any();
        }
    }
}
