using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
   static class WypisywanieEkwipunku
    {

        static public void OnOffEkwipunek()
        {
            bool pętla = true;
            while (pętla)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.E)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Statystyki.WypiszEkwipunek();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        pętla = false;
                        break;
                    }
                }
                else if (klawisz.Key == ConsoleKey.F1)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Statystyki.WypiszPomoc();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        pętla = false;
                        break;


                    }
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Wyjście.Esc();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        pętla = false;
                        break;


                    }
                }
                else
                {
                    Zmienne.krok++;
                    pętla = false;
                    break;
                }
            }

        }

        static public void OnOffEkwipunekOkro(double a)
        {
            bool pętla = true;
            while (pętla)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.E)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Statystyki.WypiszEkwipunek();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        Teksty.Tekst(a);


                    }
                }
                else if (klawisz.Key == ConsoleKey.F1)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Statystyki.WypiszPomoc();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        Teksty.Tekst(a);


                    }
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    if (Zmienne.onEkwipunek == false)
                    {
                        Wyjście.Esc();
                        Zmienne.onEkwipunek = true;

                    }
                    else if (Zmienne.onEkwipunek == true)
                    {
                        Zmienne.onEkwipunek = false;
                        Teksty.Tekst(a);


                    }
                }
                else
                {

                    pętla = false;
                    break;
                }
            }

        }
    }
}
