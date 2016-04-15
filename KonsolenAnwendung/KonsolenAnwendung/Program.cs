using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Notwendige Vorkenntnisse
///     - Datentypen (vgl. dazu https://github.com/pundt/PR/tree/master/Variablen)
///     - Variablen (vgl. dazu https://github.com/pundt/PR/tree/master/Variablen)
///     - Methoden(vgl. dazu https://github.com/pundt/PR/tree/master/Methoden)
///     
/// Empfohlen
///     - Objekt-Orientierung (vgl. dazu https://github.com/pundt/PR/tree/master/ObjektOrientierung)


namespace KonsolenAnwendung
{
    /// Die Konsole (auch Kommandozeile) genannt, ist eine einfache graphische Oberfläche die 
    /// textbasiert arbeitet! Ein- und Ausgaben erfolgen ausschließlich auf Text-Ebene. 
    /// 
    /// Diese Tatsache macht die Kommandozeile zu einem beliebten Einstiegspunkt 
    /// beim Erlernen einer Programmiersprache.
    /// 
    /// In C# wird die Steuerung der Console (hauptsächlich) mit einer einzigen
    /// Klasse geregelt - Console (vgl. dazu https://msdn.microsoft.com/de-de/library/system.console(v=vs.110).aspx). 
    ///

    class Program
    {
        static void Main(string[] args)
        {
            #region Auf der Kommandozeile ausgeben
            /// Zum Ausgeben von Werten auf der Console kennen wir in C#
            /// die statischen Methoden WriteLine(..) und Write(..).
            /// Diese Methoden sind mehrfach überladen und unterstützen damit die Ausgabe
            /// von nahezu jedem möglichen Datentyp auf der Console.
            Console.WriteLine("Ausgaben mit Console.WriteLine");
            Console.WriteLine("hallo Welt");
            Console.WriteLine(123);
            Console.WriteLine(123.45);
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine('c');

            /// natürlich kann die Ausgabe auch mittels Write(..) erfolgen. Dabei ist zu be-
            /// achten, dass der Cursor nach erfolgter Ausgabe in der selben Zeile verbleibt.
            Console.WriteLine("Ausgaben mit Console.Write");
            Console.Write("hallo ");
            Console.WriteLine("welt");

            /// Steuerzeichen
            /// Bei der Ausgabe von Zeichenketten, können mit speziellen Zeichenketten
            /// (auch Steuerzeichen und Escapesequenzen genannt) unterschiedliche Effekte erzeugt werden
            /// \t      TabStop
            /// \n      newLine - neue Zeile
            /// \r      carriage return, Wagenrücklauf
            /// 
            /// eine komplette Auflistung aller Escapesequenzen kann unter
            ///     https://msdn.microsoft.com/de-de/library/ms228362.aspx#Anchor_4
            /// gefunden werden.
            /// 
            /// In manchen Fällen ist die Verwendung von Escapesequenzen NICHT gewünscht
            /// zB. bei Pfadangaben. Mit einem vorangestellten @ können in diesem Fall 
            /// wie gewohnt Pfade mit \ gemacht werden.
            /// 
            /// Sind Pfadangaben UND Escapesequenzen verwenden wir \\ für die
            /// Verzeichnisstruktur
            Console.WriteLine("Escapesequenzen");
            Console.WriteLine("\tTabStop");
            Console.WriteLine("\n\nNeue Zeile\n");
            Console.WriteLine(@"c:\programme\windows");
            Console.WriteLine("c:\\windows\t ist der  Pfad von Windows");

            /// Sprache/Kultur Einstellungen
            /// Die Ausgabe auf der Kommandozeile findet natürlich unter den aktuellen 
            /// Sprach- und Ländereinstellungen statt. 
            /// 
            /// Zusätzlich bestimmt auch der Zeichensatz wie Zeichen auf der Kommandozeile
            /// dargestellt werden!
            /// 
            /// Der Ausgabezeichensatz kann durch OutputEncoding festgelegt werden.
            ///     (Details dazu unter: https://msdn.microsoft.com/en-us/library/system.console.outputencoding(v=vs.110).aspx#Anchor_2)

            Console.WriteLine("Sprach/Kultur Einstellungen");
            Console.WriteLine("\tAusgabe eine Gleitkomma-Zahl (System Sprach-/Ländereinstellungen): " + 9.55);
            Console.WriteLine("\tDas Euro Symbol € (default OutputEncoding)");
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\tDas Euro Symbol € (Unicode Encoding)");

            /// Die Sprach-/Ländereinstellungen können natürlich über das System
            /// aber auch im .Net Framework selbst verändert werden.
            /// 
            /// Das Thema Globalization und deren Bedeutung ist jedoch zu umfangreich
            /// als es hier ausreichend behandeln zu können!
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("\tAusgabe eine Gleitkomma-Zahl (en-US Sprach-/Ländereinstellungen): " + 9.55);
            #endregion

            #region Von der Kommandozeile einlesen
            /// Das Einlesen von der Kommandozeile wird über die Befehle
            ///     Read() und ReadLine() 
            /// durchgeführt.
            /// 
            /// Console.Read() liest einzelne Zeichen vom Standard-Eingabestrom
            /// Console.ReadLine() liest eine Zeile vom Standard-Eingabestrom ein
            /// 

            /// Read() liest das nächste Zeichen ein.
            Console.Write("Ihre Eingabe: ");
            int zeichenWert = Console.Read();

            /// Die Methode Read() blockiert allerdings, bis die Eingabe mit ENTER abgeschlossen wird.
            /// Werden mehrere Zeichen eingegeben, können diese mit erneuten Aufrufen von Read() 
            /// eingelesen werden.

            Console.WriteLine("OutputEncoding: " + Console.OutputEncoding);
            Console.WriteLine("Zeichenwert: " + zeichenWert);

            /// Die Methode ReadLine() liest eine ganze Zeile vom Eingabestrom ein.
            Console.WriteLine("Ihre Eingabe: ");
            string zeile = Console.ReadLine();
            Console.WriteLine(zeile);

            #endregion
        }
    }
}
