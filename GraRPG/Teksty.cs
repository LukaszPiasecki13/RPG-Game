using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
    static class Teksty
    {
       static private int HP { set; get; }
       static private int zmiennnaPotrzebna { set; get; } 


    static public void StałeRozpoczęcie()
        {
            HP = Zmienne.HP;
            Console.Clear();
            for (int i = 0; i < Zmienne.liczbaLiterImienia; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            Console.WriteLine("**" + Zmienne.imię + "**");
            for (int i = 0; i < Zmienne.liczbaLiterImienia; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");




            Console.WriteLine("*       HP: " + Zmienne.HP + "% | " + Zmienne.odwodnienie +
                " | " + Zmienne.niedożywienie + " | " + Zmienne.choroba + "Zdrowie Psychiczne: " +
                                         Zmienne.zdrowiePsychiczne + "%        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("");
        }

    static public void Tekst(double nrTekstu)
        {
            switch (nrTekstu)
            {
                case 0.1:
                    break;
                case 0:
                    
                    
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

                    break;
                case 1:
                    Console.WriteLine("'Kto syberyjskie przemierzy pustynie,");
                    Console.WriteLine("Pozna, jak przestrzeń Europy małą;");
                    Console.WriteLine("Odległość wszelka dla takiego zginie");
                    Console.WriteLine("I wszystko będzie drobnym mu sięzdało.");
                    Console.WriteLine("Wieczność takiego w dniu zgonu nie strwoży");
                    Console.WriteLine("Nieokreślona,szara jak step ciemny.");
                    Console.WriteLine("Wszystko mu jedno: blask czy mrok podziemny");
                    Console.WriteLine("I piekło... w piekle nie może być gorzej!!!'");
                    Console.WriteLine("                             Cienie syberyjskie-Teofil Lenartowicz");
                    Console.WriteLine();
                    Console.WriteLine("_____________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" *  Większość opisanych tutaj osób/miejsc/sytuacji istniała naprawdę. ");
                                        break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: "+
                                         Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                  /**  Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("                               .----------------------.                                ");
                    Console.WriteLine("                              | .--------------------. |                               ");
                    Console.WriteLine("                              | |    __       __     | |                               ");
                    Console.WriteLine("                              | |   |__|     |__|    | |                               ");
                    Console.WriteLine("                              | |                    | |                               ");
                    Console.WriteLine("                              | |         oo         | |                               ");
                    Console.WriteLine("                              | |    ''        ''    | |                               ");
                    Console.WriteLine("                              | |     ''------''     | |                               ");
                    Console.WriteLine("                              | |      ````````      | |                               ");
                    Console.WriteLine("                              | '--------------------' |                               ");
                    Console.WriteLine("                               '----------------------'                                ");**/
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("  Budzi cię nagłe szarpnięcie. Twój płytki, niespokojny sen zostaje przerwany.");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine(" - Nareszcie się obudziłeś. Nie zasypiaj bo zamarzniesz! Przybliż się do ognia.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("Światło tlącego się drewna oświetla niewielką przestrzeń pośrodku 'niczego'.");
                    Console.WriteLine("Ostry mróz sprawia, że nawet ogień nie daje ciepła. Z dalek słychać tylko ciche");
                    Console.WriteLine("rżenie konia. I one nie rozumieją co robią w tym zapomnianym przez Boga miejscu.");
                    Console.WriteLine("  Chcesz wstać, ale czujesz, że trzyma cię ręka osoby leżącej obok. Przy próbie");
                    Console.WriteLine("oswobodzenia się zauważasz nienaturalnie bladą twarz mężczyzny obok, co  ");
                    Console.WriteLine("świadczy, że on już nie żyje...(Zdrowie Psychiczne - 5%)");
                    
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");
                    break;
                case 3:
                   
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                          Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("(SEN) Śliczna dziewczynka z długimi włosami, biegnie niosąc ślicznego motyla  ");
                    Console.Write(" [Dziewczynka] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Tato, popatrz...popatrz jaki piękny");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("Kolorowy motyl wzbił się z ręki dziewczynki i niczym promyk słońca zniknął ");
                    Console.WriteLine("w morzu polnych kwiatów...  (SEN)");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                          Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                  Dzień później");

                    break;
                case 4:
                    HP = Zmienne.HP;
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                         Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("Wstęga wycieńczonych osób wydaje się nie mieć końca. Ciche skrzpienie starych ");
                    Console.WriteLine("sań, zaprzężonych w parę zamrnowacych koni, przerywa odwieczną ciszę ");
                    Console.WriteLine("syberyjskiej tundry. Już niewiele osób ma siłę i chęć prowadzić rozmowę. Nawet");
                    Console.WriteLine("najkrótsze słowo jest niewyobrażalnym wysiłkiem. Tylko rosyjscy żołnierze ");
                    Console.WriteLine("mają jeszcze siłę rozmawiać, w między czasie przeklinając i obrażając ");
                    Console.WriteLine("eskortowanych polaków");
                    Console.WriteLine("                                     ***                                       ");
                    Console.WriteLine("Metrowe zaspy śniegu, wydeptane przez setki osób przed tobą, sprawiają, że  ");
                    Console.WriteLine("każdy krok jest okraszano wysiłkiem większym od poprzedniego. ");
                    Console.WriteLine(" Staruszek przed tobą osuwa się bezwładnie w śnieg. Wszyscy przechodzą obojętnie ");
                    Console.WriteLine("_______________________________________________________________________________");
                   
                    break;
                    //----------------------------------------------------------------------------------------------------------
                case 5.0:
                    HP = Zmienne.HP;
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                         Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("Przy próbie podnoszenia poślizgujesz i upadasz. Radziecki sierżant, widząc to, ");
                    Console.WriteLine("podchodzi i z rozpędu wymierza ci ostrego kopniaka w żebra. (-2HP)");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine(" - Wstawaj ty polska świnio.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("Kilkoma następnymi kopniakami zmusza cię do wstania i pozostawienia staruszka. ");
                    Console.WriteLine("_______________________________________________________________________________");
                    break;

                case 5.1:
                    HP = Zmienne.HP;
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                         Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("Przechodzisz obojętnie, nie widząc jak kolejne osoby idą twoim śladem");
                    Console.WriteLine();
                    break;
                //-----------------------------------------------------------------------------------------------------------

                case 6.0:
                    HP = Zmienne.HP;
                    Console.Clear();
                    Console.WriteLine("*      HP: " + Zmienne.HP + "% | Odwodnienie | Niedożywienie | Zdrowie Psychiczne: " +
                                         Zmienne.zdrowiePsychiczne + "%        *");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Już po nim. Za chwilę zakopią go w śniegu. Nie doczekał nawet porządnego ");
                    Console.WriteLine("grobu w ziemi. Gdy przyjdzie lato, przynajmniej wilki nie będą musiały wysilać");
                    Console.Write("się aby coś upolować.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine(" - powiedział mężczyzna, którego oszroniony kaptur ");
                    Console.WriteLine("szczelnie owijał twarz.");
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów 
                    Console.WriteLine(" Jestem Zbigniew. Pracuję listonosz w Drozdowie. A ty jak się nazywasz?");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");
                    //************************************************************************************************************
                    Console.Write("Jestem [Wpisz swoje imię] ");



                    break;
                case 6.1:
                    Zmienne.liczbaLiterImienia = Zmienne.imię.Length + 3;
                    StałeRozpoczęcie();
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Już po nim. Za chwilę zakopią go w śniegu. Nie doczekał nawet porządnego ");
                    Console.WriteLine("grobu w ziemi. Gdy przyjdzie lato, przynajmniej wilki nie będą musiały wysilać");
                    Console.Write("się aby coś upolować.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine(" - powiedział mężczyzna, którego oszroniony kaptur ");
                    Console.WriteLine("szczelnie owijał twarz.");
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów 
                    Console.WriteLine(" Jestem Zbigniew. Pracuję jako listonosz w Drozdowie. A ty jak się nazywasz?");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");
                    //************************************************************************************************************
                    Console.Write("Jestem "+ Zmienne.imię);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;


                case 6.2:
                    StałeRozpoczęcie();
                    Console.WriteLine("");
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Co się stało z twoją rodziną? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.WriteLine(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Natychmiast po " +
                        "moim powrocie przybyli radzieccy żołnierze. Ja i moja żona       mieliśmy 15 min, aby zabrać najpotrzebniejsze rzeczy. " +
                        "Jedyne co było otuchą dla mojego serca, była wiadomość, że moja najukochańsza córeczka, została dzień     wcześniej wysłana " +
                        "przez moją żonę do babci do Grabowic. Niestety podczas        transpotu moja żona zmarła, a mnie jedyne co pozostało " +
                        "to tęsknota i wiara, że  wrócę i odnajdę moją kruszynkę.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Nagle zauważasz jak przed tobą kobieta z roczną córeczką na ręku potyka się i ");
                    Console.WriteLine("wypuszcza dziecko pod nogi radzieckiego żołnierza.");
                    Console.ReadKey();
                    Console.Write(" [Radziecki żołnież] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Vstavat!!!");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();

                    break;

                case 6.3:
                    StałeRozpoczęcie();
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Co się stało z twoją rodziną? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Natychmiast po " +
                        "moim powrocie przybyli radzieccy żołnierze. Ja i moja żona       mieliśmy 15 min, aby zabrać najpotrzebniejsze rzeczy. " +
                        "Jedyne co było otuchą dla mojego serca, była wiadomość, że moja najukochańsza córeczka, została dzień     wcześniej wysłana " +
                        "przez moją żonę do babci do Grabowic. Niestety podczas        transpotu moja żona zmarła, a mnie jedyne co pozostało " +
                        "to tęsknota i wiara, że  wrócę i odnajdę moją kruszynkę.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Nagle zauważasz jak przed tobą kobieta z roczną córeczką na ręku potyka się i ");
                    Console.WriteLine("wypuszcza dziecko pod nogi radzieckiego żołnierza.");
                    Console.Write(" [Radziecki żołnież] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Vstavat!!!");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");

                    break;

                
                case 6.5 :
                    StałeRozpoczęcie();

                    Console.WriteLine("Żołnierz szybkim ruchem założył karabin na ramię, po czym podszedł do biedaczki");
                    Console.WriteLine("i pomógł jej wstać. Podniósł zapłakaną dziewczynkę i delikatnie przytulił ją ");
                    Console.WriteLine("do swojego płaszcza.");
                    Console.WriteLine("");
                    break;

                case 6.51:
                    StałeRozpoczęcie();
                    Console.WriteLine("Słyszysz, jak ktoś szepta za twoimi plecami.(odwracasz się i nasłuchujesz)");
                    Console.WriteLine("Widzisz kobietę w wieku ok. 30 lat. Jej usta, ledwo poruszane, wydawały");
                    Console.WriteLine("tylko dwa słowa.");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Wszyscy......zginiemy......wszyscy.......zginiemy.....");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Co jej jest? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Straciła dziecko w pociągu. Od tego czasu ma napady histerii, ");
                    Console.WriteLine("nie reaguje na otoczenie. W tym momencie jest wyjątkowo spokojna.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;

                case 6.6:
                
                    StałeRozpoczęcie();

                    Console.WriteLine("Nastało południe. Staruszek obok, ociężale stawia krok za krokiem, załamana  ");
                    Console.WriteLine("kobieta kontynuuje swoją litanię, zatroskana matka co jakiś czas nieufnie ");
                    Console.Write("spogląda na żołnierza i na niesioną przez niego dziewczynkę, a wielotysięczny  ");
                    Console.WriteLine("pochód powoli zbliża się do miejscowści");
                    Console.ForegroundColor = ConsoleColor.Yellow;    //kolor napisów opcji
                    Console.Write("Workuta");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine(".");


                    break;

                case 6.7:
                    StałeRozpoczęcie();

                    Console.WriteLine("  Obóz do którego was prowadzą, wywiera na tobie ogromne wrażenie. Gęstwina ");
                    Console.WriteLine("domów rozsiana u podnóża gór Uralu Polarnego kontrastuje z niekończącą się ");
                    Console.WriteLine("pustką syberyjskiej tundry.");
                    Console.WriteLine("  Zatrzymujecie się na placu pośrodku wielkiego obozu oddzielonego młym ");
                    Console.WriteLine("drewnianym płotem od reszty miasteczka. Czujni strażnicy na ");
                    Console.WriteLine("nielicznych, drewnianych wieżach wydają się bacznie obserwować każdego z ");
                    Console.WriteLine("kilkutysięcznego tłumu więźniów.");
                    Console.WriteLine("");

                    break;

                case 6.8:
                    StałeRozpoczęcie();
       
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Nie ma żadnego ogrodzenia, a strażnicy na wieżyczkach i tak ");
                    Console.WriteLine("wszystkiego nie widzą.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Gdzie chcesz uciec? Jesteśmy pod kołem podbiegunowym. Jedyne co ");
                    Console.WriteLine("zastaniesz w promieniu 100km to śnieg, pustkę i śmierć. Nie masz żadnego  ");
                    Console.WriteLine("jedzenia, żadnego sprzętu. Prędzej umrzesz z głodu lub mrozu niż dotrzesz ");
                    Console.WriteLine("do najbliższej wioski.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("");
                    Console.WriteLine("  Na balkonie w budynku, który z całą pewnością był siedzibą radzieckich służb ");
                    Console.WriteLine("pojawia się rosły, mocno zbudowany mężczyzna w oficerskim płaszczu. Blizny ");
                    Console.WriteLine("na jego twarzy zdradzały, że nie miał prostego życia.");                 
                    Console.WriteLine("");
                    break;

                case 6.9:
                    StałeRozpoczęcie();
                    Console.Write(" [Radziecki oficer] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Zdravstvuyte, dorogiye poselentsy. YA rad prinyat' vas ");
                    Console.WriteLine("v nashem skromnom gorode.....");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Co on mówi? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [Mężczyzna obok] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Propaganda, że niby ma nadzieję, że będziemy czuli się  ");
                    Console.WriteLine("tutaj bezpiecznie i jakieś inne komunistyczne farmazony. Niech go dia... ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;

                case 7.0:
                    StałeRozpoczęcie();
                    Console.WriteLine("   Ogromny wybuch wstrząnął podłożem. Kłęby dymu i ognia wzniosły się nad ");
                    Console.WriteLine("okolicę. ");
                    Console.ReadKey();
                    Console.WriteLine("Eksplozja była tak wielka, że nikt nie utrzymał się na nogach.");
                    Console.ReadKey();
                    Console.WriteLine("Kobieta, która wcześniej tylko mamrotała pod nosem, zaczęła krzyczeć nieludzkim głosem.");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Oto nadszedł czas!!! Beliar, Pan światów przybywa.  ");
                    Console.WriteLine("Nadchodzi, aby wymazać moc Innosa z powierzchni ziemi...");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji                  
                    break;
                case 7.1:
                    StałeRozpoczęcie();
                    Console.WriteLine("Radziecki żołnierz upadając gubi <solidny scyzoryk>. Widzisz, że przez  ");
                    Console.WriteLine("zamieszanie nikt nie zorientuje się, jeśli zniknie jeden więzień. ");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");
                    
                    break;

                case 7.2:
                    StałeRozpoczęcie();
                    Console.Write(" [Radziecki oficer] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YA kapitan Wasiajew, i ya Gospod' zhizni i smerti zdes'");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.WriteLine("Splunął szpetnie i chowając pistolet rozkazał żołnierzom.");
                    Console.Write(" [Kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Beri etikh podonkov i gotov'sya k zavtrashnemu dnyu'");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;

                case 7.3:
                    StałeRozpoczęcie();
                    Console.WriteLine("Zostajesz zakwaterowany w jednym z baraków. Ogromny ścisk sprawia, że ");
                    Console.WriteLine("przynajmniej teraz czujesz przyjemne ciepło ");
                    Console.WriteLine("(efekt przemarznięcie nieaktywny)");
                    Zmienne.przemarznięcie = "";
                    
                    break;
                case 7.4:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dostajesz wodnistą zupę, z kawałeczkiem gotowanego dorsza");
                    Console.WriteLine("(efekt odwodnienie nieaktywny)");
                    Zmienne.odwodnienie = "";

                    break;
                case 7.5:
                    StałeRozpoczęcie();
                    Console.WriteLine("W między czasie przychodzą brygadierzy, rozdając odzierz roboczą");
                    Console.WriteLine("i oznajmując, że zostałeś przydzielony do pracy w kopalni.");
                    Console.WriteLine("(ekwipunek + <robocze łachmany>)");
                    Zmienne.ekwipunek.Add("robocze łachmany", 1);

                    break;

                case 7.6:
                    StałeRozpoczęcie();
                    Console.Write(" [Nieznajomy] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Współczuję ci synku, robota w kopalni to jak wyrok, ale nie ");
                    Console.WriteLine("martw się, po roku powinni przenieść cię do pracy w lesie.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine("");

                    break;

                case 7.7:
                    StałeRozpoczęcie();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Nie zostanę tu długo, muszę wrócić do córki. Ucieknę. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [Nieznajomy] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Do ucieczki trzeba dobrze się przygotować. Potrzebne ci  ");
                    Console.WriteLine("odpowiednie ubranie, buty kompas. Co będziesz jadł? Co zrobić gdy  ");
                    Console.WriteLine("natkniesz się na ludzi? Jak rozpalić ogień w temperaturze -40 stopni? ");
                    Console.WriteLine("Jeśli w rok dotrzesz na brzeg Leny, możesz uklęknąć i podziękować Bogu.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    break;


                case 7.8:
                    StałeRozpoczęcie();

                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Odczep się. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów 
                    Console.Write(" [Nieznajomy] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Widać, że jesteś nowy, arogancki. Uważaj, tacy jak ty długo    tutaj nie żyją. " +
                        "Ich krótki żywot kończy śmierć z wycieńczenia, rozkaz inspektoralub więzienny kilof.");                   
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Muszę się stąd wydostać. Mam małą córeczkę, którą muszę odnaleźć.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów 
                    Console.ReadKey();
                    Console.Write(" [Nieznajomy] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Do ucieczki trzeba dobrze się przygotować. Potrzebne ci  ");
                    Console.WriteLine("odpowiednie ubranie, buty kompas. Co będziesz jadł? Co zrobić gdy  ");
                    Console.WriteLine("natkniesz się na ludzi? Jak rozpalić ogień w temperaturze -40 stopni? ");
                    Console.WriteLine("Jeśli w rok dotrzesz na brzeg Leny, możesz uklęknąć i podziękować Bogu.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    break;

                case 7.9:
                    StałeRozpoczęcie();
                    Console.Write(" [Nieznajomy] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Tak właściwie to jestem Władjew. Jak ty masz na imię?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Nazywam się " + Zmienne.imię);
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów 
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Idź lepiej spać, zregeneruj się przed jutrzejszą pracą ");
                    Console.WriteLine("i najlepiej zapomnij o ucieczce. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów 
                    
                    break;

                case 8.0:
                 StałeRozpoczęcie();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                  Jakiś czas później");   
                    Console.WriteLine();
                    int zycie = 100 - Zmienne.HP;
                    Console.WriteLine("                                  (+"+ zycie +"% HP)" );
                    break;
                case 8.1:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dzień mija za dniem. Większość czasu spędzasz w kopalni, jedząc tam, pracując.");
                    Console.WriteLine("Na świerze powietrze wychodzisz tylko wieczorem idąc do swojego baraku, oraz w ");
                    Console.WriteLine("w niedziele, gdy wkońcu możesz odpocząć.");
                    Console.WriteLine();
                    Console.WriteLine("Twoja ogólna strategia na ten czas to:");
                    Console.WriteLine("_______________________________________________________________________________");
                    Console.WriteLine();
                    break;
                case 8.2:
                    StałeRozpoczęcie();
                    Console.WriteLine("Pracujesz całe dnie, a każdą porcję skromnego posiłku pochłaniasz w oka ");
                    Console.WriteLine("mgnieniu.     (efekt niedożywienie nieaktywny)");
                    Console.WriteLine("");
                     break;

                case 8.3:
                    StałeRozpoczęcie();
                    Console.WriteLine("Uważasz, że każdy posiłek przybliża cię do ucieczki. Ze skromnej porcjiposiłku ");
                    Console.WriteLine("rozsądnie wybierasz małe kawałki słoniny, ryby, skórki z chleba i ukrywasz ");
                    Console.WriteLine("najstaranniej jak potafisz. ");
                    Console.WriteLine("");
                    Zmienne.ekwipunek.Add("wysuszone jedzenie", 10);
                    Console.WriteLine("(Ekwipunek + <wysuszone jedzenie> x 10");

                    break;
                case 8.4:
                    StałeRozpoczęcie();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                  Jakiś czas później");
                    
                    break;
                case 8.5:
                    StałeRozpoczęcie();
                    Console.WriteLine("Tracisz rachubę czasu, wierzysz tylko, że dzień gdy nie pracujesz jest ");
                    Console.WriteLine("niedzielą, dwudniowa przerwa to jakieś święto, może Boże Narodzenie lub ");
                    Console.WriteLine("Wielkanoc. Twoje życie odmienia się gdy....");
                    
                    break;
                case 8.6:
                    StałeRozpoczęcie();
                    Console.WriteLine("  Jesteś w ciemnym szybie kopalnianym, praca stała się twoją najbliższą ");
                    Console.WriteLine("przyjaciółką.");
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("...i ja mu wtedy mówię 'towarzyszu, nie denerwuj się, zaraz ");
                    Console.WriteLine("wyklepiemy', a on mi: 'jak mam się nie denerwować, napewno już nie ");
                    Console.WriteLine("wyklepiesz...' a ja mu mówię: 'no to wyciągniemy z mojego wozu i damy tobie...'");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Oj Zbyszek, moja stara schorowana babka opowiadała lepsze bajki. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [Zbigniew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Nie chcesz wierzyć to nie wierz. Weź podaj mi tamto przęsło.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                

                    break;
                case 8.7:
                    StałeRozpoczęcie();
                    Console.WriteLine("Odchodzisz pięć metrów. Sięgając po przęsło słyszysz trzask pękającej ściany.");
                  //  Console.WriteLine(" ");
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine(" ZBYSZEK!!!!");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;
                case 8.8:
                    StałeRozpoczęcie();
                    Console.WriteLine("Wydrążony w skale strop pękł i ogromna hałda zakryła miejsce, w którym ");
                    Console.WriteLine("przed chwilą rozmawiałeś ze Zbyszkiem. ");
                    Console.WriteLine("Rzucasz się na pomoc przyjacielowi, odgrzebując kawałki skał, lecz");
                    Console.WriteLine("zauważając jego roztrzaskaną twarz cofasz się w przerażeniu.");
                    Console.WriteLine("(Zdrowie Psychiczne - 20%");
                    Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne - 20;

                    break;
                case 8.9:
                    StałeRozpoczęcie();
                    Console.WriteLine("W tym samym momencie wchodzi rosyjski strażnik. Nie zwracając większej");
                    Console.WriteLine("uwagi natragiczny wypadek, woła z przekąsem");
                    Console.Write(" [rosyjski strażnik] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Więzień " + Zmienne.imię + ". Kapitan Wasiajew cię wzywa.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    

                    break;
                case 9.0:
                    StałeRozpoczęcie();
                    Console.WriteLine("Razem ze strażnikiem wychodzisz na powierzchnię. Słońce swoim blaskiem ");
                    Console.WriteLine("niemalże wypala twoje oczy. Dochodzicie do metalowego warsztatu. W środku ");
                    Console.WriteLine("dostrzegasz kapitana Wasiajewa.");
                    break;
                    //************************WOJSKOWY ELEKTRYK*************************8
                case 9.1:
                    StałeRozpoczęcie();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Witam oficerze " + Zmienne.imię +". Jak dobrze ciebie widzieć. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Jestem tylko sierżantem. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("A już sądziłem, gdy widziałem ciebie w dniu wybuchu, że ");
                    Console.WriteLine("postanowisz wtedy zwiać. Ale to dobrze, bardziej przydasz się żywy. ");
                    Console.WriteLine("Widzisz, mamy tutaj taki problem, a mówiłeś, że jesteś elektrykiem. Masz ");
                    Console.WriteLine("Masz trzy dni, aby go naprawić, jeśli chcesz jeszcze żyć.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji


                    break;

                case 9.2:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dzięki swemu obeznaniu w tematyce inżynierii (inżynieria = 8) udaje ci się ");
                    Console.WriteLine("naprawić generator w dwa dni. Postanawiasz jednak przeszukać warsztat w ");
                    Console.WriteLine("poszukiwaniu czegoś co pomoże ci w ucieczce. ");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Znajdujesz małe buteleczki z naftą i pasek od spodni");
                    Console.WriteLine("(Ekwipunek + <buteleczka z naftą> x2");
                    Console.WriteLine("(Ekwipunek + <pasek od spodni> x1");

                    break;
                case 9.3:
                    StałeRozpoczęcie();
                    Console.WriteLine("Nagle widzisz, że lina ze strychu warsztatu prowadzi wprost do wagoników ");
                    Console.WriteLine("których tory prowadzą poza obóz.");
                    Console.WriteLine("");
                    break;
                    //**************************************NAUCZYCIEL**********************************
                case 9.4:
                    StałeRozpoczęcie();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Witam naukowca " + Zmienne.imię + ". Jak dobrze ciebie widzieć. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Jestem tylko nauczycielem. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("A już sądziłem, gdy widziałem ciebie w dniu wybuchu, że ");
                    Console.WriteLine("postanowisz wtedy zwiać. Ale to dobrze, bardziej przydasz się żywy. ");
                    Console.WriteLine("Widzisz, mamy tutaj taki problem, podobno jesteś nauczycielm fizyki. ");              
                    Console.WriteLine("Widzisz te schematy? Są one niekompletne. Masz trzy dni, aby uzupełnić ");
                    Console.WriteLine("je i zrobić obliczenia, tak aby moi mechanicy mogli wziąć się za budowę. ");
                    Console.WriteLine("Jeśli chcesz żyć to się pośpiesz. ");

                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;
                case 9.5:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dzięki swemu obeznaniu w tematyce fizyki udaje ci się uzupełnić schematy ");
                    Console.WriteLine("i zrobić obliczenia w dwa dni. Postanawiasz jednak przeszukać warsztat w ");
                    Console.WriteLine("poszukiwaniu czegoś co pomoże ci w ucieczce. ");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Znajdujesz małe buteleczki z naftą i pasek od spodni");
                    Console.WriteLine("(Ekwipunek + <buteleczka z naftą> x2");
                    Console.WriteLine("(Ekwipunek + <pasek od spodni> x1");
                    break;
                case 9.6:
                    StałeRozpoczęcie(); 
                    Console.WriteLine("Nagle widzisz, że lina ze strychu warsztatu prowadzi wprost do wagoników ");
                    Console.WriteLine("których tory prowadzą poza obóz.");
                    Console.WriteLine("");

                    break;
                //********************************NA STACJI************************

                case 9.7:
                    StałeRozpoczęcie();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Witam zapaleńca pracy " + Zmienne.imię + ". Jak dobrze ciebie widzieć. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Jestem zwykłym kolejowym. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("A już sądziłem, gdy widziałem ciebie w dniu wybuchu, że ");
                    Console.WriteLine("postanowisz wtedy zwiać. Ale to dobrze, bardziej przydasz się żywy. ");
                    Console.WriteLine("Widzisz, mamy tutaj taki problem, podobno znasz się na klei.Widzisz te wagony? ");
                    Console.WriteLine("Masz sprawić aby jeździły. Masz trzy dni, aby naprawić, tak aby nie było ");
                    Console.WriteLine("przestoju w kopalnii. Jeśli chcesz żyć to się pośpiesz.");

                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    break;
                case 9.8:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dzięki swemu obeznaniu w tematyce inżynierii (inżynieria = 9) udaje ci się ");
                    Console.WriteLine("naprwić wagony w dwa dni. Postanawiasz jednak przeszukać warsztat w ");
                    Console.WriteLine("poszukiwaniu czegoś co pomoże ci w ucieczce. ");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Znajdujesz małe buteleczki z naftą i pasek od spodni");
                    Console.WriteLine("(Ekwipunek + <buteleczka z naftą> x2");
                    Console.WriteLine("(Ekwipunek + <pasek od spodni> x1");
                    break;
                case 9.9:
                    StałeRozpoczęcie();
                    Console.WriteLine("Nagle widzisz, że lina ze strychu warsztatu prowadzi wprost do wagoników ");
                    Console.WriteLine("których tory prowadzą poza obóz.");
                    Console.WriteLine("");

                    break;
                //**************************************MECHANIK**********************************

                case 10.0:
                    StałeRozpoczęcie();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Witam Inżynierze " + Zmienne.imię + ". Jak dobrze ciebie widzieć. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Jestem tylko mechanikiem. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [kapitan Wasiajew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("A już sądziłem, gdy widziałem ciebie w dniu wybuchu, że ");
                    Console.WriteLine("postanowisz wtedy zwiać. Ale to dobrze, bardziej przydasz się żywy. ");
                    Console.WriteLine("Widzisz, mamy tutaj taki problem, jak mówisz jesteś mechanikimem. Widzisz ");
                    Console.WriteLine("tamtą lokomotywę? Masz trzy dni, aby ją naprawić, jeśli chcesz jeszcze żyć. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji


                    break;

                case 10.1:
                    StałeRozpoczęcie();
                    Console.WriteLine("Dzięki swemu obeznaniu w tematyce inżynierii (inżynieria = 9) udaje ci się ");
                    Console.WriteLine("naprawić lokomotywę w dwa dni. Postanawiasz jednak przeszukać warsztat w ");
                    Console.WriteLine("poszukiwaniu czegoś co pomoże ci w ucieczce. ");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Znajdujesz małe buteleczki z naftą i pasek od spodni");
                    Console.WriteLine("(Ekwipunek + <buteleczka z naftą> x2");
                    Console.WriteLine("(Ekwipunek + <pasek od spodni> x1");

                    break;
                case 10.2:
                    StałeRozpoczęcie();
                    Console.WriteLine("Nagle widzisz, że lina ze strychu warsztatu prowadzi wprost do wagoników ");
                    Console.WriteLine("których tory prowadzą poza obóz.");
                    Console.WriteLine("");
                    break;

                case 10.3:
                    StałeRozpoczęcie();
                    Console.WriteLine("Udaje ci się prefekcyjnie wskoczyć do wagoniku. Odbezpieczasz go i wskakujesz ");
                    Console.WriteLine("do środka. To twoja podróż do wolności");

                    break;
                case 10.4:

                    StałeRozpoczęcie();
                    Console.WriteLine("Twój wagon nagle się zatrzymuje.");

                    Console.Write(" [radziecki strażnik] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("STOYAT!!!!! BO STRELYAYU!!!! ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    

                    break;
                case 10.5:
                    StałeRozpoczęcie();
                    Console.WriteLine("Trafiasz do karceru, dziury w ziemi z kratą u góry. Zostajesz tam pozostawiny ");
                    Console.WriteLine("na deszczu i śniegu na dwa tygodnie. ");
                    Console.WriteLine("");
                    Console.WriteLine("(efekt choroba aktywny)");
                    Console.WriteLine("(-50HP)");


                    break;

                case 10.6:
                    StałeRozpoczęcie();
                    Console.WriteLine("Budzisz się w obozowym szpitalu. Przy łóżku widzisz Władjewa, w lekarskim ");
                    Console.WriteLine("ubiorze.");
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Głupiś ty. Mówiłem ci, że do ucieczki trzeba się przygotować.  ");
                    Console.WriteLine("Wstawaj mamy mało czasu.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("(Odpowiedź spowodowana : Zdrowie Psychiczne = " + Zmienne.zdrowiePsychiczne + "%)");
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Nie można stąd ucieć. To jest niemożliwe. Już tutaj umrę. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Nie trać nadzieji. Masz tutaj mapę, Grigori ją narysował rok ");
                    Console.WriteLine("temu z pamięci, więc może być niedokładna. I jeszcze kompas. ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.Write("");
                    Console.Write("(HP +25)");
                    Console.ReadKey();


                    break;
                case 10.7:
                    StałeRozpoczęcie();
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Weź jeszcze ten pistolet i paczkę naboi. Trzymaj go przy ciele ");
                    Console.WriteLine("najlepiej na brzuchu. Twoja choroba już ustępuje, więc ona ci nie zagraża.  ");
                    Console.WriteLine("Weź moje buty, sweter i płaszcz. Na wzgórzu, pod znakiem jest ukryty plecak ");
                    Console.WriteLine("z suszonym jedzenie, palnik na naftę, rakiety śnieżne i narzędzia. ");
                    Console.WriteLine("Patrol dowie się o twoim zniknięciu dopiero jutro rano przy obchodzie, ");
                    Console.WriteLine("więc w tym czasię będziesz daleko stąd");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji

                    break;
                case 10.8:
                    StałeRozpoczęcie();
                    Console.WriteLine("(Ekwipunek + <mapa> x1");
                    Console.WriteLine("(Ekwipunek + <kompas> x1");
                    Console.WriteLine("(Ekwipunek + <pistolet> x1");
                    Console.WriteLine("(Ekwipunek + <naboje> x50");

                    Console.WriteLine("(efekt choroba nieaktywny)");

                    break;
                case 10.9:
                    StałeRozpoczęcie();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Skąd masz to wszystko? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("To ja miałem uciec...");                   
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.WriteLine("Władjew pośpiesznie, odprowadza się do drzwi szpitala tłumacząc i ");
                    Console.WriteLine("napominając w tak wielu sprawach, że ciężko ci to wszystko zapamiętać.");
                    break;
                case 11.0:
                    StałeRozpoczęcie();
                    Console.Write(" [" + Zmienne.imię + "] -  ");
                    Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                    Console.WriteLine("Dlaczego mi pomagasz? ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Już od miesiąca nie mam złudzeń. Rak. " + Zmienne.imię + " " );
                    Console.WriteLine("mam rodzinę pod Lwowem w Skolnikach. Tu masz adres. Powiedz mojej ");
                    Console.WriteLine("żonie, że wszystko przygotowałem. Powiedz, że umarłem w grudniu.");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.ReadKey();
                    Console.Write(" [Władjew] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("Niee. Powiedz, że w maju. Wyobrazi sobie mogiłę w kwiatach pod ");
                    Console.WriteLine("drzewem. Tak, w maju, przynajmniej to będzie dla niej pocieszeniem.");
                    Console.WriteLine("A teraz idź.");

                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                 
                    break;
                case 11.1:
                    StałeRozpoczęcie();
                    Console.WriteLine("Wychodzisz pośpiesznie na wzgórze. Pod znakiem znajdujesz plecak, ");
                    Console.WriteLine("a w nim suszone jedzenie, palnik na naftę, rakiety śnieżne, sznurki, ");
                    Console.WriteLine("bandarze");
                    Console.WriteLine("");
                    Console.WriteLine("(Ekwipunek + <palnik na naftę> x1");
                    Console.WriteLine("(Ekwipunek + <rakiety śnieżne> x2");
                    Console.WriteLine("(Ekwipunek + <sznurki> x12");
                    Console.WriteLine("(Ekwipunek + <bandarz> x2");
                    

                    break;
                case 11.2:
                    StałeRozpoczęcie();
                    Console.WriteLine("Wyruszasz w podróż po życie lub śmierć. Czujesz się wolny, oszołomiony, ");
                    Console.WriteLine("ale wolny. Przed tobą tylko biała pustka.");
                    //**************************UCIECZKA******************************************************************
                    break;
                case 11.3:


                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                _   _      _               _         ");
                    Console.WriteLine("               | | | |    (_)             | |        ");
                    Console.WriteLine("               | | | | ___ _  ___  ___ ___| | ____ _ ");
                    Console.WriteLine("               | | | |/ __| |/ _ \\/ __|_  / |/ / _` |");
                    Console.WriteLine("               | |_| | (__| |  __/ (__ / /|   < (_| |");
                    Console.WriteLine("                \\___/ \\___|_|\\___|\\___/___|_|\\_\\__,_|");
                    Console.WriteLine("                                                     ");
                                          


                    break;
                case 11.4:
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

                    Console.WriteLine("");
                    Console.WriteLine("Dziękujemy za skorzystanie z wersji demo. Pełna wersja gry już wkrótce* na  ");
                    Console.WriteLine("platformy XBOX ONE,  PLAYSTATION 3, AT89C 8051 i PC");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" *  Jeśli już teraz chcesz zagrać w pełną wersję gry i zgarnąć atrakcyjne ");
                    Console.WriteLine("    nagrody zrób przelew 39,99 zł na konto 58 1248 3635 1110 0000 8352 0241 ");
                    break;




                case 11.5:
                    StałeRozpoczęcie();
                    Console.WriteLine("Całe szczęście masz jeszcze jedzenie, które otrzymałeś od Simona. Niestety ");
                    Console.WriteLine("nie nie udaje ci się rozniecić ognia przy -40 stopniach. Każda próba ");
                    Console.WriteLine("kończy się niepowodzeniem. Dzisiaj musisz zjeść zimne jedzenie.");
                    break;
                case 11.6:
                    StałeRozpoczęcie();
                    Console.WriteLine("Twój organizm się wychładza. Odczuwasz, że chyba jesteś chory.");
                    Console.WriteLine("(efekt choroba aktywny)");
                    break;
                case 11.7:
                    StałeRozpoczęcie();
                    Console.WriteLine("Czujesz się coraz gorzej. Twoje ciał drży w gorączce. Musisz szybko ");
                    Console.WriteLine("znaleźć pomoc. ");
                    break;
                case 11.8:
                    StałeRozpoczęcie();
                    Console.WriteLine("Upadasz, nie mając już sił iść dalej. Twoje zwłoki powoli zasypuje");
                   Console.WriteLine("syberyjski śnieg");
                    break;








                case 100:
                    StałeRozpoczęcie();
                    Console.WriteLine("Pierwsze godziny podróży mijają radośnie. Śpiew i dobry humor opuszczają cię ");
                    Console.WriteLine("gdy zaczynasz odczuwać głód. Lepiej znajdź szybko coś do jedzenia!!");
                  
                    break;
                case 101:
                    StałeRozpoczęcie();
                    Console.WriteLine("Idziesz ociężale wciąż przed siebie z nadzieją na znalezienie jakiegoś  ");
                    Console.WriteLine("jedzenia. Najwyraźniej dzisiaj pójdziesz spać głodny.");
                    
                    break;
                case 102:
                    StałeRozpoczęcie();
                    Console.WriteLine("Idziesz kolejny dziń. Krajobraz się nie zmienia. Wszędzie śnieg, śnieg i ");
                    Console.WriteLine("pustka. Z głodu zaczynasz jeść śnieg co prowadzi do wyziębienia organizmu.");
                    Console.WriteLine("");
                    Console.WriteLine("(efekt przemarznięcie aktywny)");
                    Console.WriteLine("GŁÓD!!! (HP-3)");
                    Console.WriteLine("(Zdrowie Psychiczne - 10)");
                    break;


                case 103:
                    StałeRozpoczęcie();
                    Console.WriteLine("Już nie pamiętasz kiedy wyszedłeś, jak daleko jesteś. Czujesz, że to już ");
                    Console.WriteLine("koniec. Nogi odmawiają ci posłuszeństwa, świat wiruje, a jedyne oczym");
                    Console.WriteLine("marzysz to zjeść pyszny obiad i położyć się spać.");
                    Console.WriteLine("");
                    Console.WriteLine("GŁÓD!!! (HP-6)");
                    Console.WriteLine("(Zdrowie Psychiczne - 10)");
                    break;


                case 104:
                    Console.Clear();
                    Console.WriteLine("          ´´´´´´´´´´´´´´´´´´´ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´´´´`");
                    Console.WriteLine("          ´´´´´´´´´´´´´´´´´¶¶¶¶¶¶´´´´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´´¶¶¶¶´´´´´´´´´´´´´´´´´´´´´´´¶¶¶¶´´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´¶¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´`´´´´´´´´´´´¶¶´´´´´´´´´´`");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´¶¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´¶¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´¶¶´¶¶´´´¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶´´´¶¶´¶¶´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´¶¶¶¶´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶´¶¶¶¶¶´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´¶¶¶´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶´¶¶¶´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´¶¶¶´´´´´´´¶¶´´¶¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶¶¶´´¶¶´´´´´´¶¶¶¶´´´");
                    Console.WriteLine("          ´´´¶¶¶¶¶´´´´´¶¶´´´¶¶¶¶¶¶¶´´´¶¶¶´´´¶¶¶¶¶¶¶´´´¶¶´´´´´¶¶¶¶¶¶´´");
                    Console.WriteLine("          ´´¶¶´´´¶¶´´´´¶¶´´´´´¶¶¶´´´´¶¶¶¶¶´´´´¶¶¶´´´´´¶¶´´´´¶¶´´´¶¶´´");
                    Console.WriteLine("          ´¶¶¶´´´´¶¶¶¶´´¶¶´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´¶¶´´¶¶¶¶´´´´¶¶¶´");
                    Console.WriteLine("          ¶¶´´´´´´´´´¶¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶¶¶´´´´´´´´¶¶");
                    Console.WriteLine("          ¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶´´´´¶¶¶¶¶¶¶´´´´¶¶¶¶¶¶¶¶´´´´´´¶¶¶¶¶¶¶¶");
                    Console.WriteLine("          ´´¶¶¶¶´¶¶¶¶¶´´´´´´¶¶¶¶¶´´´´´´´´´´´´´´¶¶¶´¶¶´´´´´¶¶¶¶¶¶´¶¶¶´");
                    Console.WriteLine("          ´´´´´´´´´´¶¶¶¶¶¶´´¶¶¶´´¶¶´´´´´´´´´´´¶¶´´¶¶¶´´¶¶¶¶¶¶´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´´¶¶¶¶¶¶´¶¶´¶¶¶¶¶¶¶¶¶¶¶´¶¶´¶¶¶¶¶¶´´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´´´´´´¶¶´¶¶´¶´¶´¶´¶´¶´¶´¶´¶´¶¶´´´´´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´´´´´¶¶¶¶´´¶´¶´¶´¶´¶´¶´¶´¶´´´¶¶¶¶¶´´´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´´´´´´´´´¶¶¶¶¶´¶¶´´´¶¶¶¶¶¶¶¶¶¶¶¶¶´´´¶¶´¶¶¶¶¶´´´´´´´´´´´´");
                    Console.WriteLine("          ´´´´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶´´´´´´´´´´´´´´´´´¶¶´´´´´´¶¶¶¶¶¶¶¶¶´´´´");
                    Console.WriteLine("          ´´´¶¶´´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´´´´¶¶¶¶¶¶¶¶´´´´´´´´´´¶¶´´´");
                    Console.WriteLine("          ´´´´¶¶¶´´´´´¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶´´´´´¶¶¶´´´´");
                    Console.WriteLine("          ´´´´´´¶¶´´´¶¶¶´´´´´´´´´´´¶¶¶¶¶¶¶¶¶´´´´´´´´´´´¶¶¶´´´¶¶´´´´´´");
                    Console.WriteLine("          ´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶¶´´´´´´");
                    Console.WriteLine("          ´´´´´´´¶¶¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶¶¶´´´´´´´");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    PRZEGRAŁEŚ");





                    break;
            }

        }

    }

    
}
