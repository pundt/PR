using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSuite;

namespace BSP2
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


    /////////////////////////////////////////////////////////////////////////////////////////
    /// WICHTIGER HINWEIS - sämtliche Ausgaben sind mit Console.WriteLine(...) zu machen! ///
    /////////////////////////////////////////////////////////////////////////////////////////


    public class KaffeeMaschine : BeispielKlasse
    {
        int kapselnVorhanden = 100;
        bool mussEntkalktWerden = true;
        
        public void KaffeeMachen()
        {
            /// TODO - Aufgabe 011 - Schleife einfach
            /// solange kapselnVorhanden größer ist als 50, soll 
            ///     die Anzahl der vorhandenen Kapseln ausgegeben werden
            ///     im Anschluss die anzahl der vorhandenen Kapseln um 1 reduziert werden.


        }

        public void Rücksetzen()
        {
            /// TODO - Aufgabe 012 - Schleife einfach
            /// Solange kapselnVorhanden größer als 0 ist
            ///     geben Sie immer wieder mussEntkalktWerden aus
            ///     und verringern Sie kapselnVorhanden um 2
            /// 
            /// nach der Schleife setzen Sie mussEntkalktWerden auf false

        }
    }

    public class Drucker : BeispielKlasse
    {
        int dokumenteInWarteschlange = 5;
        bool IstSauber = true;
        double tintenStand = 0.2;

        public void Drucken()
        {
            /// TODO - Aufgabe 013 - Schleife einfach
            /// Solange dokumenteInWarteschlange > 0 sind,
            ///     soll der Wert um 1 verringert werden.
            ///     und der Wert von dokumenteInWarteschlange ausgegeben werden
            /// 
            /// setzen sie nach der Schleife IstSauber auf false


        }

        public void Reinigen()
        {
            /// TODO - Aufgabe 014 - Schleife einfach
            ///     Setzen Sie IstSauber auf true;
            ///     Solange tintenStand kleiner als 1 ist
            ///         soll der tintenStand immer um 0.05 erhöht werden
            ///         geben Sie dabei jedesmal den tintenStand aus

        }
    }

    public class VirenScanner : BeispielKlasse
    {
        int anzahlVirenGefunden = 0;
        int anzahlDokumenteGescanned = 0;
        int anzahlDokumenteInQuarantäne = 0;
        string lizenzSchlüssel = "";

        public void Scannen()
        {
            /// TODO - Aufgabe 015 - Schleife einfach
            ///     Zählen Sie mit einer Schleife von 1000 bis 15138 in 1er Schritten.
            ///     Erhöhen Sie bei jedem Schleifendurchlauf anzahlDokumenteGescanned um eins

        }
        public void Lizenzieren()
        {
            /// TODO - Aufgabe 016 - Schleife einfach
            ///     Zählen Sie mit einer Schleife von 94671 bis 12874 in -1er Schritten.
            ///     Erhöhen Sie bei jedem Schleifendurchlauf anzahlDokumentInQuarantäne um 3 

        }
    }

    public class Lift : BeispielKlasse
    {
        int stockwerk = -3;
        string hersteller = "";
        double minutenBetriebsZeit = 0;
        int wartungsIntervalle = 0;

        public void Fahren()
        {
            /// TODO - Aufgabe 017 - Schleife einfach
            /// Erhöhen Sie Stockwerk schrittweise immer um 1 bis +3 erreicht wurde.
            ///     Dabei soll jedesmal die MinutenBetriebsZeit um 0.5 erhöht werden.


        }
        public void Warten()
        {
            /// TODO - Aufgabe 018 - Schleife einfach
            /// Setzen Sie minutenBetriebsZeit auf 1575
            /// Solange minutenBetriebsZeit größer ist als 25 verringern Sie diesen Wert um 7.5
            ///     Erhöhen Sie bei jedem Schleifendurchlauf wartungsIntervalle um 1

        }
    }

    public class Waage : BeispielKlasse
    {
        bool kalibriert = false;
        double abweichung = 10;
        int anzahlProdukte = 48;

        public void Kalibrieren()
        {
            /// TODO - Aufgabe 019 - Schleife einfach
            /// Zählen Sie in einer Schleife von 0 bis exklusive anzahlProdukte.
            ///     Bei jedem Durchlauf soll abweichung um 0.05 verringert werden.
            /// 
            /// Nach der Schleife ist kallibriert auf true zu setzen.
            Console.WriteLine("asdf");
        }
        public void Wiegen()
        {
            /// TODO - Aufgabe 020 - Schleife einfach
            /// Setzen Sie abweichung auf 0
            /// Wiegen Sie 10 Produkte.
            /// Bei jedem Abwiege-Vorgang soll abweichung um 0.02 erhöht werden
            /// 
            /// nach der Schleife ist kallibriert auf false zu setzen.

        }
    }
}
