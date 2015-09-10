using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite;
using BSP2;

namespace UT2
{
    [TestClass]
    public class UT_Datentypen
    {
        [TestMethod]
        public void BSP2_Aufgabe_001()
        {
            Programmieren.PrüfeFeld(typeof(Person), "vorname", typeof(string));
            Programmieren.PrüfeFeld(typeof(Person), "nachname", typeof(string));
            Programmieren.PrüfeFeld(typeof(Person), "alter", typeof(int));
            Programmieren.PrüfeFeld(typeof(Person), "geschlecht", typeof(char));
        }

        [TestMethod]
        public void BSP2_Aufgabe_002()
        {
            Programmieren.PrüfeFeld(typeof(Brille), "dioptrien", typeof(double));
            Programmieren.PrüfeFeld(typeof(Brille), "gleitsicht", typeof(bool));
            Programmieren.PrüfeFeld(typeof(Brille), "farbe", typeof(string));
        }

        [TestMethod]
        public void BSP2_Aufgabe_003()
        {
            Programmieren.PrüfeFeld(typeof(Monster), "lebenspunkte", typeof(int));
            Programmieren.PrüfeFeld(typeof(Monster), "kannZaubern", typeof(bool));
            Programmieren.PrüfeFeld(typeof(Monster), "typ", typeof(string));
            Programmieren.PrüfeFeld(typeof(Monster), "istLebendig", typeof(bool));
        }

        [TestMethod]
        public void BSP2_Aufgabe_004()
        {
            Programmieren.PrüfeFeld(typeof(Computer), "ghz", typeof(double));
            Programmieren.PrüfeFeld(typeof(Computer), "betriebsSystem", typeof(string));
            Programmieren.PrüfeFeld(typeof(Computer), "ipAdresse", typeof(string));
        }

        [TestMethod]
        public void BSP2_Aufgabe_005()
        {
            Programmieren.PrüfeFeld(typeof(Regenschirm), "durchmesser", typeof(double));
            Programmieren.PrüfeFeld(typeof(Regenschirm), "farbe", typeof(string));
            Programmieren.PrüfeFeld(typeof(Regenschirm), "hatAutomatik", typeof(bool));
        }

        [TestMethod]
        public void BSP2_Aufgabe_006()
        {
            Programmieren.PrüfeFeld(typeof(Konto), "kontoStand", typeof(int));
            Programmieren.PrüfeFeld(typeof(Konto), "eigentümer", typeof(string));
            Programmieren.PrüfeFeld(typeof(Konto), "rahmen", typeof(int));
            Programmieren.PrüfeFeld(typeof(Konto), "hatBankomatkarte", typeof(bool));
        }
    }
}
