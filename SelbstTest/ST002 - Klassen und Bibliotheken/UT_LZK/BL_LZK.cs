using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite;
using BL_LZK;
using BL_pundt;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace UT_LZK
{
    [TestClass]
    public class BL_LZK
    {
        [TestMethod]
        public void UT_Aufgabe001()
        {
            Programmieren.PrüfeEigenschaft(typeof(Tour), "Preis", typeof(double));
            Programmieren.PrüfeEigenschaft(typeof(Tour), "Name", typeof(string));
        }
        [TestMethod]
        public void UT_Aufgabe002()
        {
            Programmieren.PrüfeFeld(typeof(TourManagement), "manager", typeof(DataManagement));
        }
        [TestMethod]
        public void UT_Aufgabe003()
        {
            Trace.WriteLine("Kein Unit-Test möglich!");
        }
        [TestMethod]
        public void UT_Aufgabe004()
        {
            TourManagement tm = new TourManagement("test");

            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(tm.Buchen("tour" + i, i * 10), "Aufruf von Buchen liefert nicht das erwartete Resultat!");
            }

            Assert.IsFalse(tm.Buchen("tour101", 123123), "Aufruf von Buchen liefert nicht das erwartete Resultat!");
        }
        [TestMethod]
        public void UT_Aufgabe005()
        {
            Assembly lzkAssembly = Assembly.GetAssembly(typeof(TourManagement));
            string pfad = Path.Combine(Path.GetDirectoryName(new Uri(lzkAssembly.CodeBase).LocalPath), "touren.csv");
            TourManagement tm = new TourManagement(pfad);

            tm.Importieren();

            Assert.IsTrue(tm.touren.Count == 4, "Importieren erzeugt nicht die richtige Anzahl von Touren!");
        }
        [TestMethod]
        public void UT_Aufgabe006()
        {
            Trace.WriteLine("Kein Unit-Test möglich!");
        }
        [TestMethod]
        public void UT_Aufgabe007()
        {
            Trace.WriteLine("Kein Unit-Test möglich!");
        }
    }
}
