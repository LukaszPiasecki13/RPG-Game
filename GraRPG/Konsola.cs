using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraRPG
{
     static class Konsola
    {
        static public List<string> pozycjeMenu = new List<string>();
        static public int aktywnaPozycjaMenu = 0;
         
       


       static public void UstawNazwyOpcji2(string a, string b)
        {
            pozycjeMenu.Clear();
            pozycjeMenu.Add(a);
            pozycjeMenu.Add(b);
        }

       static public void UstawNazwyOpcji3(string a, string b, string c)
        {
            pozycjeMenu.Clear();
            pozycjeMenu.Add(a);
            pozycjeMenu.Add(b);
            pozycjeMenu.Add(c);
            
        }

       static public void UstawNazwyOpcji4(string a, string b, string c, string d)
        {
            pozycjeMenu.Clear();
            pozycjeMenu.Add(a);
            pozycjeMenu.Add(b);
            pozycjeMenu.Add(c);
            pozycjeMenu.Add(d);
            
        }
       static public void WypiszMenu(double nrTekstu)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;//kolor tła
            Console.Clear();//Po tej operacji cała konsola w kolorze
            Console.ForegroundColor = ConsoleColor.White; //ust. koloru czcionki  
           
            Teksty.Tekst(nrTekstu); // Tekst powyżej wybieranych opcji                   
            for (int i = 0; i < pozycjeMenu.Count; i++)
            {
                //wyświetlają się pozycje zgodnie z tablicą
                if (i == aktywnaPozycjaMenu)
                {
                    // wartość od - 35 oznacza że pozycja menu zostanie wyświetona 
                    //na 35 znakach i ten tekst będzie równany do lewej
                   
                    Console.BackgroundColor = ConsoleColor.Black;    // kolor tła paska wybranej opcji
                    Console.ForegroundColor = ConsoleColor.White;    // kolor napisu wybranej opcji
                    Console.WriteLine("{0,-35}", pozycjeMenu[i]);        
                    Console.BackgroundColor = ConsoleColor.DarkBlue;   // kolor tła opcji
                    Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                }
                else
                {
                    Console.WriteLine(pozycjeMenu[i]);
                }
            }
        }



      static public void WybieranieOpcji(double nrTekstu)
        {
            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow) //Strzałka w górę
                {
                    //Zmniejszanie aktywnej pozycji i upewniamy się, że nie jest to pozycja na samej górze
                    //Zrealizowano to za pomocą operatora warunkowego
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu > 0) ? aktywnaPozycjaMenu - 1 : pozycjeMenu.Count - 1;
                    WypiszMenu(nrTekstu);
                }
                else if (klawisz.Key == ConsoleKey.DownArrow) //Strzałka w dół
                {
                    //inny sposób realizacji. Można było zrobić jak wyżej
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu + 1) % pozycjeMenu.Count;
                    WypiszMenu(nrTekstu);
                }
                
                else if (klawisz.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (klawisz.Key == ConsoleKey.E)
                {
                    bool pętla = true;
                    while (pętla)
                    {
                        if (Zmienne.onEkwipunek == false)
                        {
                            Statystyki.WypiszEkwipunek();
                            Console.ReadKey();
                            Zmienne.onEkwipunek = true;

                        }
                        else if (Zmienne.onEkwipunek == true)
                        {
                            Zmienne.onEkwipunek = false;
                            pętla = false;

                        }

                    }
                    WypiszMenu(nrTekstu);
                }
                else if (klawisz.Key == ConsoleKey.F1)
                {
                    bool pętla = true;
                    while (pętla)
                    {
                        if (Zmienne.onEkwipunek == false)
                        {
                            Statystyki.WypiszPomoc();
                            Console.ReadKey();
                            Zmienne.onEkwipunek = true;

                        }
                        else if (Zmienne.onEkwipunek == true)
                        {
                            Zmienne.onEkwipunek = false;
                            pętla = false;
                            


                        }
                    }

                    WypiszMenu(nrTekstu);
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    bool pętla = true;
                    while (pętla)
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



                        }
                    }

                    WypiszMenu(nrTekstu);
                }

            }
            while (true);
        }





       
    }
}






















      /*  KONSOLA PIERWSZA
       *  
       *  while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>Przykładowe Menu Proste<<<");
                Console.WriteLine("1. Opcja pierwsza");
                Console.WriteLine("2. Opcja druga");
                Console.WriteLine("2. Koniec");


                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); opcjaWBudowie(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); opcjaWBudowie(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default: break;*/