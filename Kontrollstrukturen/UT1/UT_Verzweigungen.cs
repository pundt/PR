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

            c = new Computer();
            c.WertSetzen<double>("ghz", 4);
            Programmieren.PrüfeMethode<double>(c, "Aufrüsten", null, "ghz", (x => { return x == 4; }));

            c = new Computer();
            c.WertSetzen<double>("ghz", 5);
            Programmieren.PrüfeMethode<double>(c, "Aufrüsten", null, "ghz", (x => { return x == 10; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_002()
        {
            Computer c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 5000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 5000 * 3; }));

            c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 2000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 2000 * 3; }));

            c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 10000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 10000 * 3; }));

            c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 10001);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 10001 * 2; }));

            c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 15000);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 15000 * 2; }));

            c = new Computer();
            c.WertSetzen<int>("speicherplatzInMB", 15001);
            Programmieren.PrüfeMethode<int>(c, "SpeicherErweitern", null, "speicherplatzInMB", (x => { return x == 15001 * 4; }));
        }

        [TestMethod]
        public void BSP1_Aufgabe_003()
        {
            Spieler s = new Spieler();
            s.WertSetzen<int>("anzahlGelbeKarten", 11);
            Programmieren.PrüfeMethode<bool>(s, "eintrittGruppenPhase", null, "gesperrt", x => { return x; });

            s = new Spieler();
            s.WertSetzen<int>("anzahlRoteKarten", 1);
            Programmieren.PrüfeMethode<bool>(s, "eintrittGruppenPhase", null, "gesperrt", x => { return x; });
            
            s = new Spieler();
            s.WertSetzen<int>("anzahlGelbeKarten", 0);
            s.WertSetzen<int>("anzahlRoteKarten", 0);
            Programmieren.PrüfeMethode<bool>(s, "eintrittGruppenPhase", null, "gesperrt", x => { return !x; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_004()
        {
            Spieler s = new Spieler();
            Programmieren.PrüfeMethode<int>(s, "eintrittFinalSpiele", null, "anzahlRoteKarten", x => { return x == 0; });

            s.WertSetzen<int>("anzahlGelbeKarten", 10);
            Programmieren.PrüfeMethode<int>(s, "eintrittFinalSpiele", null, "anzahlGelbeKarten", x => { return x == 5; });

            s = new Spieler();
            s.WertSetzen<int>("anzahlGelbeKarten", 4);
            Programmieren.PrüfeMethode<int>(s, "eintrittFinalSpiele", null, "anzahlGelbeKarten", x => { return x == 0; });

            s = new Spieler();
            s.WertSetzen<int>("anzahlGelbeKarten", 5);
            Programmieren.PrüfeMethode<int>(s, "eintrittFinalSpiele", null, "anzahlGelbeKarten", x => { return x == 0; });

            s = new Spieler();
            s.WertSetzen<int>("anzahlGelbeKarten", 0);
            Programmieren.PrüfeMethode<int>(s, "eintrittFinalSpiele", null, "anzahlGelbeKarten", x => { return x == 0; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_005()
        {
            Handy h = new Handy();
            h.WertSetzen<string>("tarif", "mini");
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenSMS", x => { return x == 0.2; });
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenMegaByte", x => { return x == 0.35; });

            h = new Handy();
            h.WertSetzen<string>("tarif", "midi");
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenSMS", x => { return x == 0.16; });
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenMegaByte", x => { return x == 0.33; });

            h = new Handy();
            h.WertSetzen<string>("tarif", "maxi");
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenSMS", x => { return x == 0.14; });
            Programmieren.PrüfeMethode<double>(h, "tarifWechsel", null, "kostenMegaByte", x => { return x == 0.3; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_006()
        {
            Handy h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 21);
            h.WertSetzen<int>("anzahlMegaByte", 999);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "mini"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 19);
            h.WertSetzen<int>("anzahlMegaByte", 1001);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "mini"; });

            h = new Handy(); 
            h.WertSetzen<int>("anzahlSMS", 19);
            h.WertSetzen<int>("anzahlMegaByte", 999);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x != "mini"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 51);
            h.WertSetzen<int>("anzahlMegaByte", 999);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "midi"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 19);
            h.WertSetzen<int>("anzahlMegaByte", 1501);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "midi"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 49);
            h.WertSetzen<int>("anzahlMegaByte", 1499);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "mini"; });


            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 101);
            h.WertSetzen<int>("anzahlMegaByte", 2001);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "maxi"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 99);
            h.WertSetzen<int>("anzahlMegaByte", 2001);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "midi"; });

            h = new Handy();
            h.WertSetzen<int>("anzahlSMS", 99);
            h.WertSetzen<int>("anzahlMegaByte", 1999);
            Programmieren.PrüfeMethode<string>(h, "autoTarifWahl", null, "tarif", x => { return x == "midi"; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_007()
        {
            Dokument d = new Dokument();
            d.WertSetzen<string>("dateiTyp", ".exe");
            Programmieren.PrüfeMethode<bool>(d, "schützen", null, "geschützt", x => { return x; });

            d = new Dokument();
            d.WertSetzen<string>("dateiTyp", ".bat");
            d.WertSetzen<int>("anzahlBytes", 5001);
            Programmieren.PrüfeMethode<bool>(d, "schützen", null, "geschützt", x => { return x; });

            d = new Dokument();
            d.WertSetzen<string>("dateiTyp", ".bat");
            d.WertSetzen<int>("anzahlBytes", 4999);
            Programmieren.PrüfeMethode<bool>(d, "schützen", null, "geschützt", x => { return !x; });

            d = new Dokument();
            d.WertSetzen<string>("dateiTyp", ".txt");
            d.WertSetzen<int>("anzahlBytes", 5001);
            Programmieren.PrüfeMethode<bool>(d, "schützen", null, "geschützt", x => { return !x; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_008()
        {
            Dokument d = new Dokument();
            d.WertSetzen<bool>("geschützt", true);
            d.WertSetzen<int>("anzahlBytes", 200);
            Programmieren.PrüfeMethode<string>(d, "schützen", null, "dateiTyp", x => { return x == ".locked"; });

            d = new Dokument();
            d.WertSetzen<bool>("geschützt", true);
            d.WertSetzen<int>("anzahlBytes", 200);
            Programmieren.PrüfeMethode<int>(d, "schützen", null, "anzahlBytes", x => { return x == 320; });

            d = new Dokument();
            d.WertSetzen<bool>("geschützt", false);
            d.WertSetzen<int>("anzahlBytes", 200);
            Programmieren.PrüfeMethode<string>(d, "schützen", null, "dateiTyp", x => { return x == ".unlocked"; });

            d = new Dokument();
            d.WertSetzen<bool>("geschützt", false);
            d.WertSetzen<int>("anzahlBytes", 200);
            Programmieren.PrüfeMethode<int>(d, "schützen", null, "anzahlBytes", x => { return x == 150; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_009()
        {
            Wohnung w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 101);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 1000; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 99);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x != 1000; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 101);
            w.WertSetzen<bool>("balkon", true);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 1300; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 101);
            w.WertSetzen<bool>("balkon", false);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 1000; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 100);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 800; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 76);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 800; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 76);
            w.WertSetzen<bool>("balkon", true);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 1100; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 76);
            w.WertSetzen<bool>("balkon", false);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 800; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 75);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 500; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 51);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 500; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 51);
            w.WertSetzen<bool>("balkon", true);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 650; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 51);
            w.WertSetzen<bool>("balkon", false);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 500; });

            w = new Wohnung();
            w.WertSetzen<int>("anzahlM2", 50);
            Programmieren.PrüfeMethode<double>(w, "preisBerechnen", null, "preis", x => { return x == 0; });
        }

        [TestMethod]
        public void BSP1_Aufgabe_010()
        {
            Wohnung w = new Wohnung();
            w.WertSetzen<string>("adresse", "A-1030");
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x==800; });

            w = new Wohnung();
            w.WertSetzen<string>("adresse", "A-1050");
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return !x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x == 700; });

            w = new Wohnung();
            w.WertSetzen<string>("adresse", "A-1070");
            w.WertSetzen<int>("anzahlM2", 89);
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x == 1200; });

            w = new Wohnung();
            w.WertSetzen<string>("adresse", "A-1070");
            w.WertSetzen<int>("anzahlM2", 90);
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return !x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x == 0; });

            w = new Wohnung();
            w.WertSetzen<string>("adresse", "A-1070");
            w.WertSetzen<int>("anzahlM2", 91);
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return !x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x == 0; });

            w = new Wohnung();
            w.WertSetzen<string>("adresse", "asdf");
            Programmieren.PrüfeMethode<bool>(w, "umbauen", null, "balkon", x => { return !x; });
            Programmieren.PrüfeMethode<double>(w, "umbauen", null, "preis", x => { return x == 0; });
        }
    }
}
