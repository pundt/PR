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

                for (int i = kapseln; i > 0; i-=2)
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

        }

        [TestMethod]
        public void BSP1_Aufgabe_016()
        {

        }

        [TestMethod]
        public void BSP1_Aufgabe_017()
        {

        }

        [TestMethod]
        public void BSP1_Aufgabe_018()
        {

        }

        [TestMethod]
        public void BSP1_Aufgabe_019()
        {

        }

        [TestMethod]
        public void BSP1_Aufgabe_020()
        {

        }
    }
}
