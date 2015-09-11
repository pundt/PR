using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite;
using BSP1;

namespace UT1
{
    [TestClass]
    public class UT_Verzweigungen
    {
        [TestMethod]
        public void BSP1_Aufgabe_001()
        {
            Computer c = new Computer();
            c.WertSetzen<double>("ghz", 3);
            Programmieren.PrüfeMethode<double>(c, "Aufrüsten", null, "ghz", (x => { return x == 3; }));

            c.WertSetzen<double>("ghz", 4);
            Programmieren.PrüfeMethode<double>(c, "Aufrüsten", null, "ghz", (x => { return x == 4; }));

            c.WertSetzen<double>("ghz", 5);
            Programmieren.PrüfeMethode<double>(c, "Aufrüsten", null, "ghz", (x => { return x == 10; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_002()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000*3; }));

            c.WertSetzen<int>("speicherplatzInMB", 2000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 2000 * 3; }));

            c.WertSetzen<int>("speicherplatzInMB", 10000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 10000 * 3; }));

            c.WertSetzen<int>("speicherplatzInMB", 10001);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 10001 * 2; }));

            c.WertSetzen<int>("speicherplatzInMB", 15000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 15000 * 2; }));

            c.WertSetzen<int>("speicherplatzInMB", 15001);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 15001 * 4; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_003()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_004()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_005()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_006()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_007()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_008()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_009()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_010()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));
        }
    }
}
