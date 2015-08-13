using System;
using BSP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TestSuite;

namespace UT1
{
    [TestClass]
    public class UT_Grundlagen
    {
        [TestMethod]
        public void Aufgabe_1()
        {
            Programmieren.PrüfeFeld(typeof(Person), "alter", typeof(int));
        }

        [TestMethod]
        public void Aufgabe_2()
        {
            Programmieren.PrüfeWert<int>(typeof(Person), "alter", (x => { return x > 0 && x < 150; }));
        }

        [TestMethod]
        public void Aufgabe_3()
        {
            Programmieren.PrüfeFeld(typeof(Konto), "kontoStand", typeof(double));
        }

        [TestMethod]
        public void Aufgabe_4()
        {
            Programmieren.PrüfeWert<double>(typeof(Konto), "kontoStand", (x => { return x > -100000 && x < 999999999; }));
        }

        [TestMethod]
        public void Aufgabe_5()
        {
            Programmieren.PrüfeFeld(typeof(Auto), "ps", typeof(int));
            Programmieren.PrüfeFeld(typeof(Auto), "kennzeichen", typeof(string));
        }

        [TestMethod]
        public void Aufgabe_6()
        {
            Programmieren.PrüfeWert<string>(typeof(Auto), "kennzeichen", (x => string.IsNullOrEmpty(x)));
            Programmieren.PrüfeWert<string>(typeof(Auto), "kennzeichen", (x => x.StartsWith("W")));
            Programmieren.PrüfeWert<int>(typeof(Auto), "ps", (x => x >= 50 && x <= 300));
        }

        [TestMethod]
        public void Aufgabe_7()
        {
            Programmieren.PrüfeFeld(typeof(Haus), "höhe", typeof(int));
            Programmieren.PrüfeFeld(typeof(Haus), "länge", typeof(int));
            Programmieren.PrüfeFeld(typeof(Haus), "breite", typeof(int));
        }

        [TestMethod]
        public void Aufgabe_8()
        {
            Programmieren.PrüfeWert<int>(typeof(Haus), "höhe", (x => x >= 1 && x <= 100));
            Programmieren.PrüfeWert<int>(typeof(Haus), "länge", (x => x >= 1 && x <= 100));
            Programmieren.PrüfeWert<int>(typeof(Haus), "breite", (x => x >= 1 && x <= 100));
        }

    }
}
