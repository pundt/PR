using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace TestSuite
{
    public class Programmieren
    {
        /// <summary>
        /// Prüft ob der Typ ein privates, Instanz-Feld mit dem angegebenen Feld-Namen und Feld-Typ besitzt.
        /// Die Prüfung wird mittels Assertions-Tests durchgeführt.
        /// </summary>
        /// <param name="typ">der Typ der das Feld beinhalten soll</param>
        /// <param name="feldName">der Name des Feldes das gesucht werden soll</param>
        /// <param name="feldTyp">der Typ den das Feld haben soll</param>
        public static void PrüfeFeld(Type typ, string feldName, Type feldTyp)
        {
            FieldInfo fieldInfo = typ.GetField(feldName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                Assert.IsTrue(fieldInfo != null, string.Format("Die Variable \"{0}\" fehlt!", feldName));
                Assert.IsTrue(fieldInfo.FieldType == feldTyp, string.Format("Die Variable \"{0}\" muss den Datentyp \"{1}\" haben", feldName, feldTyp));
            }
            else
            {
                Assert.Fail(string.Format("Feld {0} wurde nicht gefunden!", feldName));
            }
        }
        /// <summary>
        /// Prüft ob ein Feld in einem Typ ein Predicate erfüllt.
        /// Die Prüfung wird mittels Assertions-Tests durchgeführt.
        /// </summary>
        /// <typeparam name="T">Der Typ des zu prüfenden Feldes</typeparam>
        /// <param name="typ">Der Typ der das Feld beinhalten soll</param>
        /// <param name="feldName">Der Name des Feldes</param>
        /// <param name="predicate">Die Routine die den Feld-Wert prüfen soll</param>
        public static void PrüfeWert<T>(Type typ, string feldName, Predicate<T> predicate)
        {
            object o = typ.GetConstructor(new Type[] { }).Invoke(new object[] { });

            MethodInfo miInitialisieren = typ.GetMethod("Initialisieren");
            if (miInitialisieren != null)
            {
                miInitialisieren.Invoke(o, null);

                MethodInfo miWertAuslesen = typ.GetMethod("WertAuslesen");

                if (miWertAuslesen != null)
                {
                    try
                    {
                        T value = (T)miWertAuslesen.Invoke(o, new object[] { feldName });
                        Assert.IsTrue(predicate.Invoke(value), string.Format("Der Wert für die Variable \"{0}\" ist ungültig", feldName));
                    }
                    catch (TargetInvocationException ex)
                    {
                        throw ex.InnerException;
                    }
                }
                else
                {
                    Assert.Fail("\"WertAuslesen\" Methode konnte nicht gefunden werden!\nBitte \"BeispielKlasse\" verwenden.");
                }
            }
            else
            {
                Assert.Fail("\"Initialisieren\" Methode konnte nicht gefunden werden.");
            }
        }

        /// <summary>
        /// Diese Methode prüft ob die Logik in einer Methode ein Feld wie geplant beeinflusst hat
        /// </summary>
        /// <typeparam name="T">der Typ für die Prüfungsroutine</typeparam>
        /// <param name="obj">die zu prüfende Instanz</param>
        /// <param name="methodenName">der Name der auszuführenden Methode</param>
        /// <param name="parameter">etwaige Parameter-Werte für die Methode</param>
        /// <param name="feldName">der Name des Feldes das geprüft werden soll</param>
        /// <param name="predicate">die Regel um festzustellen ob das Feld wie geplant beeinflusst wurde.</param>
        public static void PrüfeMethode<T>(object obj, string methodenName, object[] parameter, string feldName, Predicate<T> predicate)
        {

            Type typ = obj.GetType();
            MethodInfo methodInfo = typ.GetMethod(methodenName);
            if (methodInfo != null)
            {
                MethodInfo miWertAuslesen = typ.GetMethod("WertAuslesen");                
                if (miWertAuslesen != null)
                {
                    T originalWert = (T)miWertAuslesen.Invoke(obj, new object[] { feldName });
                    object rückgabeWert = methodInfo.Invoke(obj, parameter);

                    try
                    {
                        T neuerWert = (T)miWertAuslesen.Invoke(obj, new object[] { feldName });
                        Assert.IsTrue(predicate.Invoke(neuerWert), string.Format("Die Methode \"{0}\" liefert für das Feld \"{1}\" beim Wert \"{2}\" ein ungültiges Ergebnis", methodenName, feldName, originalWert));
                    }
                    catch (TargetInvocationException ex)
                    {
                        throw ex.InnerException;
                    }
                }
                else
                {
                    Assert.Fail("\"WertAuslesen\" Methode konnte nicht gefunden werden!\nBitte \"BeispielKlasse\" verwenden.");
                }
            }
            else
            {
                Assert.Fail("\"" + methodenName + "\" Methode konnte nicht gefunden werden.");
            }
        }
    }
}
