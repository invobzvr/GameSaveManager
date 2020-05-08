namespace GameSaveManager
{
    public static class Extensions
    {
        public static string TV(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }
    }
}
