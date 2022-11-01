namespace Praktikum_Pankratov03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoelzer = 21;

            Console.WriteLine("Lass und spielen. Waehle zwischen 1-4 Hoelzer. Du faengst an.");
            //Solange Streichhoelzer vorhanden soll folgendes ausgeführt werden:
            while (hoelzer > 0)
            {
                int eingabe = Convert.ToInt32(Console.ReadLine());
                if (eingabe < 1 || eingabe > 4) //Wenn eingabe nicht zwischen 1 und 4
                {
                    Console.WriteLine("Gib eine Zahl zwischen 1 und 4 an.");
                }
                else if (hoelzer - eingabe == 0) //Wenn der Spieler das letzte Holz nimmt
                {
                    Console.WriteLine("Du hast verloren");
                    break;
                }
                else if (eingabe > hoelzer) // Wenn eingabe die anzahl der vorhandenen Hoelzer überschreitet
                {
                    Console.WriteLine("Das war ein bisschen zu viel :)");
                }
                else
                {
                    hoelzer -= eingabe; //Passe vorhandene Hoelzer an
                    Ausgabe(hoelzer); // Ruft Methode aus (Siehe unten)
                    Thread.Sleep(100); //-> Wartet 100 Ticks, bevor Programm weiter macht
                    Console.WriteLine($"\nDer Computer nimmt {5 - eingabe} Hoelzer");
                    hoelzer = hoelzer - (5 - eingabe); //Berechnet neue Holzanzahl, wenn der Computer gezogen hat.
                    Ausgabe(hoelzer);
                    Console.WriteLine(); //Platzhalter
                }
            }
        }
        static void Ausgabe(int wdh)
        {
            for (int i = 0; i < wdh; i++) //Gibt alle Streichhölzer nacheinander aus
            {
                Console.Write("I ");
                Thread.Sleep(100);
            }
            Console.WriteLine($"\nEs sind noch {wdh} uebrig.");
            Console.WriteLine();
        }
    }
}