using BL_pundt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_LZK
{
public class Analyzer
{
    private readonly string exportFolder;

    public Analyzer()
    {
        this.exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }

    /// TODO Aufgabe 001 - Collection erstellen - (2 Punkte)
    /// Erstellen Sie eine Liste vom Typ String mit dem Namen urls.
    /// Achten Sie darauf auch das Objekt anzulegen!!


    /// TODO Aufgabe 002 - Methode AddURL - (10 Punkte)
    /// Die Methode AddUrl(..) soll beim Aufruf die url zur Liste urls hinzufügen.
    /// Wenn die url bereits in der Liste enthalten ist, soll sie nicht nochmals 
    /// hinzugefügt werden.
    /// 
    /// Die Methode gibt true zurück wenn das Hinzufügen erfolgreich war
    /// ansonsten wird false zurück gegeben
    public bool AddURL(string url)
    {

        return false;
    }

    private string GetExportPath(WebSite webSite)
    {
        return Path.Combine(exportFolder, webSite.FileName);
    }

    /// TODO Aufgabe 003 - Methode Analyze - (15 Punkte)
    /// Die Methode Analyze() soll beim Aufruf alle vorhanden urls in der Liste
    /// durchlaufen. Für jede URL soll dabei ein Objekt der Klasse WebSite angelegt
    /// werden. Die Klasse WebSite ist im Projekt BL_pundt zu finden.
    /// 
    /// Speichern Sie von jedem angelegten WebSite Objekt den 'Content'
    /// in eine Datei. 
    /// 
    /// Um den Namen der Datei zu erhalten rufen Sie für jedes WebSite Objekt 
    /// die Methode 'GetExportPath(..)' auf.
    public void Analyze()
    {


    }
}
}
