using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public class Computer : BeispielKlasse
    {
        double ghz;
        int speicherplatzInMB;
        string bezeichnung;

        public void Aufrüsten()
        {
            /// TODO - Aufgabe 001 - Verzweigung einfach
            ///     Wenn der Wert von ghz größer ist als 4, soll dieser um 5 erhöht werden.

        }

        public void SpeicherErweitern()
        {
            /// TODO - Aufgabe 002 - Verzweigung einfach
            ///     Wenn der Wert von speicherplatzInMB größer ist als 10000, soll dieser verdoppelt werden
            ///     Ist der Wert größer als 15000 - soll er vervierfacht werden
            ///     in allen  anderen Fällen soll der Wert mal verdreifacht gerechnet werden

        }
    }

    public class Spieler : BeispielKlasse
    {
        string name;
        int anzahlGelbeKarten;
        int anzahlRoteKarten;
        bool gesperrt;

        public void eintrittGruppenPhase()
        {
            /// TODO - Aufgabe 003 - Verzweigung mit Verknüpfung
            ///     Wenn ein Spieler mehr als 10 Gelbe Karten oder zumindest eine rote Karte hat ist er gesperrt
            ///     ansonsten eben nicht

        }

        public void eintrittFinalSpiele()
        {
            /// TODO - Aufgabe 004 - Verzweigung mit Verknüpfung
            ///     Beim Eintritt in die Finalspiele werden die Roten-Karten auf 0 zurückgesetzt.
            ///     Wenn der Spieler mehr als 5 gelbe Karten hat, werden ihm davon 5 abgezogen
            ///     Wenn er allerdings gleich bzw. weniger als 5 Karten hat werden auch diese auf 0 zurückgesetzt.

        }
    }

    public class Handy : BeispielKlasse
    {
        string nummer;
        int anzahlSMS;
        int anzahlMegaByte;
        string tarif;
        double kostenSMS;
        double kostenMegaByte;
        double gesamtKosten;

        public void tarifWechsel()
        {
            /// TODO - Aufgabe 005 - Verzweigung komplex
            ///     Wenn der tarif "mini" ist sollen die kostenSMS auf 0.2, und kostenMegaByte auf 0.35 gesetzt werden
            ///     bei "midi" sollen die kostenSMS auf 0.16, und kostenMegaByte auf 0.33 gesetzt werden
            ///     bei "maxi" sollen die kostenSMS auf 0.14, und kostenMegaByte auf 0.3 gesetzt werden

        }

        public void autoTarifWahl()
        {
            /// TODO - Aufgabe 006 - Verzweigung komplex
            ///     bei mehr als 20 SMS oder mehr als 1000 anzahlMegaByte soll der tarif auf "mini" gesetzt werden 
            ///     bei mehr als 50 SMS oder mehr als 1500 anzahlMegaByte soll der tarif auf "midi" gesetzt werden
            ///     bei mehr als 100 SMS UND mehr als 2000 anzahlMegaByte soll der tarif auf "maxi" gesetzt werden

        }
    }

    public class Dokument : BeispielKlasse
    {
        string dateiTyp;
        bool geschützt;
        int anzahlBytes;

        public void schützen()
        {
            /// TODO - Aufgabe 007 - Verzweigung komplex
            ///     wenn der dateiTyp gleich ".exe" ist soll das Dokument geschützt (also true) sein
            ///     wenn der dateiTyp gleich ".bat" ist UND anzahlBytes > 5000 ist,  soll das Dokument geschützt (also true) sein
            ///     in allen anderen Fällen soll geschützt false sein

        }

        public void entsperren()
        {
            /// TODO - Aufgabe 008 - Verzweigung komplex
            ///     wenn geschützt true ist - soll der Dateityp auf ".locked" gesetzt werden und anzahlBytes um 120 erhöht werden.
            ///     wenn geschützt false ist - soll der Dateityp auf ".unlocked" gesetzt werden und anzahlBytes um 50 verringert werden.

        }
    }

    public class Wohnung : BeispielKlasse
    {
        string adresse;
        int anzahlM2;
        bool balkon;
        double preis;
        int plz;

        public void preisBerechnen()
        {
            /// TODO - Aufgabe 009 - Verzweigung komplex
            ///     Wohnungen deren anzahlM2 größer ist als 100 haben einen preis von 1000.
            ///     Wohnungen deren anzahlM2 größer ist als 100 UND die einen balkon (=true) haben, haben einen preis von 1300.

            ///     Wohnungen deren anzahlM2 größer ist als 75 haben einen preis von 800.
            ///     Wohnungen deren anzahlM2 größer ist als 75 UND die einen balkon (=true) haben, haben einen preis von 1100.

            ///     Wohnungen deren anzahlM2 größer ist als 50 haben einen preis von 500.
            ///     Wohnungen deren anzahlM2 größer ist als 50 UND die einen balkon (=true) haben, haben einen preis von 650.

        }

        public void umbauen()
        {
            /// TODO - Aufgabe 010 - Verzweigung komplex
            ///     Wenn die Adresse "A-1030" ist, soll balkon auf true und der preis auf 800 gesetzt werden.
            ///     Wenn die Adresse "A-1050" ist, soll balkon auf false und der preis auf 700 gesetzt werden.
            ///     Wenn die Adresse "A-1070" ist und die anzahlM2 kleiner als 90, soll balkon auf true gesetzt und der preis 1200 gesetzt werden.

        }
    }
}
