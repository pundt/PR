using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Notwendige Vorkenntnisse
///     - Datentypen (vgl. dazu https://github.com/pundt/PR/tree/master/Variablen)
///     - Variablen (vgl. dazu https://github.com/pundt/PR/tree/master/Variablen)
///     - Kontrollstrukturen (vgl. dazu https://github.com/pundt/PR/tree/master/Kontrollstrukturen)

namespace Methoden
{
    /// Eine Methode ist ein Teil eines Programmes/ein Unterprogramm
    /// das einmal definiert wird, und über den Namen der Methode
    /// beliebig oft aufgerufen werden kann.
    /// 
    /// Beim Aufruf einer Methode "springt" der Programmablauf zur Definition,
    /// durchläuft diese, und kehrt im Anschluss wieder dorthin zurück
    /// von wo aus die Methode aufgerufen wurde.
    /// 
    /// Durch Methoden gelingt es uns in der Software-Entwicklung
    /// Programme zu gliedern, wieder verwendbar und erweiterbar zu machen.
    ///
    /// Jeder Methodenaufruf wird auf dem Aufrufstapel abgelegt. Wenn eine Methode
    /// abgearbeitet wurde, wird dieser Aufruf wieder vom Stapel entfernt.
    /// Sind keine Methoden mehr am Aufrufstapel vorhanden beendet das Programm.
    /// Der Aufrufstapel arbeitet nach dem Last-In-First-Out (LiFo) Prinzip und
    /// wird deshalb auch STACK genannt.

    public class Auto
    {
        double tank = 75;
        double verbrauch = 5.9;
        int kmStand = 0;
        string kennzeichen = "";

        /// Methodendefinition I
        ///     (stark vereinfacht)
        /// public void METHODEN_NAME()
        /// {
        ///     METHODEN_KÖRPER
        /// }
        public void tanken()
        {
            tank += 10;
        }

        /// Methodendefinition II
        public void fahren()
        {
            kmStand += 100;

            if (tank - verbrauch <= 0)
            {
                /// Methodenaufruf
                ///     METHODEN_NAME();
                tanken();
            }
        }
    }
}
