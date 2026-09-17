using System;

class Program
{
    static void Main()
    {
        Console.Write("Palun sisesta jalanumber: ");
        string sisend = Console.ReadLine();
        //Teha jalamuri suurusest üks if ja else harjutus.
        //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline),
        //teine jalanumber 34 - 38 (siin on tagastus valge),
        //kolmas jalanumber 39 - 44 (siin on tekst sinine ja tagastust kollane),
        //neljas jalanumber 45 - 48 (siin teeb arvuti häält beep)
        //Kindlasti tuleb ära kasutada eelnimetatud olukord.
        //kus kasutatakse mõnda teist jalanumbrit.

        if (!int.TryParse(sisend, out int jalanumber))
        {
            Console.WriteLine("Viga: Palun sisesta korrektne number!");
            return;
        }

        if (jalanumber >= 30 && jalanumber <= 33)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jalanumber on vahemikus 30-33. Tekst on roheline!");
            Console.ResetColor();
        }
        else if (jalanumber >= 34 && jalanumber <= 38)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Jalanumber on vahemikus 34-38. Tagataust on valge!");
            Console.ResetColor();
        }
        else if (jalanumber >= 39 && jalanumber <= 44)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jalanumber on vahemikus 39-44. Sinine tekst ja kollane taust!");
            Console.ResetColor();
        }
        else if (jalanumber >= 45 && jalanumber <= 48)
        {
            Console.WriteLine("Jalanumber on vahemikus 45-48. Arvuti teeb kohe piiksu!");
            Console.Beep();
        }
        else
        {
            Console.WriteLine($"Sisestasid jalanumbri {jalanumber}. See ei kuulu ühtegi eelnevasse vahemikku.");
        }
    }
}