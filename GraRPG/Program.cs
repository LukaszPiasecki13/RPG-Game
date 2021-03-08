using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Zmienne.ekwipunek.Add("zapałki", 60);
            Zmienne.ekwipunek.Add("stare szmaty", 3);
            Zmienne.ekwipunek.Add("zdjęcie córki", 1);

            Zmienne.ekwipunek.Add("stary płaszcz", 1);
            Zmienne.ekwipunek.Add("kiepskie buty", 1);
            while (true)
            {
                Console.Title = "Tytuł okna";//Tytuł okna
                Console.CursorVisible = false; //Widoczność kursora
                Konsola.UstawNazwyOpcji4("NOWA GRA", "WCZYTAJ GRĘ", "PRZEWODNIK", "WYJŚCIE");
                Konsola.WypiszMenu(0);
                Konsola.WybieranieOpcji(0);


                Historia.Fabuła();
            }
         }
    } 
}
 