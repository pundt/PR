using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Variablen Definition
            /// Eine Variable ist ein Platzhalter für einen Wert

            /// Variable anlegen
            /// DATENTYP variablenName;
            int i;
            string s;
            double d;

            /// Namensgebung
            /// Variablen sollten möglichst sprechende Namen haben
            /// dh: der Name sollte möglichst gut ausdrücken welche Werte in einer
            /// Variable gespeichert werden
            int alter;
            double kontoStand;

            /// Variablen initialisieren
            /// jede Variable sollte sofort beim Anlegen einen Start-Wert erhalten
            int anzahlHaareHomerSimpson = 5;
            double sparguthaben = 0;

            /// Variablen Speicherort
            /// Variablen werden zur Laufzeit des Programmes im Arbeitsspeicher angelegt.
            /// .net Framework Programme werden im sogenannten "managed memory" (verwalteten Speicher)
            /// abgelegt. Sämtliche Variablen eines Programmes sind also dort zu finden.
            /// 
            /// Wieviel Platz eine Variable im Arbeitsspeicher/managed memory einnimmt, bestimmt
            /// unter anderem der Datentyp (siehe Lektion Datentypen)
        }
    }
}
