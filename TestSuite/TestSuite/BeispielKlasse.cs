using System;
using System.Reflection;

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
            return fi.GetValue(this);
        }
        #endregion
    }
}
