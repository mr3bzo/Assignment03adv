using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03ADV
{
    internal class SortingConditions
    {
        public static bool CompareGtr(int X, int Y) { return X > Y; }

        public static bool CompareLess(int X, int Y)
        {
            return X > Y;
        }
        public static bool CompareGtr(string X, string Y) { return X.Length > Y.Length; }

        public static bool CompareLess(string X, string Y)
        {
            return X.Length > Y.Length;
        }
    }
}
