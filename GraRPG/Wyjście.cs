using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class Wyjście
    {
        static public void Esc()
        {
            Console.Clear();
            Console.WriteLine("              _______  _______  _______  _______  _______  _       ");
            Console.WriteLine("             (  ____ \\(  ____ )(  ___  )/ ___   )(  ____ \\( (    /|");
            Console.WriteLine("             | (    \\/| (    )|| (   ) |\\/   )  || (    \\/|  \\  ( |");
            Console.WriteLine("             | (__    | (____)|| |   | |    /   )| (__    |   \\ | |");
            Console.WriteLine("             |  __)   |     __)| |   | |   /   / |  __)   | (\\ \\) |");
            Console.WriteLine("             | (      | (\\ (   | |   | |  /   /  | (      | | \\   |");
            Console.WriteLine("             | )      | ) \\ \\__| (___) | /   (_/\\| (____/\\| )  \\  |");
            Console.WriteLine("             |/       |/   \\__/(_______)(_______/(_______/|/    )_)");

            Console.WriteLine("Łukasz Piasecki                                                    (wersja demo)");
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        Jeśli chcesz zapisać i wyjść wciśnij ponownie przycisk Esc.");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            if (klawisz.Key == ConsoleKey.Escape)
            {
                ZapisWczyt.Zapisz();
                Environment.Exit(0);

            }
            else
            { }
        
    }
    }
}
