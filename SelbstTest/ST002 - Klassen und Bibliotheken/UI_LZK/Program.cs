using BL_LZK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_LZK
{
class Program
{
    static void Main(string[] args)
    {
        /// TODO Aufgabe 006 - Pfad zuweisen - (1 Punkte)
        /// Im Projekt BL_LZK befindet sich eine Datei 'touren.csv'
        /// Kopieren Sie diese Datei an einen beliebigen Ort 
        /// auf Ihrem Computer auf den Sie Zugriff haben.
        /// 
        /// Anschließend tragen Sie den Pfad zur Datei 
        /// bei der Variable 'pfad' ein.
        string pfad = @"c:\touren.csv";

        TourManagement tourManagement = new TourManagement(pfad);
        tourManagement.Importieren();


        /// TODO Aufgabe 007 - Testaufruf I - (2 Punkte)
        /// Rufen Sie die Methoden Buchen(..) einmal mit beliebigen
        /// Werten auf
            
    }
}
}
