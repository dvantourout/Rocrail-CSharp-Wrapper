
using System;
using System.Collections.Generic;

namespace GlobalDefinitions
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }

        public static bool IsSet(this string str)
        {
            return str != string.Empty && str != null;
        }
    }
}
