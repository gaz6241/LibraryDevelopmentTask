namespace LibraryDevelopmentTask.Extensions
{
    public static class Extensions
    {
        public static T ParseEnum<T>(string value)
        {
            var d =  (T)Enum.Parse(typeof(T), value, true);
            return d;
        }
    }
}
