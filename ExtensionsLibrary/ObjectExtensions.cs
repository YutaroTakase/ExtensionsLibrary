using System.Text.Json;

namespace ExtensionsLibrary;

public static class ObjectExtensions
{
    public static T? DeepCopy<T>(this object source)
    {
        var json = JsonSerializer.Serialize(source);
        return JsonSerializer.Deserialize<T>(json);
    }
}
