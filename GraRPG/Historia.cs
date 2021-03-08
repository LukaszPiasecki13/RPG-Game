using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
  static class Historia

    {

        static public void Fabuła()
        {
            
            switch (Konsola.aktywnaPozycjaMenu)
            {
                case 0:                                         //Nowa Gra
                    while (true)
                    {
                        switch (Zmienne.krok)
                        {
                            case 0:

                                Console.Clear();
                                Teksty.Tekst(1);
                                Console.ReadKey();
                                Console.Clear();
                                Zmienne.krok = 1;
                                break;

                            case 1:
                                Teksty.Tekst(2);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                
                                break;
                            case 2:
                                Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne - 5;
                                Teksty.Tekst(3);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 3:
                                Konsola.UstawNazwyOpcji2("[Podejdź i pomóż mu wstać]", "[Idź dalej]");
                                Konsola.WypiszMenu(4);
                                Konsola.WybieranieOpcji(4);
                                KolejneEtapyGry.WybórHistorii(Konsola.aktywnaPozycjaMenu);
                                Zmienne.krok++;
                                break;
                            case 4:

                                Konsola.UstawNazwyOpcji2("Człowieku, bój się Boga, ona nie dojdzie!",
                                    "Ty komunistyczna świnio, nie widzisz, że ona nie daje rady? ");
                                Konsola.WypiszMenu(6.3);
                                Konsola.WybieranieOpcji(6.3);
                                Zmienne.krok++;
                                break;
                            case 5:

                                switch (Konsola.aktywnaPozycjaMenu)
                                {
                                    case (0):
                                        Zmienne.zmiennaUżyteczna = 0;
                                        Zmienne.krok++;
                                        break;
                                    case (1):
                                        Console.WriteLine("");
                                        Console.WriteLine("_______________________________________________________________________________");
                                        Console.WriteLine("Żołnierz uderza cię kolbą karabinu [HP - 2]");
                                        Zmienne.zmiennaUżyteczna = 0;
                                        Console.ReadKey();
                                        Zmienne.HP = Zmienne.HP - 2;
                                        Zmienne.krok++;
                                        break;
                                }
                                break;
                            case 6:
                                Teksty.Tekst(6.5);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 7:
                                Teksty.Tekst(6.51);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 8:
                                Teksty.Tekst(6.6);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 9:
                                Teksty.Tekst(6.7);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 10:
                                Teksty.Tekst(6.8);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 11:
                                Teksty.Tekst(6.9);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 12:
                                Teksty.Tekst(7.0);
                                WypisywanieEkwipunku.OnOffEkwipunek();

                                break;
                            case 13:
                                Teksty.Tekst(7.1);
                                Konsola.aktywnaPozycjaMenu = 1;
                                Konsola.UstawNazwyOpcji3("(Skorzystaj z zamieszania i oddal się niepostrzeżenie)",
                                    "(Podnieś <solidny scyzoryk>)", "(Zostań na miejscu, nie narażając się na śmierć)");
                                Konsola.WypiszMenu(7.1);
                                Konsola.WybieranieOpcji(7.1);
                                KolejneEtapyGry.WybuchWObozie(Konsola.aktywnaPozycjaMenu);
                                Konsola.aktywnaPozycjaMenu = 0;
                                break;

                            case 14:
                                Teksty.Tekst(7.2);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 15:
                                Teksty.Tekst(7.3);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 16:
                                Teksty.Tekst(7.4);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 17:
                                Teksty.Tekst(7.5);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 18:
                                Teksty.Tekst(7.6);
                                Konsola.UstawNazwyOpcji2("Nie zostanę tu długo, muszę wrócić do córki. Ucieknę. ",
                                    "Odczep się. ");
                                Konsola.WypiszMenu(7.6);
                                Konsola.WybieranieOpcji(7.6);
                                KolejneEtapyGry.RozmowaWBaraku(Konsola.aktywnaPozycjaMenu);
                                Konsola.aktywnaPozycjaMenu = 0;
                                break;
                            case 19:
                                Teksty.Tekst(7.9);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
              //************************KOLEJNY DZIEŃ************************************
                            case 20:
                                Teksty.Tekst(8.0);
                                Zmienne.HP = 100;
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 21:
                                Teksty.Tekst(8.1);
                                Konsola.UstawNazwyOpcji2("Będę pracował ciężko, każdą porcę jedzenia będę zjadał odrazu.                  (efekt " +
                                    "niedożywienie nieaktywny)",
                                 "Będę pracował ciężko, starając się składać, z i tak małej porcji jedzenia,      prowiant na ucieczkę ");
                                Konsola.WypiszMenu(8.1);
                                Konsola.WybieranieOpcji(8.1);
                                KolejneEtapyGry.WybórStrategiiPracy(Konsola.aktywnaPozycjaMenu);
                                Konsola.aktywnaPozycjaMenu = 0;
                                break;
                            case 22:
                                Teksty.Tekst(8.4);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 23:
                                Teksty.Tekst(8.5);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 24:
                                Teksty.Tekst(8.6);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 25:
                                Teksty.Tekst(8.7);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 26:
                                Teksty.Tekst(8.8);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 27:
                                Teksty.Tekst(8.9);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            //**************************** U KAPITANA ***************************************************************

                            case 28:
                                Teksty.Tekst(9.0);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 29:
                                KolejneEtapyGry.WWarsztacie(Zmienne.wybranaHistoria);
                                Zmienne.krok++;
                                break;
                                //*******************************************************************************************
                            case 30:
                                Teksty.Tekst(10.3);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 31:
                                Teksty.Tekst(10.4);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 32:
                                Teksty.Tekst(10.5);
                                Zmienne.odwodnienie = "choroba";
                                Zmienne.HP = Zmienne.HP - 50;
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 33:
                                Teksty.Tekst(10.6);
                                Zmienne.ekwipunek.Add("kompas", 1);
                                Zmienne.ekwipunek.Add("mapa", 1);
                                Zmienne.ekwipunek.Add("pistolet", 1);
                                Zmienne.ekwipunek.Add("naboje", 50);
                                Zmienne.HP = Zmienne.HP + 25;
                                Zmienne.odwodnienie = "";
                                Zmienne.krok++;

                                break;
                            case 34:
                                Teksty.Tekst(10.7);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 35:
                                Teksty.Tekst(10.8);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 36:
                                Teksty.Tekst(10.9);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 37:
                                Teksty.Tekst(11.0);
                               
                                Zmienne.ekwipunek.Add("palnik na naftę", 1);
                                Zmienne.ekwipunek.Add("rakiety śnieżne", 2);
                                Zmienne.ekwipunek.Add("sznurki", 12);
                                Zmienne.ekwipunek.Add("bandarze", 2);
                                Zmienne.krok++;
                                break;
                            case 38:
                                Teksty.Tekst(11.1);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            //*******************************UCIECZKA**************************************

                            case 39:
                                Teksty.Tekst(11.2);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 40:
                                Teksty.Tekst(11.3);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 41:
                                Teksty.Tekst(11.4);
                                Console.ReadKey();
                                Environment.Exit(0);

                                break;

                            //********************************NIEMĄDRZY**************************************************************


                            case 100:

                                Teksty.Tekst(11.3);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 101:

                                Teksty.Tekst(11.2);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 102:

                                Teksty.Tekst(11.2);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 103:

                                KolejneEtapyGry.DlaTychNiemądrych();
                                
                                break;
                            case 104:

                                Teksty.Tekst(100);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 105:

                                Teksty.Tekst(11.5);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 106:

                                Teksty.Tekst(11.6);
                                Zmienne.odwodnienie = "Zapalenie płuc";
                                Zmienne.krok++;
                                break;
                            case 107:

                                Teksty.Tekst(11.7);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 108:

                                Teksty.Tekst(11.8);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                Zmienne.krok = 130;
                                break;






















                            case 120:

                                Teksty.Tekst(100);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;
                            case 121:

                                Teksty.Tekst(101);
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;

                            case 122:

                                Teksty.Tekst(102);
                                Zmienne.odwodnienie = "przemarznięcie";
                                Zmienne.HP = Zmienne.HP - 3;
                                Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne- 10;
                                Console.ReadKey();
                                Zmienne.krok++;
                               
                                break;

                            case 123:

                                Teksty.Tekst(103);
                               if(Zmienne.HP < 0)
                                {
                                    Zmienne.krok = 130;
                                        break;
                                }
                                Zmienne.HP = Zmienne.HP - 6;
                                Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne - 10;
                                Console.ReadKey();
                                Zmienne.krok++;
                                break;

                            case 124:

                                Teksty.Tekst(104);
                                if (Zmienne.HP < 0)
                                {
                                    Zmienne.krok = 130;
                                    break;
                                }
                                WypisywanieEkwipunku.OnOffEkwipunek();
                                break;


                            case 130:
                                Teksty.Tekst(104);
                                Console.ReadKey();
                                Environment.Exit(0);

                                break;





                        }
                    }


                   

                case 1:
                    Console.Clear();
                    Konsola.aktywnaPozycjaMenu = 0;
                    ZapisWczyt.Wczytaj();
                    Fabuła();
                    break;
                case 2: Console.Clear();
                    Statystyki.WypiszPomoc();
                    Console.ReadKey();
                    Console.Title = "Tytuł okna";//Tytuł okna
                    Console.CursorVisible = false; //Widoczność kursora

                    break;       
                case 3: Environment.Exit(0); break;




            }


        }

        static void opcjaWBudowie()
        {
            Console.SetCursorPosition(12, 4);
            Console.WriteLine("Jeszcze w budowie, kiedyś to napiszę :)");
            Console.ReadKey();
        }


    }
}
