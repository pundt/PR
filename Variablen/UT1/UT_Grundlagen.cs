using System;
using BSP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace UT1
{
    [TestClass]
    public class UT_Grundlagen
    {
        [TestMethod]
        public void Aufgabe_1()
        {
            Person p = new Person();
            Type t = p.GetType();
            FieldInfo fiAlter = t.GetField("alter", BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.IsTrue(fiAlter != null, "Die Variable \"alter\" fehlt!");
            Assert.IsTrue(fiAlter.FieldType == typeof(int), "Die Variable \"alter\" muss den Datentyp \"Integer\" haben");
        }

        [TestMethod]
        public void Aufgabe_2()
        {
            Person p = new Person();
            p.Initialisieren();

            Assert.IsTrue((int) p.AlterAuslesen() > 0 && (int) p.AlterAuslesen() < 150, "Der Wert für die Variable \"alter\" ist ungültig");
        }
    }
}
