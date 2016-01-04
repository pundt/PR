using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite;
using LZK;

namespace UT_LZK
{
    [TestClass]
    public class UT_LZK
    {
        [TestMethod]
        public void LZK_Aufgabe_024()
        {
            Programmieren.PrüfeFeld(typeof(Geschenk), "beschreibung", typeof(string));
            Programmieren.PrüfeFeld(typeof(Geschenk), "größe", typeof(int));
        }

        [TestMethod]
        public void LZK_Aufgabe_025()
        {
            Geschenk g = new Geschenk();
            g.WertSetzen<bool>("verpackt", true);
            Programmieren.PrüfeMethode<double>(g, "PreisBerechnen", null, "preis", x => { return x == 10; });

            g.WertSetzen<bool>("verpackt", false);
            Programmieren.PrüfeMethode<double>(g, "PreisBerechnen", null, "preis", x => { return x == 0; });
        }

        [TestMethod]
        public void LZK_Aufgabe_021()
        {
            Programmieren.PrüfeFeld(typeof(Bild), "istEinPlagiat", typeof(bool));
            Programmieren.PrüfeFeld(typeof(Bild), "länge", typeof(double));
            Programmieren.PrüfeFeld(typeof(Bild), "breite", typeof(double));
        }

        [TestMethod]
        public void LZK_Aufgabe_022()
        {
            Programmieren.PrüfeWert<string>(typeof(Bild), "künstler", x => { return !string.IsNullOrEmpty(x); });
            Programmieren.PrüfeWert<double>(typeof(Bild), "länge", x => { return x >= 0 && x <= 10; });
            Programmieren.PrüfeWert<double>(typeof(Bild), "breite", x => { return x >= 0 && x <= 10; });

        }

        [TestMethod]
        public void LZK_Aufgabe_023()
        {
            Bild b = new Bild();
            b.WertSetzen<double>("länge", 6);
            Programmieren.PrüfeMethode<double>(b, "Versteigerung", null, "preis", x => { return x == 75; });
            b.WertSetzen<double>("länge", 5);
            Programmieren.PrüfeMethode<double>(b, "Versteigerung", null, "preis", x => { return x == 50; });
            b.WertSetzen<double>("länge", 4);
            Programmieren.PrüfeMethode<double>(b, "Versteigerung", null, "preis", x => { return x == 25; });

            b.WertSetzen<bool>("istEinPlagiat", true);
            Programmieren.PrüfeMethode<string>(b, "Versteigerung", null, "künstler", x => { return x == "abmaler"; });
        }

    }
}
