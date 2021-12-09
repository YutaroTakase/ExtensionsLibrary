namespace ExtensionsLibrary;
public static class IListExtensions
{
    public static bool ContainsIndex<T>(this IList<T> source, int index) 
    { 
        return index < source.Count; 
    }
}
