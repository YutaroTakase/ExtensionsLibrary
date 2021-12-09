namespace ExtensionsLibrary;
public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string source) 
    { 
        return string.IsNullOrEmpty(source); 
    }

    public static bool IsNullOrWhiteSpace(this string source)
    { 
        return string.IsNullOrWhiteSpace(source);
    }

    public static int ToInt(this string source) 
    { 
        return int.Parse(source); 
    }

    public static int? ToIntOrNull(this string source)
    {
        if (int.TryParse(source, out var result))
        {
            return result;
        }

        return null;
    }

    public static int ToIntOrDefault(this string source, int defaultValue = 0)
    {
        var result = ToIntOrNull(source);

        if (result.HasValue)
        {
            return result.Value;
        }

        return defaultValue;
    }
}
