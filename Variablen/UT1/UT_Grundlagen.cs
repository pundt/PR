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
        public void BSP1_Aufgabe_001()
        {
            Programmieren.PrüfeFeld(typeof(Person), "alter", typeof(int));
        }

        [TestMethod]
        public void BSP1_Aufgabe_002()
        {
            Programmieren.PrüfeWert<int>(typeof(Person), "alter", (x => { return x > 0 && x < 150; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_003()
        {
            Programmieren.PrüfeFeld(typeof(Konto), "kontoStand", typeof(double));
        }

        [TestMethod]
        public void BSP1_Aufgabe_004()
        {
            Programmieren.PrüfeWert<double>(typeof(Konto), "kontoStand", (x => { return x > -100000 && x < 999999999; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_005()
        {
            Programmieren.PrüfeFeld(typeof(Auto), "ps", typeof(int));
            Programmieren.PrüfeFeld(typeof(Auto), "kennzeichen", typeof(string));
        }

        [TestMethod]
        public void BSP1_Aufgabe_006()
        {
            Programmieren.PrüfeWert<string>(typeof(Auto), "kennzeichen", (x => !string.IsNullOrEmpty(x)));
            Programmieren.PrüfeWert<string>(typeof(Auto), "kennzeichen", (x => x.StartsWith("W")));
            Programmieren.PrüfeWert<int>(typeof(Auto), "ps", (x => x >= 50 && x <= 300));
        }

        [TestMethod]
        public void BSP1_Aufgabe_007()
        {
            Programmieren.PrüfeFeld(typeof(Haus), "höhe", typeof(int));
            Programmieren.PrüfeFeld(typeof(Haus), "länge", typeof(int));
            Programmieren.PrüfeFeld(typeof(Haus), "breite", typeof(int));
        }

        [TestMethod]
        public void BSP1_Aufgabe_008()
        {
            Programmieren.PrüfeWert<int>(typeof(Haus), "höhe", (x => x >= 1 && x <= 100));
            Programmieren.PrüfeWert<int>(typeof(Haus), "länge", (x => x >= 1 && x <= 100));
            Programmieren.PrüfeWert<int>(typeof(Haus), "breite", (x => x >= 1 && x <= 100));
        }

        [TestMethod]
        public void BSP1_Aufgabe_009()
        {
            Programmieren.PrüfeFeld(typeof(Raumschiff), "hatPhasor", typeof(bool));
            Programmieren.PrüfeFeld(typeof(Raumschiff), "anzahlTorpedos", typeof(int));
            Programmieren.PrüfeFeld(typeof(Raumschiff), "kennung", typeof(string));
        }

        [TestMethod]
        public void BSP1_Aufgabe_010()
        {
            Programmieren.PrüfeWert<bool>(typeof(Raumschiff), "hatPhasor", (x => x==true || x ==false));
            Programmieren.PrüfeWert<int>(typeof(Raumschiff), "anzahlTorpedos", (x => x >= 0 && x <= 1999));
            Programmieren.PrüfeWert<string>(typeof(Raumschiff), "kennung", (x => x.StartsWith("NCC-1701",StringComparison.InvariantCultureIgnoreCase)));
        }

        [TestMethod]
        public void BSP1_Aufgabe_011()
        {
            Programmieren.PrüfeFeld(typeof(Dokument), "typ", typeof(string));
            Programmieren.PrüfeFeld(typeof(Dokument), "anzahlBytes", typeof(long));
            Programmieren.PrüfeFeld(typeof(Dokument), "dokumentenName", typeof(string));
        }

        [TestMethod]
        public void BSP1_Aufgabe_012()
        {
            Programmieren.PrüfeWert<string>(typeof(Dokument), "typ", (x => x.Equals(".xlsx", StringComparison.InvariantCultureIgnoreCase)));
            Programmieren.PrüfeWert<long>(typeof(Dokument), "anzahlBytes", (x => x >= 10000 && x <= 4999999));
            Programmieren.PrüfeWert<string>(typeof(Dokument), "dokumentenName", (x => x.Length >= 5));
        }
    }
}
