namespace ExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static int? ToIntOrNull(this string value)
        {
            if (int.TryParse(value, out var result))
            {
                return result;
            }

            return null;
        }

        public static int ToIntOrDefault(this string value, int defaultValue = 0)
        {
            var result = ToIntOrNull(value);

            if (result.HasValue)
            {
                return result.Value;
            }

            return defaultValue;
        }
    }
}
