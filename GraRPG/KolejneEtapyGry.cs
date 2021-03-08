using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
   static class KolejneEtapyGry
    {
          
       

     static public void WybórHistorii(int aktywnaPozycjaMenu)
        {

            switch (aktywnaPozycjaMenu)
            {
                case 0://chciał pomóc opadłemu z sił mężczyźnie
                    Zmienne.HP = Zmienne.HP - 2;
                    Teksty.Tekst(5.0);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(5.0);

                    Teksty.Tekst(6.0);
                    Console.CursorVisible = true; //Widoczność kursora
                    Zmienne.imię = Console.ReadLine();
                    Console.CursorVisible = false; //Widoczność kursora

                    Konsola.UstawNazwyOpcji4("   Pracuję jako elektryk w Białymstku. Wraz z żoną przeprowadziliśmy się tam z  Łodzi w " +
                        "1934, gdy dostałem ofertę pracy w tamtejszej elektrowni. Wcześniej      byłem sierżantem w wojsku. " +
                        "Po wybuchu wojny przydzielono mnie pod dowództwo     ppłk Dąbrowskiego. Z nim również walczyłem z sowietami pod Puszczą " +
                        "Augustowską  gdzie straciliśmy trzeci szwadron ułanów. Później po rozwiązaniu oddziału       towarzyszyłem mjr.'Hubalowi'" +
                        "aż do czasu gdy rozkazał mi wracać i ratować swoją  córeczkę, bo przewidywał co szykują sowieci.              " +   
                        "                                                                                                        " +
                        "                                                                              " ,

                        " Jestem nauczycielem fizyki w Łomżańskiej szkole. Prowadzę tam również drużynę  harcerską. Ci mali " +
                        "bohaterowie to prawdziwi królowie lasu, potrafią sami        przetrwać w niebezpiecznej dziczy. Niestety po " +
                        "wybuchu wojny większość z nich   zaciągnęła się do wojska. Miejmy nadzieję, że Bóg ich ustrzeże. Ja natomiast    uczyłem " +
                        "dalej w szkole, starając się nie zwracać na siebie uwagi władz          sowieckich. Jednogo dnia usłyszałem, jak żołnierze" +
                        "rozmawiali na temat wywózki   okolicznej ludności na Sybir. Tego dnia wróciłem wcześniej do domu.                  " +
                        "                                                                                                                      " +
                        "                                     ",

                        "  Pracowałem na stacji PKP. Odkąd wybuchła wojna i rosjanie przejęli stacje,    był to okropny czas. Ponieważ " +
                        "dobrze znamłem całą infrastrukturę, pozwolili mi  pracować. Podobno przybyli w pokoju, aby ratować ludność cywilną, " +
                        "a jednak  ich transporty były w większości wojskowe. Nie wszyscy rosjanie byli źli.           Zaprzyjaźniłem się z pewnym " +
                        "Simonem, dobry facet. Jego zadaniem było dbać, aby  kolej nieprzerwanie sprawna. Pewnego dnia zapytał się czy " +
                        "mam dzieci,           odpowiedziałem, że mam córeczkę, małego aniołka. Uśmiechnął się współczująco,   dał suszoną " +
                        "słoninę i trzy konserwy, i powiedział, abym użył tego tylko wtedy,  gdy już nawet trawa nie będzie pożywieniem, i " +
                        "kazał szybko wracać do rodziny.                                                                                        " +
                        "                                                                           ",
                        "  Byłem mechanikiem w zakładach stalowych w Łowiczu. Moim zadaniem było         naprawianie oraz konserwacja maszyn." +
                        "Po wkroczeniu sowietów 17 września nasza    fabryka była jednym z pierwszych celów do przejęcia. Całą fabrykę " +
                        "zagarnięto,   niektórych pracowników wyrzucon zastępując ich swoją własną brygadą. Jako wyższynad mechanikami " +
                        "musiałem zostać, aby produkcja mogła być kontynuowana. Pewnego  dnia kazano nam wcześniej wyjść z pracy do domów.");
                    Konsola.WypiszMenu(6.1);
                    Konsola.WybieranieOpcji(6.1);
                    switch( Konsola.aktywnaPozycjaMenu)
                    {
                        case 0:
                            Zmienne.wybranaHistoria = 0;                                                    
                                                                                 
                            Zmienne.ekwipunek.Add("płaszcz wojska Polskiego", 1);
                            Zmienne.ekwipunek.Remove("stary płaszcz");
                            Zmienne.ekwipunek.Add("krzesiwo", 1);
                            Zmienne.ekwipunek.Add("penicylina", 1);
                            Zmienne.siła = 8;
                            Zmienne.charyzma = 4;
                            Zmienne.inżynieria = 8;
                            Zmienne.wiedzaOPrzetrwaniu = 9;
                            Zmienne.logistyka = 6;
                            Zmienne.celność = 9;
                            
                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <płaszcz wojska Polskiego> x1");
                            Console.WriteLine("(Ekwipunek - <stary płaszcz> x1");
                            Console.WriteLine("(Ekwipunek + <krzesiwo> x1");
                            Console.WriteLine("(Ekwipunek + <penicylina> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            
                            Konsola.aktywnaPozycjaMenu = 0;
                            break;
                        case 1:
                            Zmienne.wybranaHistoria = 1;
                                                      
                            Zmienne.ekwipunek.Add("ołówek", 1);
                            Zmienne.ekwipunek.Add("notatnik", 1);
                            Zmienne.ekwipunek.Add("krzesiwo", 1);
                            Zmienne.ekwipunek.Add("penicylina", 1);
                            Zmienne.siła = 6;
                            Zmienne.charyzma = 8;
                            Zmienne.inżynieria = 5;
                            Zmienne.wiedzaOPrzetrwaniu = 9;
                            Zmienne.logistyka = 7;
                            Zmienne.celność = 8;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <ołówek> x1");
                            Console.WriteLine("(Ekwipunek + <notatnik> x1");
                            Console.WriteLine("(Ekwipunek + <krzesiwo> x1");
                            Console.WriteLine("(Ekwipunek + <penicylina> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;

                            break;
                        case 2:
                            Zmienne.wybranaHistoria = 2;
                          
                            Zmienne.ekwipunek.Add("papierosy", 30);
                            Zmienne.ekwipunek.Add("monety", 10);
                            Zmienne.ekwipunek.Add("kawałek suszonej słoniny", 4);
                            Zmienne.ekwipunek.Add("konserwy", 3);
                            Zmienne.siła = 7;
                            Zmienne.charyzma = 5;
                            Zmienne.inżynieria = 9;
                            Zmienne.wiedzaOPrzetrwaniu = 6;
                            Zmienne.logistyka = 9;
                            Zmienne.celność = 5;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <papierosy> x30");
                            Console.WriteLine("(Ekwipunek + <monety> x10");
                            Console.WriteLine("(Ekwipunek + <kawałek suszonej słoniny> x4");
                            Console.WriteLine("(Ekwipunek + <konserwy> x3");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;
                            break;
                        case 3:
                            Zmienne.wybranaHistoria = 3;
                            Zmienne.ekwipunek.Add("ołówek", 1);
                            Zmienne.ekwipunek.Add("notatnik", 1);
                            Zmienne.ekwipunek.Add("papierosy", 30);
                            Zmienne.ekwipunek.Add("monety", 10);
                            Zmienne.ekwipunek.Add("klucz nasadowy 13", 1);
                            Zmienne.siła = 7;
                            Zmienne.charyzma = 5;
                            Zmienne.inżynieria = 9;
                            Zmienne.wiedzaOPrzetrwaniu = 6;
                            Zmienne.logistyka = 5;
                            Zmienne.celność = 6;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <ołówek> x1");
                            Console.WriteLine("(Ekwipunek + <notatnik> x1");
                            Console.WriteLine("(Ekwipunek + <papierosy> x30");
                            Console.WriteLine("(Ekwipunek + <monety> x10");
                            Console.WriteLine("(Ekwipunek + <klucz nasadowy 13> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;
                            break;


                    }

                    break;

                case 1: //nie pomógł opadłemu z sił mężczyźnie
                    Teksty.Tekst(5.1);
                   WypisywanieEkwipunku.OnOffEkwipunekOkro(5.1);
                    Teksty.Tekst(6.0);
                    Console.CursorVisible = true; //Widoczność kursora
                    Zmienne.imię = Console.ReadLine();
                    Console.CursorVisible = false; //Widoczność kursora

                    Konsola.UstawNazwyOpcji4("   Pracuję jako elektryk w Białymstku. Wraz z żoną przeprowadziliśmy się tam z  Łodzi w " +
                        "1934, gdy dostałem ofertę pracy w tamtejszej elektrowni. Wcześniej      byłem sierżantem w wojsku. " +
                        "Po wybuchu wojny przydzielono mnie pod dowództwo     ppłk Dąbrowskiego. Z nim również walczyłem z sowietami pod Puszczą " +
                        "Augustowską  gdzie straciliśmy trzeci szwadron ułanów. Później po rozwiązaniu oddziału       towarzyszyłem mjr.'Hubalowi'" +
                        "aż do czasu gdy rozkazał mi wracać i ratować swoją  córeczkę, bo przewidywał co szykują sowieci.              " +
                        "                                                                                                        " +
                        "                                                                              ",

                        " Jestem nauczycielem fizyki w Łomżańskiej szkole. Prowadzę tam również drużynę  harcerską. Ci mali " +
                        "bohaterowie to prawdziwi królowie lasu, potrafią sami        przetrwać w niebezpiecznej dziczy. Niestety po " +
                        "wybuchu wojny większość z nich   zaciągnęła się do wojska. Miejmy nadzieję, że Bóg ich ustrzeże. Ja natomiast    uczyłem " +
                        "dalej w szkole, starając się nie zwracać na siebie uwagi władz          sowieckich. Jednogo dnia usłyszałem, jak żołnierze" +
                        "rozmawiali na temat wywózki   okolicznej ludności na Sybir. Tego dnia wróciłem wcześniej do domu.                  " +
                        "                                                                                                                      " +
                        "                                     ",

                        "  Pracowałem na stacji PKP. Odkąd wybuchła wojna i rosjanie przejęli stacje,    był to okropny czas. Ponieważ " +
                        "dobrze znamłem całą infrastrukturę, pozwolili mi  pracować. Podobno przybyli w pokoju, aby ratować ludność cywilną, " +
                        "a jednak  ich transporty były w większości wojskowe. Nie wszyscy rosjanie byli źli.           Zaprzyjaźniłem się z pewnym " +
                        "Simonem, dobry facet. Jego zadaniem było dbać, aby  kolej nieprzerwanie sprawna. Pewnego dnia zapytał się czy " +
                        "mam dzieci,           odpowiedziałem, że mam córeczkę, małego aniołka. Uśmiechnął się współczująco,   dał suszoną " +
                        "słoninę i trzy konserwy, i powiedział, abym użył tego tylko wtedy,  gdy już nawet trawa nie będzie pożywieniem, i " +
                        "kazał szybko wracać do rodziny.                                                                                        " +
                        "                                                                           ",
                        "  Byłem mechanikiem w zakładach stalowych w Łowiczu. Moim zadaniem było         naprawianie oraz konserwacja maszyn." +
                        "Po wkroczeniu sowietów 17 września nasza    fabryka była jednym z pierwszych celów do przejęcia. Całą fabrykę " +
                        "zagarnięto,   niektórych pracowników wyrzucon zastępując ich swoją własną brygadą. Jako wyższynad mechanikami " +
                        "musiałem zostać, aby produkcja mogła być kontynuowana. Pewnego  dnia kazano nam wcześniej wyjść z pracy do domów.");
                    Konsola.WypiszMenu(6.1);
                    Konsola.WybieranieOpcji(6.1);
                    switch (Konsola.aktywnaPozycjaMenu)
                    {
                        case 0:
                            Zmienne.wybranaHistoria = 0;

                            Zmienne.ekwipunek.Add("płaszcz wojska Polskiego", 1);
                            Zmienne.ekwipunek.Remove("stary płaszcz");
                            Zmienne.ekwipunek.Add("krzesiwo", 1);
                            Zmienne.ekwipunek.Add("penicylina", 1);
                            Zmienne.siła = 8;
                            Zmienne.charyzma = 4;
                            Zmienne.inżynieria = 8;
                            Zmienne.wiedzaOPrzetrwaniu = 9;
                            Zmienne.logistyka = 6;
                            Zmienne.celność = 9;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <płaszcz wojska Polskiego> x1");
                            Console.WriteLine("(Ekwipunek - <stary płaszcz> x1");
                            Console.WriteLine("(Ekwipunek + <krzesiwo> x1");
                            Console.WriteLine("(Ekwipunek + <penicylina> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);

                            Konsola.aktywnaPozycjaMenu = 0;
                            break;
                        case 1:
                            Zmienne.wybranaHistoria = 1;

                            Zmienne.ekwipunek.Add("ołówek", 1);
                            Zmienne.ekwipunek.Add("notatnik", 1);
                            Zmienne.ekwipunek.Add("krzesiwo", 1);
                            Zmienne.ekwipunek.Add("penicylina", 1);
                            Zmienne.siła = 6;
                            Zmienne.charyzma = 8;
                            Zmienne.inżynieria = 5;
                            Zmienne.wiedzaOPrzetrwaniu = 9;
                            Zmienne.logistyka = 7;
                            Zmienne.celność = 8;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <ołówek> x1");
                            Console.WriteLine("(Ekwipunek + <notatnik> x1");
                            Console.WriteLine("(Ekwipunek + <krzesiwo> x1");
                            Console.WriteLine("(Ekwipunek + <penicylina> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;

                            break;
                        case 2:
                            Zmienne.wybranaHistoria = 2;

                            Zmienne.ekwipunek.Add("papierosy", 30);
                            Zmienne.ekwipunek.Add("monety", 10);
                            Zmienne.ekwipunek.Add("kawałek suszonej słoniny", 4);
                            Zmienne.ekwipunek.Add("konserwy", 3);
                            Zmienne.siła = 7;
                            Zmienne.charyzma = 5;
                            Zmienne.inżynieria = 9;
                            Zmienne.wiedzaOPrzetrwaniu = 6;
                            Zmienne.logistyka = 9;
                            Zmienne.celność = 5;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <papierosy> x30");
                            Console.WriteLine("(Ekwipunek + <monety> x10");
                            Console.WriteLine("(Ekwipunek + <kawałek suszonej słoniny> x4");
                            Console.WriteLine("(Ekwipunek + <konserwy> x3");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;
                            break;
                        case 3:
                            Zmienne.wybranaHistoria = 3;
                            Zmienne.ekwipunek.Add("ołówek", 1);
                            Zmienne.ekwipunek.Add("notatnik", 1);
                            Zmienne.ekwipunek.Add("papierosy", 30);
                            Zmienne.ekwipunek.Add("monety", 10);
                            Zmienne.ekwipunek.Add("klucz nasadowy 13", 1);
                            Zmienne.siła = 7;
                            Zmienne.charyzma = 5;
                            Zmienne.inżynieria = 9;
                            Zmienne.wiedzaOPrzetrwaniu = 6;
                            Zmienne.logistyka = 5;
                            Zmienne.celność = 6;

                            Teksty.StałeRozpoczęcie();
                            Console.WriteLine("(Ekwipunek + <ołówek> x1");
                            Console.WriteLine("(Ekwipunek + <notatnik> x1");
                            Console.WriteLine("(Ekwipunek + <papierosy> x30");
                            Console.WriteLine("(Ekwipunek + <monety> x10");
                            Console.WriteLine("(Ekwipunek + <klucz nasadowy 13> x1");
                            Console.ReadKey();
                            Teksty.Tekst(6.2);
                            Konsola.aktywnaPozycjaMenu = 0;
                            break;
                    }
                            break;

            }

        }

      static  public void WybuchWObozie(int aktywnaPozycjaMenu)
        {
            switch (aktywnaPozycjaMenu)
            {
                case 0://Oddalasz się
                    Teksty.StałeRozpoczęcie();
                    Console.WriteLine("Udaje ci się oddalić od tłumu, przemykasz między barakami niezauważony. ");
                    Console.WriteLine("Z daleka słyszysz jeszcze krzyk kobiety. ");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("... oto nadchodzi wiek miecza i topora, wiek wilczej ");
                    Console.WriteLine("zamieci. Nadchodzi Czas Białego Zimna i Białego Światła....  ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji          
                    Console.ReadKey();
                    Console.WriteLine("Dobiegasz do granicy obozu. Wszyscy strażnicy są zajęci wybuchem, dziwisz ");
                    Console.WriteLine("się, że jeszcze słyszysz głos kobiety.");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("...wojna... wojna nigdy się nie zmienia...(strzał)  ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Zmienne.krok = 100;
                    Console.ReadKey();
                    
                    break;

                case 1://bierzesz scyzoryk
                    Teksty.StałeRozpoczęcie();
                    Console.WriteLine("Postanowiłeś podnieść <solidny scyzoryk>. Udaje ci się niepostrzeżenie ");
                    Console.WriteLine("podczołagać i podnieść <solidny scyzoryk>(ekwipunek + <solidny scyzoryk>)");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Zmienne.ekwipunek.Add("solidny scyzoryk", 1);
                    Console.WriteLine("Wszyscy, nawet sam oficer są oszołomieni. Głos kobiety niesie się ");
                    Console.WriteLine("pomiędzy budynkami.");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("... oto nadchodzi wiek miecza i topora, wiek wilczej ");
                    Console.WriteLine("zamieci. Nadchodzi Czas Białego Zimna i Białego Światła....  ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji          
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Pył zaczął opadać, początkowe oszołomienie przerodziło się w strach ");
                    Console.WriteLine("spowodowany rozkazami wydawanymi przez żołnierzy. Inne kobiety, nieskutecznie ");
                    Console.WriteLine("starały się uspokoić krzyczącą biedaczkę. ");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.Write("...wojna... wojna nigdy się nie zmienia...");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("(strzał) ");
                    Console.WriteLine("( Zdrowie Psychiczne -3% )");
                    Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne - 3;
                    Console.ReadKey();
                    Teksty.StałeRozpoczęcie();
                    Console.WriteLine("Zapadła cisza. Już nikt nie krzyczał. Bezwładne ciało kobiety, z dziurą w ");
                    Console.WriteLine("głowie opadło na śnieg. Jeszcz można było zauważyć dym unoszący z nad lufy ");
                    Console.WriteLine("pistoletu oficera.");
                    Zmienne.krok++;
                    break;

                case 2:// nic nie robisz
                    Teksty.StałeRozpoczęcie();
                    Console.WriteLine("Leżysz bez ruchu i czekasz. ");
                    Console.ReadKey();
                    Console.WriteLine("Wszyscy, nawet sam oficer są oszołomieni. Głos kobiety niesie się");
                    Console.WriteLine("pomiędzy budynkami.");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.WriteLine("... oto nadchodzi wiek miecza i topora, wiek wilczej ");
                    Console.WriteLine("zamieci. Nadchodzi Czas Białego Zimna i Białego Światła....  ");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji          
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Pył zaczął opadać, początkowe oszołomienie przerodziło się w strach ");
                    Console.WriteLine("spowodowany rozkazami wydawanymi przez żołnierzy. Inne kobiety, nieskutecznie ");
                    Console.WriteLine("starały się uspokoić krzyczącą biedaczkę. ");
                    Console.Write(" [Załamana kobieta] -  ");
                    Console.ForegroundColor = ConsoleColor.Green;    //kolor napisów opcji
                    Console.Write("...wojna... wojna nigdy się nie zmienia...");
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                    Console.WriteLine("(strzał) ");
                    Console.WriteLine("( Zdrowie Psychiczne -3% )");
                    Zmienne.zdrowiePsychiczne = Zmienne.zdrowiePsychiczne - 3;
                    Console.ReadKey();
                    Teksty.StałeRozpoczęcie();
                    Console.WriteLine("Zapadła cisza. Już nikt nie krzyczał. Bezwładne ciało kobiety, z dziurą w ");
                    Console.WriteLine("głowie opadło na śnieg. Jeszcz można było zauważyć dym unoszący z nad lufy ");
                    Console.WriteLine("pistoletu oficera.");
                    Zmienne.krok++;
                    break;
               
            }

        }


        static public void RozmowaWBaraku(int aktywnaPozycjaMenu)
        {
            switch (aktywnaPozycjaMenu)
            {
                case 0: //Opowiadasz o ucieczce
                    Teksty.Tekst(7.7);
                    Zmienne.krok++;
                    break;

                case 1:
                    Teksty.Tekst(7.8);
                    Zmienne.krok++;
                    break;

            }

        }

        static public void WybórStrategiiPracy(int aktywnaPozycjaMenu)
        {
            switch (aktywnaPozycjaMenu)
            {
                case 0: //Opowiadasz o ucieczce
                    Zmienne.niedożywienie = "";
                    Teksty.Tekst(8.2);
                    Console.ReadKey();
                    Zmienne.krok++;
                    break;

                case 1:
                    Teksty.Tekst(8.3);
                    Console.ReadKey();
                    Zmienne.krok++;
                    break;

            }

        }



        static public void WWarsztacie(int wybranaHistoria)
        {
            switch (wybranaHistoria)
            {
                case 0:
                    Teksty.Tekst(9.1);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.1);
                    Teksty.Tekst(9.2);
                    Zmienne.ekwipunek.Add("buteleczka z naftą", 2);
                    Zmienne.ekwipunek.Add("pasek od spodni", 1);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.2);
                    Teksty.Tekst(9.3);
                    Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku. ",
                                   "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                   "zostać i pracować dla dobra komunizmu. ");
                    Konsola.WypiszMenu(9.3);
                    Konsola.WybieranieOpcji(9.3);
                    bool chybasobie = true;
                    while (chybasobie)
                    {
                        switch (Konsola.aktywnaPozycjaMenu)
                        {
                            case 0:
                                chybasobie = false;
                                break;

                            case 1:
                                Teksty.StałeRozpoczęcie();
                                Console.Write(" [" + Zmienne.imię + "] -  ");
                                Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                                Console.WriteLine("No chyba sobie żartujesz!");
                                Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji  Console.WriteLine("");
                                Console.ReadKey();
                                Teksty.Tekst(9.3);
                                Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku.  " +
                                    "                                                                                              ",
                                               "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                               "zostać i pracować dla dobra komunizmu. ");
                                Konsola.WypiszMenu(9.3);
                                Konsola.WybieranieOpcji(9.3);
                                break;

                        }
                    }

                    break;

                case 1:
                    Teksty.Tekst(9.4);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.4);
                    Teksty.Tekst(9.5);
                    Zmienne.ekwipunek.Add("buteleczka z naftą", 2);
                    Zmienne.ekwipunek.Add("pasek od spodni", 1);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.5);
                    Teksty.Tekst(9.6);
                    Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku. ",
                                   "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                   "zostać i pracować dla dobra komunizmu. ");
                    Konsola.WypiszMenu(9.6);
                    Konsola.WybieranieOpcji(9.6);
                    chybasobie = true;
                    while (chybasobie)
                    {
                        switch (Konsola.aktywnaPozycjaMenu)
                        {
                            case 0:
                                chybasobie = false;
                                break;

                            case 1:
                                Teksty.StałeRozpoczęcie();
                                Console.Write(" [" + Zmienne.imię + "] -  ");
                                Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                                Console.WriteLine("No chyba sobie żartujesz!");
                                Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji  Console.WriteLine("");
                                Console.ReadKey();
                                Teksty.Tekst(9.6);
                                Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku.  " +
                                    "                                                                                              ",
                                               "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                               "zostać i pracować dla dobra komunizmu. ");
                                Konsola.WypiszMenu(9.6);
                                Konsola.WybieranieOpcji(9.6);
                                break;

                        }
                    }

                    break;
                case 2:
                    Teksty.Tekst(9.7);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.7);
                    Teksty.Tekst(9.8);
                    Zmienne.ekwipunek.Add("buteleczka z naftą", 2);
                    Zmienne.ekwipunek.Add("pasek od spodni", 1);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(9.8);
                    Teksty.Tekst(9.9);
                    Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku. ",
                                   "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                   "zostać i pracować dla dobra komunizmu. ");
                    Konsola.WypiszMenu(9.9);
                    Konsola.WybieranieOpcji(9.9);
                    chybasobie = true;
                    while (chybasobie)
                    {
                        switch (Konsola.aktywnaPozycjaMenu)
                        {
                            case 0:
                                chybasobie = false;
                                break;

                            case 1:
                                Teksty.StałeRozpoczęcie();
                                Console.Write(" [" + Zmienne.imię + "] -  ");
                                Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                                Console.WriteLine("No chyba sobie żartujesz!");
                                Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji  Console.WriteLine("");
                                Console.ReadKey();
                                Teksty.Tekst(9.9);
                                Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku.  " +
                                    "                                                                                              ",
                                               "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                               "zostać i pracować dla dobra komunizmu. ");
                                Konsola.WypiszMenu(9.9);
                                Konsola.WybieranieOpcji(9.9);
                                break;
                        }
                    }
                        break;
                case 3:
                    Teksty.Tekst(10.0);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(10.0);
                    Teksty.Tekst(10.1);
                    Zmienne.ekwipunek.Add("buteleczka z naftą", 2);
                    Zmienne.ekwipunek.Add("pasek od spodni", 1);
                    WypisywanieEkwipunku.OnOffEkwipunekOkro(10.1);
                    Teksty.Tekst(10.2);
                    Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku. ",
                                   "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                   "zostać i pracować dla dobra komunizmu. ");
                    Konsola.WypiszMenu(10.2);
                    Konsola.WybieranieOpcji(10.2);
                    chybasobie = true;
                    while (chybasobie)
                    {
                        switch (Konsola.aktywnaPozycjaMenu)
                        {
                            case 0:
                                chybasobie = false;
                                break;

                            case 1:
                                Teksty.StałeRozpoczęcie();
                                Console.Write(" [" + Zmienne.imię + "] -  ");
                                Console.ForegroundColor = ConsoleColor.Red;    //kolor napisów opcji
                                Console.WriteLine("No chyba sobie żartujesz!");
                                Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji  Console.WriteLine("");
                                Console.ReadKey();
                                Teksty.Tekst(10.2);
                                Konsola.UstawNazwyOpcji2("Użyj <pasek od spodni> aby zjechać po linie wprost do wagoniku.  " +
                                    "                                                                                              ",
                                               "Czując komunistycznego ducha i obowiązek do Sovetskiy Soyuz postanawiasz " +
                                               "zostać i pracować dla dobra komunizmu. ");
                                Konsola.WypiszMenu(10.2);
                                Konsola.WybieranieOpcji(10.2);
                                break;
                        }
                    }
                    break;

            }

        }


        static public void DlaTychNiemądrych()
        {
            
                switch (Zmienne.wybranaHistoria)
                {
                    case 0:
                        Zmienne.krok = 120;
                        break;

                    case 1:
                        Zmienne.krok = 120;
                        break;
                    case 2:
                    Zmienne.krok++;
                        break;
                    case 3:
                        Zmienne.krok = 120;
                        break;
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
