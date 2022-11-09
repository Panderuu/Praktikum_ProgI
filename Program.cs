using System;

namespace Autorennen;

class main
{
    //Deklarieren von Variablen
    static int posComp = 0;
    static int posSpieler = 0;
    static int auto;
    static string strgAuto = "";
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Willkommen beim Autorennspiel");
        Console.WriteLine("Gib deinen Namen an: ");
        string name = Console.ReadLine();
        Console.WriteLine($"\nHallo, {name}. Wähle dein Rennauto und mach dich bereit.\n");
        //Ruft Methode Attribute auf (siehe Unten)
        Attribute("1. Laborghini Gallado", 5, 11, 7);
        Attribute("2. Ford Mustang GT", 8, 6, 6);
        Attribute("3. Nissan GT-R", 9, 8, 9);

        Console.WriteLine("\nWähle eine Zahl zwischen 1 und 3: ");

        int eingabe = Convert.ToInt32(Console.ReadLine());
        while (eingabe < 1 || eingabe > 3)
        {
            Console.Beep();
            Console.WriteLine("Falsche Eingabe.");
            eingabe = Convert.ToInt32(Console.ReadLine());
        }
         
        auto = eingabe;

        Console.Write("\nDein Auto: ");
        switch (auto) // Setzt das Autokürzel
        {
            case 1:
                Console.Write("Lamborghini Gallado\n");
                strgAuto = "G";
                break;
            case 2:
                Console.Write("Ford Mustang GT\n");
                strgAuto = "F";
                break;
            case 3:
                Console.Write("Nissan GT-R\n");
                strgAuto = "N";
                break;
        }
        Console.WriteLine("Drücke eine Taste zum Starten!");
        Console.ReadKey();
        Console.Clear();
        Spielzug(strgAuto);
    }
    public static string AusgabePlus(int aEingabe) //Gibt gewisse anzahl an "+" hintereinander aus
    {
        string ausgabe = "";
        for (int i = 0; i <= aEingabe; i++)
        {
            ausgabe += "+";
        }
        return ausgabe;
    }
    public static void Attribute(string name, int bedienung, int geschwindigkeit, int beschleunigung) //Consolenausgabe für Fahrzeugwerte
    {
        Console.WriteLine(name);
        Console.WriteLine("Bedienung: " + AusgabePlus(bedienung)); //Ruft "AusgabePlus" aus, um zu bestimmen, wie viele "+" dazu kommen
        Console.WriteLine("Geschwindigkeit: " + AusgabePlus(geschwindigkeit));
        Console.WriteLine("Beschleunigung: " + AusgabePlus(beschleunigung));
        Console.WriteLine("___________________________________");
    }
    public static void Spielzug(string Auto) //Das Spiel
    {
        string strecke = "";
        string abfrage = "";
        do { //Mache folgenden Codeblock solange whilebedingung erfüllt ist
            posSpieler = 0;
            posComp = 0;
            while (posSpieler < 19 && posComp < 19)
            {
                Console.WriteLine("Gib ein Zahl zwischen 1 und 3 an: ");
                int eingabe = Convert.ToInt32(Console.ReadLine());
                int r = new Random().Next(1, 4); // Generiert zufallszahl zwischen 1 und 3
                posComp++;
                while (eingabe < 1 || eingabe > 3) // Wenn eingabe falsch
                {
                    Console.WriteLine("Falsche Eingabe.");
                    eingabe = Convert.ToInt32(Console.ReadLine());
                }
                if (eingabe == r) //Wenn zufall gleich eingabe
                {
                    posSpieler += eingabe;
                }
                else //wenn nicht setze eingabe = 0
                {
                    eingabe = 0;
                }
                if (posComp == posSpieler) //WEnn position beider Spieler, soll B ausgegeben werden
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        if (!(i == posSpieler))
                        {
                            strecke += "=";
                        }
                        else
                        {
                            strecke += "B";
                        }
                    }
                }
                else //gibt jeweils position von autos aus
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        if (i == posSpieler)
                        {
                            strecke += Auto;
                        }
                        else if (i == posComp)
                        {
                            strecke += "C";
                        }
                        else
                        {
                            strecke += "=";
                        }
                    }
                }
                Console.WriteLine(strecke);
                Console.WriteLine($"Computer: {posComp}");
                Console.WriteLine($"Du: {posSpieler}, ({eingabe})");
                strecke = "";
            }
                if(posComp >= 19) //Gewinnbedingung
                {
                    Console.WriteLine("Computer hat gewonnen");
                }else if(posSpieler >= 19)
                {
                    Console.WriteLine("Du hast gewonnen");
                }
            
            Console.WriteLine("Möchtest du nochmal spielen? (ja/nein)");
            abfrage = Console.ReadLine();
            if(abfrage == "ja")
            {
                Console.Clear();
            }

        }
            while (abfrage == "ja") ;
    }
}