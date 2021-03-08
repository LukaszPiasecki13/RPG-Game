using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace GraRPG
{
    static class ZapisWczyt
    {
        static public void Zapisz()
        {
            try
            {
                using (StreamWriter zapisz = new StreamWriter("C:/GraRPGŁP.txt"))
                {
                    
                    zapisz.WriteLine(Zmienne.imię);
                    zapisz.WriteLine(Zmienne.zdrowiePsychiczne);
                    zapisz.WriteLine(Zmienne.liczbaLiterImienia);
                    zapisz.WriteLine(Zmienne.HP);
                    zapisz.WriteLine(Zmienne.przemarznięcie);
                    zapisz.WriteLine(Zmienne.niedożywienie);
                    zapisz.WriteLine(Zmienne.odwodnienie);
                    zapisz.WriteLine(Zmienne.choroba);
                    zapisz.WriteLine(Zmienne.wybranaHistoria);
                    zapisz.WriteLine(Zmienne.zmiennaUżyteczna);
                    zapisz.WriteLine(Zmienne.krok);
                    zapisz.WriteLine(Zmienne.onEkwipunek);
                    zapisz.WriteLine(Zmienne.siła);
                    zapisz.WriteLine(Zmienne.charyzma);
                    zapisz.WriteLine(Zmienne.inżynieria);
                    zapisz.WriteLine(Zmienne.logistyka);
                    zapisz.WriteLine(Zmienne.wiedzaOPrzetrwaniu);
                    zapisz.WriteLine(Zmienne.celność);
                   


                    foreach (DictionaryEntry obiekt in Zmienne.ekwipunek)
                    {
                        zapisz.WriteLine();
                        zapisz.WriteLine(obiekt.Key);
                        zapisz.WriteLine(obiekt.Value);
                        


                    }





                }
             
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
            






        static public void Wczytaj()
        {
            try
            {
                using (StreamReader wczytaj = new StreamReader("c:/GraRPGŁP.txt"))
                {

                    Zmienne.ekwipunek.Clear();
                    Zmienne.imię = wczytaj.ReadLine();

                    Zmienne.zdrowiePsychiczne = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.liczbaLiterImienia = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.HP = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.przemarznięcie = wczytaj.ReadLine();
                    Zmienne.niedożywienie = wczytaj.ReadLine();
                    Zmienne.odwodnienie = wczytaj.ReadLine();
                    Zmienne.choroba = wczytaj.ReadLine();
                    Zmienne.wybranaHistoria = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.zmiennaUżyteczna = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.krok = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.onEkwipunek = Convert.ToBoolean(wczytaj.ReadLine());
                    Zmienne.siła = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.charyzma = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.inżynieria = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.logistyka = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.wiedzaOPrzetrwaniu = Int32.Parse(wczytaj.ReadLine());
                    Zmienne.celność = Int32.Parse(wczytaj.ReadLine());
                    while (wczytaj.ReadLine() != null)
                    {
                        Zmienne.ekwipunek.Add(wczytaj.ReadLine(), Int32.Parse(wczytaj.ReadLine()));
                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
            
        
    }
}
