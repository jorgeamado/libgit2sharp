using System;
using System.Collections.Generic;
using System.Linq;

namespace LibGit2Sharp.Core
{
    internal static class EnumExtensions
    {
        public static bool HasAny(this Enum enumInstance, IEnumerable<Enum> entries)
        {
            return entries.Any(enumInstance.HasFlag);
        }

        public static bool HasFlag<T>(this Enum enumInstance, T entry)
        {
            return ((int)(object)enumInstance & (int)(object)entry) == (int)(object)(entry);
        }
    }
}
