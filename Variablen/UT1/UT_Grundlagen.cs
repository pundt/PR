using System;
using BSP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT1
{
    [TestClass]
    public class UT_Grundlagen
    {
        [TestMethod]
        public void Variablen_Anlegen_1()
        {
            Grundlagen g = new Grundlagen();
            object returnValue = g.variablen_anlegen_1();

            Assert.IsInstanceOfType(returnValue, typeof(int), "Falscher Datentyp für Alter - gefordert ist Integer");

            int value = (int)returnValue;
            Assert.IsTrue(value > 0 && value < 150, "Ungültiger Wert für ein Alter");
        }

        [TestMethod]
        public void Variablen_Anlegen_2()
        {
           
        }
    }
}
