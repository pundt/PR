using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Text;

namespace TestSuite
{
    /// <summary>
    /// Diese Klasse kann als Basis für Beispiele verwendet werden
    /// Sie bietet grundlegende Funktionen an, die von den Prüfungs-Methoden
    /// in der Programmieren-Klasse zwingend benötigt werden.
    /// </summary>
    public class BeispielKlasse
    {
        #region ÜberprüfungsMethoden
        /// <summary>
        /// Liest den Wert für das angegebene Feld aus
        /// </summary>
        /// <param name="feldName">das Feld dessen Wert ausgelesen werden soll</param>
        /// <returns>der Wert des angegebenen  Feldes</returns>
        public object WertAuslesen(string feldName)
        {
            Type t = this.GetType();
            FieldInfo fi = t.GetField(feldName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (fi != null)
                return fi.GetValue(this);
            else
                throw new AssertFailedException(string.Format("Feld {0} konnte nicht gefunden werden!", feldName));           
        }

        /// <summary>
        /// Setzt den Wert für das angegebene Feld
        /// </summary>
        /// <typeparam name="T">der Typ des Wertes</typeparam>
        /// <param name="feldName">das Feld dessen Wert gesetzt werden soll</param>
        /// <param name="wert">der neue Wert für das Feld</param>
        public void WertSetzen<T>(string feldName, T wert)
        {
            Type t = this.GetType();
            FieldInfo fi = t.GetField(feldName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (fi != null)
                fi.SetValue(this, wert);
            else
                throw new AssertFailedException(string.Format("Feld {0} konnte nicht gefunden werden!", feldName));
        }

        /// <summary>
        /// returns a string representation of the current object containing all values of every instance field
        /// </summary>
        /// <returns>string representation of the current object</returns>
        public override string ToString()
        {
            Type t = this.GetType();

            StringBuilder sbOutput = new StringBuilder();            
            
            foreach (var fieldInfo in t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (sbOutput.Length > 0)
                    sbOutput.Append(" ");
                sbOutput.Append(string.Format("\n\t{0}-'{1}'", fieldInfo.Name, fieldInfo.GetValue(this)));
            }
            sbOutput.AppendLine();
            sbOutput.AppendLine();

            sbOutput.Insert(0,string.Format("\n'{0}'", t.Name));

            return sbOutput.ToString();
        }
        #endregion
    }
}
