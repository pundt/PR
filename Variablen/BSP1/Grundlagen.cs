using TestSuite;

namespace BSP1
{
    /// Zur Überprüfung ob Sie ein Beispiel richtig gemacht haben gehen Sie wie folgt vor:
    /// 1. Öffnen Sie den entsprechenden Test (also für BSP1 -> UT1) 
    /// 2. Öffnen Sie darin die entsprechende Test-Datei (zB: UT_Grundlagen.cs)
    /// 3. Ausführen von Tests
    ///     3.1 alle Tests ausführen - rechte Maustaste in die Datei - "Tests ausführen"
    ///     3.2 einen bestimmten Test ausführen - im Test-Explorer einen Test auswählen
    ///         rechte Maustause auf den ausgewählten Test - "Ausgewählte Tests ausführen"

    /// Sie sehen das Ergebnis der Testfälle im Test-Explorer
    /// Sie können diesen jederzeit wieder über die 
    ///         Menüleiste - Test - Fenster - Text-Explorer öffnen

    public class Person : BeispielKlasse
    {
        /// TODO - Aufgabe 001: Legen Sie eine int Variable alter an
        int alter;

        public void Initialisieren()
        {
            /// TODO - Aufgabe 002: Weisen Sie der Variable alter Ihr Alter zu!
            alter = 33;
        }
    }

    public class Konto : BeispielKlasse
    {
        /// TODO - Aufgabe 003: Legen Sie eine double Variable kontoStand an

        public void Initialisieren()
        {
            /// TODO - Aufgabe 004: Weisen Sie der Variable kontoStand Ihren gewünschten Kontostand zu!

        }
    }

    public class Auto : BeispielKlasse
    {
        /// TODO - Aufgabe 005: Legen Sie eine string Variable kennzeichen und
        /// eine int Variable ps an

        public void Initialisieren()
        {
            /// TODO - Aufgabe 006: Weisen Sie kennzeichen ein Wiener Kennzeichen zu (beginnend mit W)
            /// Weisen Sie ps einen Wert zwischen 50 und 300 zu

        }
    }

    public class Haus : BeispielKlasse
    {
        /// TODO - Aufgabe 007: Legen Sie drei int Variable höhe, länge und breite an

        public void Initialisieren()
        {
            /// TODO - Aufgabe 008: Weisen Sie jeder dieser Variablen einen Wert zwischen 1 und 100 zu

        }
    }

    public class Raumschiff : BeispielKlasse
    {
        /// TODO - Aufgabe 009: Legen Sie eine bool Variable 'hatPhasor', eine int Variable 'anzahlTorpedos' und 
        /// eine string Variable 'kennung' an.

        public void Initialisieren()
        {
            /// TODO - Aufgabe 010: Legen Sie ihr persönliches Raumschiff Enterprise an.
            ///     Weisen Sie der Variable hatPhasor einen beliebigen Wert zu
            ///     Weisen Sie der Variable anzahlTorpedos eine Zahl zwischen 0 und 1999 zu.
            ///     Weisen Die der Variable 'kennung' einen Wert beginnend mit "NCC-1701" zu
            
        }
    }

    public class Dokument : BeispielKlasse
    {
        /// TODO - Aufgabe 011: Legen Sie eine string Variable 'typ', eine long Variable 'anzahlBytes' und 
        /// eine string Variable 'dokumentenName' an.

        public void Initialisieren()
        {
            /// TODO - Aufgabe 012: Excel-Dokument
            ///     Weisen Sie der Variable typ den Wert ".xlsx" zu
            ///     Weisen Sie der Variable anzahlBytes eine Zahl zwischen 10000 und 4999999 zu.
            ///     Weisen Die der Variable 'dokumentenName' einen beliebigen Wert mit mindestens fünf Zeichen zu

        }
    }
}
