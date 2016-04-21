using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSuite;
using BL_LZK;
using System.Collections.Generic;
using System.IO;

namespace UT_LZK
{
    [TestClass]
    public class BL_LZK
    {
        [TestMethod]
        public void UT_Aufgabe_001()
        {
            Programmieren.PrüfeFeld(typeof(Analyzer), "urls", typeof(List<string>));
        }

        [TestMethod]
        public void UT_Aufgabe_002()
        {
            Analyzer a = new Analyzer();
            Programmieren.PrüfeMethode<bool>(a, "AddURL", new object[] { "http://test.bbconsulting.at" }, x => x);
            Programmieren.PrüfeMethode<bool>(a, "AddURL", new object[] { "http://test.bbconsulting.at" }, x => !x);

            Programmieren.PrüfeMethode<bool>(a, "AddURL", new object[] { "http://www.pundt.at" }, x => x);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            int numberOfHtmlFiles_before = new DirectoryInfo(path).GetFiles("*.html").Length;

            a.Analyze();

            int numberOfHtmlFiles_after = new DirectoryInfo(path).GetFiles("*.html").Length;

            Assert.IsTrue(numberOfHtmlFiles_before < numberOfHtmlFiles_after, "Es wurden keine HTML Dokumente am Desktop generiert!");
            Assert.IsTrue(numberOfHtmlFiles_before + 2 == numberOfHtmlFiles_after, "Die Anzahl der erzeugten HTML-Dateien stimmt nicht!");

        }

        [TestMethod]
        public void UT_Aufgabe_003()
        {
            Analyzer a = new Analyzer();
            a.AddURL("http://test.bbconsulting.at");
            a.AddURL("http://www.pundt.at");

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo desktopInfo = new DirectoryInfo(path);
            int numberOfHtmlFiles_before = desktopInfo.GetFiles("*.html").Length;

            a.Analyze();

            int numberOfHtmlFiles_after = desktopInfo.GetFiles("*.html").Length;

            Assert.IsTrue(numberOfHtmlFiles_before < numberOfHtmlFiles_after, "Es wurden keine HTML Dokumente am Desktop generiert!");
            Assert.IsTrue(numberOfHtmlFiles_before + 2 == numberOfHtmlFiles_after, "Die Anzahl der erzeugten HTML-Dateien stimmt nicht!");
        }
    }
}
