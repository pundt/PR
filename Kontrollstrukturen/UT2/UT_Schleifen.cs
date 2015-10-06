using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BSP2;
using System.IO;
using System.Text;
using System.Linq;

namespace UT2
{
    [TestClass]
    public class UT_Schleifen
    {
        [TestMethod]
        public void BSP1_Aufgabe_011()
        {
            KaffeeMaschine k = new KaffeeMaschine();
            Random generator = new Random();
            int kapseln = generator.Next(51, 10000);
            k.WertSetzen<int>("kapselnVorhanden", kapseln);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                k.KaffeeMachen();
                StringBuilder sb = new StringBuilder();

                for (int i = kapseln; i > 50; i--)
                    sb.AppendLine(i.ToString());

                Assert.IsTrue(sw.ToString() == sb.ToString(), "Schleifenausgabe falsch! Bitte 'KaffeeMachen()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_012()
        {
            KaffeeMaschine k = new KaffeeMaschine();
            Random generator = new Random();
            int kapseln = generator.Next(3, 10000);
            k.WertSetzen<int>("kapselnVorhanden", kapseln);
            k.WertSetzen<bool>("mussEntkalktWerden", true);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                k.Rücksetzen();

                StringBuilder sb = new StringBuilder();

                for (int i = kapseln; i > 0; i -= 2)
                    sb.AppendLine(true.ToString());

                Assert.IsTrue(sw.ToString() == sb.ToString(), "Schleifenausgabe falsch! Bitte 'Rücksetzen()' kontrollieren!");
                Assert.IsTrue(!((bool)k.WertAuslesen("mussEntkalktWerden")), "Ungültiger Wert für 'mussEntkalktWerden'. Bitte 'Rücksetzen()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_013()
        {
            Drucker d = new Drucker();
            Random generator = new Random();
            int dokumenteInWarteschlange = generator.Next(100, 10000);
            d.WertSetzen<int>("dokumenteInWarteschlange", dokumenteInWarteschlange);
            d.WertSetzen<bool>("IstSauber", true);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                d.Drucken();

                StringBuilder sb = new StringBuilder();

                while (dokumenteInWarteschlange > 0)
                {
                    dokumenteInWarteschlange--;
                    sb.AppendLine(dokumenteInWarteschlange.ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(), "Schleifenausgabe falsch! Bitte 'Drucken()' kontrollieren!");
                Assert.IsTrue(!((bool)d.WertAuslesen("IstSauber")), "Ungültiger Wert für 'IstSauber'. Bitte 'Drucken()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_014()
        {
            Drucker d = new Drucker();
            Random generator = new Random();
            double tintenStand = generator.Next(1, 10) / 10;
            d.WertSetzen<double>("tintenStand", tintenStand);
            d.WertSetzen<bool>("IstSauber", true);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                d.Reinigen();

                StringBuilder sb = new StringBuilder();

                while (tintenStand < 1)
                {
                    tintenStand += 0.05;
                    sb.AppendLine(tintenStand.ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(), "Schleifenausgabe falsch! Bitte 'Reinigen()' kontrollieren!");
                Assert.IsTrue(((bool)d.WertAuslesen("IstSauber")), "Ungültiger Wert für 'IstSauber'. Bitte 'Drucken()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_015()
        {
            VirenScanner vs = new VirenScanner();
            vs.WertSetzen<bool>("virusGefunden", false);
            Random generator = new Random();
            int anzahlDokumenteGescanned = generator.Next(1, 5000);
            vs.WertSetzen<int>("anzahlDokumenteGescanned", anzahlDokumenteGescanned);
            vs.WertSetzen<string>("lizenzSchlüssel", "pe192fn");

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                vs.Scannen();

                StringBuilder sb = new StringBuilder();
                do
                {
                    anzahlDokumenteGescanned++;
                    sb.AppendLine(vs.WertAuslesen("lizenzSchlüssel").ToString());
                } while (anzahlDokumenteGescanned < 10000 && (!(bool)vs.WertAuslesen("virusGefunden")));

                Assert.IsTrue(sw.ToString() == sb.ToString(), "Schleifenausgabe falsch! Bitte 'Scannen()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_016()
        {
            Random generator = new Random();
            int anzahlDokumenteGescanned = generator.Next(101, 5000);

            // 1
            VirenScanner vs = new VirenScanner();
            vs.WertSetzen<string>("lizenzSchlüssel", "keineLIZENZ");
            vs.WertSetzen<int>("anzahlDokumenteGescanned", anzahlDokumenteGescanned);
            vs.Lizenzieren();
            Assert.IsTrue((bool)vs.WertAuslesen("virusGefunden"), "Ungültiger Wert für 'virusGefunden'. Bitte 'Lizenzieren()' kontrollieren!");

            // 2
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                anzahlDokumenteGescanned = generator.Next(10, 99);
                vs = new VirenScanner();
                vs.WertSetzen<string>("lizenzSchlüssel", "keineLIZENZ");
                vs.WertSetzen<int>("anzahlDokumenteGescanned", anzahlDokumenteGescanned);
                vs.Lizenzieren();

                StringBuilder sb = new StringBuilder();
                for (int i = anzahlDokumenteGescanned; i > 0; i--)
                {
                    sb.AppendLine(vs.WertAuslesen("lizenzSchlüssel").ToString());
                }
                Assert.IsTrue(sw.ToString() == sb.ToString(),
                    string.Format("Schleifenausgabe bei lizenzSchlüssel '{0}', anzahlDokumenteGescanned '{1}' falsch!\nBitte 'Lizenzieren()' kontrollieren!",
                                vs.WertAuslesen("lizenzSchlüssel"), vs.WertAuslesen("anzahlDokumenteGescanned")));
            }

            // 3
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                anzahlDokumenteGescanned = generator.Next(109, 999);
                vs = new VirenScanner();
                vs.WertSetzen<string>("lizenzSchlüssel", "asdf");

                vs.WertSetzen<int>("anzahlDokumenteGescanned", anzahlDokumenteGescanned);
                vs.Lizenzieren();

                StringBuilder sb = new StringBuilder();
                for (int i = anzahlDokumenteGescanned; i > 0; i--)
                {
                    sb.AppendLine(vs.WertAuslesen("lizenzSchlüssel").ToString());
                }
                Assert.IsTrue(sw.ToString() == sb.ToString(),
                    string.Format("Schleifenausgabe bei lizenzSchlüssel '{0}', anzahlDokumenteGescanned '{1}' falsch!\nBitte 'Lizenzieren()' kontrollieren!",
                                vs.WertAuslesen("lizenzSchlüssel"), vs.WertAuslesen("anzahlDokumenteGescanned")));
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_017()
        {
            Lift l = new Lift();
            Random generator = new Random();
            int stockwerk = generator.Next(-10, -5);
            double minutenBetriebsZeit = 0;
            l.WertSetzen<int>("stockwerk", stockwerk);
            l.WertSetzen<double>("minutenBetriebsZeit", minutenBetriebsZeit);

            using (StringWriter sw = new StringWriter())
            {
                // actual
                Console.SetOut(sw);
                l.Fahren();

                // expected
                StringBuilder sb = new StringBuilder();
                while (stockwerk < 3)
                {
                    stockwerk++;
                    minutenBetriebsZeit += 0.5;
                    sb.AppendLine(l.WertAuslesen("wartungsIntervalle").ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(),
                    string.Format("Schleifenausgabe bei stockwerk '{0}', minutenBetriebsZeit '{1}' falsch!\nBitte 'Fahren()' kontrollieren!",
                                l.WertAuslesen("stockwerk"), l.WertAuslesen("minutenBetriebsZeit")));
                Assert.IsTrue(minutenBetriebsZeit == (double)l.WertAuslesen("minutenBetriebsZeit"),
                    "Ungültiger Wert für 'minutenBetriebsZeit'. Bitte 'Fahren()' kontrollieren!");
            }

        }

        [TestMethod]
        public void BSP1_Aufgabe_018()
        {
            Lift l = new Lift();
            Random generator = new Random();
            double minutenBetriebsZeit = generator.Next(1500, 2500);
            l.WertSetzen<double>("minutenBetriebsZeit", minutenBetriebsZeit);
            int wartungsIntervalle = 0;
            l.WertSetzen<int>("wartungsIntervalle", wartungsIntervalle);

            using (StringWriter sw = new StringWriter())
            {
                // actual
                Console.SetOut(sw);
                l.Warten();

                // expected
                StringBuilder sb = new StringBuilder();
                while (minutenBetriebsZeit > 25)
                {
                    minutenBetriebsZeit -= 7.5;
                    wartungsIntervalle++;

                    sb.AppendLine(wartungsIntervalle.ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(),
                    string.Format("Schleifenausgabe falsch!\nBitte 'Warten()' kontrollieren!"));
                Assert.IsTrue(minutenBetriebsZeit == (double)l.WertAuslesen("minutenBetriebsZeit"), "Ungültiger Wert für 'minutenBetriebsZeit'. Bitte 'Warten()' kontrollieren!");
            }

        }

        [TestMethod]
        public void BSP1_Aufgabe_019()
        {
            Waage w = new Waage();
            Random generator = new Random();
            int anzahlProdukte = generator.Next(10, 100);
            w.WertSetzen<int>("anzahlProdukte", anzahlProdukte);
            double abweichung = generator.Next(1, 10) / 10;
            w.WertSetzen<double>("abweichung", abweichung);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                w.Kalibrieren();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < anzahlProdukte; i++)
                {
                    abweichung -= 0.05;
                    sb.AppendLine(abweichung.ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(),
                   string.Format("Schleifenausgabe bei anzahlProdukte '{0}' falsch!\nBitte 'Kalibrieren()' kontrollieren!",
                               w.WertAuslesen("anzahlProdukte")));
                Assert.IsTrue((bool)w.WertAuslesen("kalibriert"),
                    "Ungültiger Wert für 'kalibriert'. Bitte 'Kalibrieren()' kontrollieren!");
                Assert.AreEqual((double)w.WertAuslesen("abweichung"), abweichung,
                    "Ungültiger Wert für 'abweichung'.Bitte 'Kalibrieren()' kontrollieren!");
            }
        }

        [TestMethod]
        public void BSP1_Aufgabe_020()
        {
            Waage w = new Waage();
            Random generator = new Random();
            int anzahlProdukte = generator.Next(10, 100);
            w.WertSetzen<int>("anzahlProdukte", anzahlProdukte);
            double abweichung = 0;
            w.WertSetzen<double>("abweichung", abweichung);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                w.Wiegen();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < anzahlProdukte; i++)
                {
                    abweichung += 0.02;
                    sb.AppendLine(abweichung.ToString());
                }

                Assert.IsTrue(sw.ToString() == sb.ToString(),
                   string.Format("Schleifenausgabe bei anzahlProdukte '{0}' falsch!\nBitte 'Wiegen()' kontrollieren!",
                               w.WertAuslesen("anzahlProdukte")));
                Assert.IsTrue(!(bool)w.WertAuslesen("kalibriert"),
                    "Ungültiger Wert für 'kalibriert'. Bitte 'Kalibrieren()' kontrollieren!");
                Assert.AreEqual((double)w.WertAuslesen("abweichung"), abweichung,
                    "Ungültiger Wert für 'abweichung'.Bitte 'Kalibrieren()' kontrollieren!");
            }
        }
    }
}
