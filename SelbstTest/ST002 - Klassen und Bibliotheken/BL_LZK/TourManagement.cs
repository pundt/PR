
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_LZK
{
    public class TourManagement
    {
        /// TODO Aufgabe 002 - Feld erstellen - (2 Punkte)
        /// Erstellen Sie eine Feld 'manager' vom Typ DataManagement
        /// Diese Klasse befindet sich im Projekt BL_pundt.


        public readonly List<Tour> touren = new List<Tour>();

        public TourManagement(string pfad)
        {
            /// TODO Aufgabe 003 - Konstruktor implementieren - (2 Punkte)
            /// Weisen Sie dem Feld 'manager' ein neues Objekt zu. 
            /// 
            /// Verwenden Sie dazu auch den pfad-Übergabeparameter im Konstruktor



        }


        /// TODO Aufgabe 004 - Methode Buchen - (6 Punkte)
        /// Die Methode Buchen(...) soll beim Aufruf 
        /// ein neues Tour Objekt erstellen und dieses im Anschluss
        /// in die Liste 'touren' geben.
        /// 
        /// Achten Sie darauf, dass sich maximal 100 Tour-Objekte
        /// in der touren-Liste befinden dürfen!
        /// 
        /// Die Methode gibt true zurück wenn das Hinzufügen erfolgreich war
        /// ansonsten wird false zurück gegeben
        public bool Buchen(string name, double preis)
        {

            return false;
        }

        /// TODO Aufgabe 005 - Methode Importieren - (15 Punkte)
        /// Importieren() ruft vom 'manager' die Methode ReadCSV()
        /// auf. 
        /// 
        /// Der Rückgabewert von ReadCSV() beinhaltet eine Liste von Tourdaten.
        /// Jeder Tourdatensatz besteht dabei aus NAME;PREIS
        /// 
        /// Teilen Sie jeden Tourdatensatz auf und rufen Sie für jeden
        /// die Methode Buchen(..) auf.
        public void Importieren()
        {

        }
    }
}
