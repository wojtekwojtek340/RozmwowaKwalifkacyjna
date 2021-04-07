using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozmowaKwalifikacyjna
{
    class LambdaComparer<T> : IComparer<T>
    {
        readonly Func<T, T, int> compareFunction;

        public LambdaComparer(Func<T, T, int> compareFunction)
        {
            this.compareFunction = compareFunction;
        }
        public int Compare(T x, T y)
        {
            return compareFunction(x, y);
        }
    }
}
