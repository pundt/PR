using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Notwendige Vorkenntnisse
///     - Datentypen (vgl. dazu https://github.com/bbrzWien/PR/tree/master/Variablen)
///     - Variablen (vgl. dazu https://github.com/bbrzWien/PR/tree/master/Variablen)

namespace Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Verzweigungen bilden zusammen mit Schleifen die möglichen Kontrollstrukturen
            /// in den meisten gängigen Programmiersprachen. Anhand solcher Strukturen
            /// wird in Programmen entschieden welche Befehle und wenn, in welcher Reihenfolge
            /// ausgeführt werden.

            /// Eine Verzweigung prüft ob eine Bedingung eintritt.
            /// Ist dies der Fall wird maximal 1 (Programm-)Zweig betreten, ansonsten nicht.

            /// Bedingungen ergeben immer einen boolschen Wert - können also auch
            /// durch einen solchen ersetzt werden.

            /// Grundstrukur
            /// if (WAHRHEITSWERT) {         
            ///     TRUE_Teil
            /// } 

            /// Einfache Verzweigung - Grundstruktur 1
            ///     dieser Zweig wird JEDESMAL betreten, da die Bedingung IMMER true liefert
            Console.WriteLine("Einfache Verzweigung - Grundstruktur 1");
            if (true)
            {
                Console.WriteLine("TRUE Teil");
            }
            Console.WriteLine();

            /// Einfache Verzweigung - Grundstruktur 2
            ///     dieser Zweig wird hingegen nur dann betreten wenn anzahlHaareHomerSimpson größer ist als 5
            Console.WriteLine("Einfache Verzweigung - Grundstruktur 2");
            int anzahlHaareHomerSimpson = 10;
            if (anzahlHaareHomerSimpson > 5)
            {
                Console.WriteLine("Homer Simpson hat mehr als 5 Haare");
            }
            Console.WriteLine();

            /// Die Grundstruktur KANN um (genau) einen (1!) else-Zweig erweitert werden.
            /// Dieser wird dann betreten, wenn kein anderer Zweig betreten wurde
            /// IF (WAHRHEITSWERT) {
            ///     TRUE_Teil)
            /// } 
            /// else 
            /// {
            ///     FALSE_TEIL bzw. Teil der immer dann betreten wird, wenn zuvor kein 
            ///     anderer Zweig  betreten wurde.
            /// }
            Console.WriteLine("Verzweigung - if und else");
            int anzahlBücher = 27;
            if (anzahlBücher > 50)
            {
                Console.WriteLine("mehr als 50 bücher - LESERATTE");
            }
            else
            {
                Console.WriteLine("NICHT mehr als 50 Bücher - Bücherwurm");
            }
            Console.WriteLine();

            /// Die Grundstruktur KANN um beliebig viele else if-Zweige erweitert werden.
            /// Diese werden ebenfalls nur betreten wenn die entsprechende Bedingung zutritt
            /// 
            /// Werden mehrere Zweige hinter einander geschaltet muss man sich bewusst sein, dass 
            /// MAXIMAL EIN Zweig betreten werden kann. 
            /// 
            /// Dh. der erste Zweig bei dem die Bedingung zutrifft wird betreten. 
            /// Danach wird die Kontrollstruktur beendet.
            Console.WriteLine("Verzweigung - if, else if und else");
            int liter = 10;
            if (liter > 20)
            {
                Console.WriteLine("mehr als 20 Liter");
            }
            else if (liter > 10)
            {
                Console.WriteLine("mehr als 10 liter");
            }
            else if (liter > 5)
            {
                Console.WriteLine("mehr als 5 liter");
            }
            else
            {
                Console.WriteLine("alle anderen fälle - also gleicher, oder weniger als 5 Liter");
            }
            Console.WriteLine();


            /// Werden nun mehrere Zweige hinter einander geschaltet ist somit die Reihenfolge
            /// der Prüfungen besonders wichtig.
            ///
            /// Betrachtet man das obige Beispiel mit einer anderen Reihenfolge
            /// ergibt sich ein gänzlich anderes Bild!!
            
            /// Anmerkung: liter hat noch immer den Wert 10
            Console.WriteLine("Verzweigung - if, else if und else -  REIHENFOLGE!");
            if (liter > 5)  /// nun wird auf einmal dieser Zweig betreten!!
            {
                Console.WriteLine("mehr als 5 Liter");
            }
            else if (liter > 10)    // ganz egal welchen Wert liter hätte, dieser Zweig wird NIE betreten
            {
                Console.WriteLine("mehr als 10 liter");
            }
            else if (liter > 20)    // ganz egal welchen Wert liter hätte, dieser Zweig wird NIE betreten
            {
                Console.WriteLine("mehr als 20 liter");
            }
            else
            {
                Console.WriteLine("alle anderen Fälle - also gleich, oder weniger als 5 Liter");
            }
            Console.WriteLine();


            /// Neben der Verzweigung mit dem Schlüsselwort if gibt es in C# noch eine weitere
            /// Möglichkeit um eine Verzweigung abzubilden - das SWITCH. 
            /// 
            /// das Switch-Konstrukt ist mit einem Schalter vergleichbar. Dieser prüft zu
            /// Beginn welchen Status/Wert eine Variable hat, und "springt" im Anschluss
            /// direkt auf die entsprechende Position.

            /// Grundstrukur
            /// switch (VARIABLE) {         
            ///     case WERT1:
            ///         beliebig viele Anweisungen
            ///         break;
            ///     case WERT2:
            ///         beliebig viele Anweisungen
            ///         break;
            ///     default:
            ///         beliebig viele Anweisungen
            ///         break;
            /// } 

            /// Folgende Regeln sind zu befolgen:
            ///     + zumindest ein Zweig verfügen 
            ///     + jeder Zweig muss mit break; abgeschlossen werden
            ///     + es gibt maximal einen default Zweig - dieser entspricht dem else aus dem if Konstrukt

            int anzahlTore = 4;
            switch (anzahlTore)
            {
                case 0:
                    Console.WriteLine("Kein Tor gefallen");
                    break;
                case 1:
                    Console.WriteLine("Ein Tor ist besser als gar keins");
                    break;
                case 2:
                    Console.WriteLine("Schön langsam wirds ja...");
                    break;
                case 3:
                    Console.WriteLine("HATTRICK!");
                    break;
                case 4:
                    Console.WriteLine("Schützenfest");
                    break;
                default:
                    Console.WriteLine("entweder weniger als 0 Tore oder mehr als 4 Tore");
                    break;
            }


            /// Im Unterschied zum If kann die Switch-Kontrollstruktur nur mit den
            /// folgenden Datentypen arbeiten:
            ///     + bool
            ///     + char
            ///     + string   
            ///     + int
            ///     + enum
        }
    }
}

/// Nächste Lektionen
///     Kontrollstrukturen (Verzweigungen, Schleifen)
///     Konsole (Einlesen, Ausgeben)
///     Wahrheitswerte (true|false, Aussagenlogik)
/// 
/// Weiterführende Ressourcen
///     if-else Referenz (https://msdn.microsoft.com/de-de/library/5011f09h.aspx)
///     switch Referenz (https://msdn.microsoft.com/de-de/library/06tc147t.aspx)