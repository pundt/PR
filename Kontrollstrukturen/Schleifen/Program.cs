using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Schleifen 
            /// wiederholen einen Anweisungsblock solange eine Bedingung TRUE liefert.
            /// Sobald die Bedingung FALSE liefert, wird der Anweisungsblock nicht mehr betreten.
            /// Diese Bedingung wird daher auch Abbruchbedingung genannt

            /// Aufbau einer Schleife
            /// SCHLEIFENKOPF
            ///     SCHLEIFENRUMPF/-KÖRPER
            /// SCHLEIFENFUSS

            /// Je nach dem wo sich die Abbruchbedingung befindet, spricht man von einer Kopf-
            /// oder fußgesteuerten Schleife. In der Literatur wird auch oftmals von einer
            /// Abweis (=Kopfgesteuert) oder Durchlauf (=Fußgesteuert) Schleife gesprochen

            /// Kopfgesteuerte Schleifen durchlaufen den 
            /// Schleifenrumpf 0 - n mal. Sie werden daher auch
            /// Abweisschleifen ("der Ablauf kann abgewiesen werden")
            /// genannt.

            /// Fußgesteuerte Schleifen durchlaufen den 
            /// Schleifenrumpf 1 - n mal. Sie werden daher auch
            /// Durchlaufschleifen genannt.

            /// Einfaches Beispiel - Kopfgesteuerte Schleife
            Console.WriteLine("Kopfgesteuerte Schleife");
            int anzahlDokumente =1;
            while (anzahlDokumente < 10)    /// Schleifenkopf + Abbruchbedingung
            {
                Console.WriteLine(anzahlDokumente);
                anzahlDokumente++;    /// Schleifenrumpf
            }   // Schleifenfuß

            /// Einfaches Beispiel - Fußgesteuerte Schleife
            int anzahlVersuche = 10;
            do   // Schleifenkopf
            {
                anzahlVersuche--;   // Schleifenrumpf
            } while (anzahlVersuche > 0);   /// Schleifenfuß - Abbruchbedingung

            /// Spezielle Kopfgesteuerte Schleife - FOR- oft auch "Zählschleife" genannt
            /// for (VARIABLE = STARTWERT; BEDINGUNG/WAHRHEITSWERT; AKTION_NACH_SCHLEIFENDURCHLAUF)
            /// {
            ///     ANWEISUNGSBLOCK
            /// }
            for (int anzahlTeilnehmer = 0; anzahlTeilnehmer < 20; anzahlTeilnehmer++)
            {
                Console.WriteLine(anzahlTeilnehmer);
            }

            /// Die for-Schleife wird meist mit Zahlen-Datentypen verwendet.
            /// Sie kann jedoch auch ohne weiteres mit anderen Datentyp ver-
            /// wendet werden.
            for (string kürzel = "a"; kürzel != "aaaa"; kürzel = kürzel + "a")
            {
                Console.WriteLine(kürzel);
            }
        }
    }
}
