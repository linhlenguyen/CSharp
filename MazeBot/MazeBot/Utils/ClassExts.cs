using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBot.Utils
{
    public static class ClassExts
    {
        public static IEnumerable<T> Clone<T>(this IEnumerable<T> ls) where T : ICloneable
        {
            return ls.Select(i => (T)i.Clone());
        }

        public static string Show<T>(this IEnumerable<T> ls)
        {
            string result = "";
            foreach (T i in ls)
            {
                result += (result.Length == 0? "" : " ") + i.ToString();
            }
            return result;
        }
    }
}
