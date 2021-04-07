using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RozmowaKwalifikacyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> tab1 = new List<Osoba>() { new Osoba() {Nazwisko = "Kowalski"} };
            Osoba[] tab3 = { new Osoba() { Nazwisko = "Adamski" } };

            var lambdaComparer = new LambdaComparer<Osoba>((x,y) => new CaseInsensitiveComparer().Compare(x.Nazwisko, y.Nazwisko));

            tab1.DodajDoIstniejacej(tab3, lambdaComparer);
        }
    }

    public class Osoba //: IComparable<Osoba>
    { 
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        //public int CompareTo(Osoba x)
        //{
        //    return (new CaseInsensitiveComparer()).Compare((x).Nazwisko, this.Nazwisko);
        //}
    }
}
