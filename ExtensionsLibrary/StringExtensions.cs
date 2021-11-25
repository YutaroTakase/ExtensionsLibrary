namespace ExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string self)
        {
            return string.IsNullOrEmpty(self);
        }

        public static bool IsNullOrWhiteSpace(this string self)
        {
            return string.IsNullOrWhiteSpace(self);
        }

        public static int ToInt(this string self)
        {
            return int.Parse(self);
        }

        public static int? ToIntOrNull(this string self)
        {
            if (int.TryParse(self, out var result))
            {
                return result;
            }

            return null;
        }

        public static int ToIntOrDefault(this string self, int defaultValue = 0)
        {
            var result = ToIntOrNull(self);

            if (result.HasValue)
            {
                return result.Value;
            }

            return defaultValue;
        }
    }
}
