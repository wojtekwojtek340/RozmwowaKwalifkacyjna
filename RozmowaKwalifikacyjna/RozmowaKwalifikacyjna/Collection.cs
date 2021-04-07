using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozmowaKwalifikacyjna
{
    public static class Collection
    {
        public static void DodajDoIstniejacej<T>(this List<T> kolekcja1, IEnumerable<T> kolekcja2, IComparer<T> comparer)
        {
            kolekcja1.AddRange(kolekcja2);
            kolekcja1.Sort(comparer);
        }
        public static void DodajDoIstniejacej<T>(this List<T> kolekcja1, IEnumerable<T> kolekcja2) where T: IComparable<T>
        {
            kolekcja1.AddRange(kolekcja2);
            kolekcja1.Sort();
        }
    }
}
