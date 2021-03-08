using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GraRPG
{
    class Statystyki
    {
        public static void WypiszEkwipunek()
        {
            Console.Clear();
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^ EKWIPUNEK -_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine();
            foreach (DictionaryEntry obiekt in Zmienne.ekwipunek)
            {
                Console.Write("-> {0}", obiekt.Key + " (");
                Console.ForegroundColor = ConsoleColor.Yellow;    //kolor napisów opcji
                Console.Write(obiekt.Value);
                Console.ForegroundColor = ConsoleColor.White;    //kolor napisów opcji
                Console.WriteLine(")");
            }
            Console.WriteLine();
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^ STATYSTYKI _^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine("");
            Console.WriteLine("HP : " + Zmienne.HP + "%");
            Console.WriteLine("ZDROWIE PSYCHICZNE :" + Zmienne.zdrowiePsychiczne + "%");
            Console.WriteLine("Siła : " + Zmienne.siła );
            Console.WriteLine("Charyzma : " + Zmienne.charyzma );
            Console.WriteLine("Inżynieria : " + Zmienne.inżynieria);
            Console.WriteLine("Wiedza o przetrwaniu : " + Zmienne.wiedzaOPrzetrwaniu);
            Console.WriteLine("Logistyka : " + Zmienne.logistyka);
            Console.WriteLine("Celność : " + Zmienne.celność);


        }

        public static void WypiszPomoc()
        {
            Console.Clear();
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^ PRZEWODNIK _^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_");
            Console.WriteLine("-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-_^-");
            Console.WriteLine();
            Console.WriteLine("LISTA RUCHÓW");
            Console.WriteLine("'e'- ekwipunek");
            Console.WriteLine("'Esc' - zapis i wyjście");
            Console.WriteLine("'F1'- przewodnik");
            Console.WriteLine("'enter'- przejdź dalej");
            Console.WriteLine("'strzałka w górę'- poprzednia opcja dialogowa");
            Console.WriteLine("'strzałka w dół' - następna opcja dialogowa");
            Console.WriteLine();
            Console.WriteLine("LISTA POJĘĆ");
            Console.WriteLine("niedożywienie - efekt ten sprawia, że przez dostarczenie zbyt małej ilości ");
            Console.WriteLine("                energii do organizmu, stajesz się mniej spostrzegawczy i ");
            Console.WriteLine("                błyskotliwy czego efektem jest niewyświetlanie się niektórych ");
            Console.WriteLine("                opcji dialogowych.");
            Console.WriteLine("");
            Console.WriteLine("przemarznięcie - przekształca się w chorobę w czasie zależnym od ilości twoich ");
            Console.WriteLine("                 punktów HP.");
            Console.WriteLine("");
            Console.WriteLine("odwodnienie - efekt ten sprawia, że jesteś bardziej podatny na choroby, ");
            Console.WriteLine("              otrzymujesz karę do odnowy Zdrowia Psychinego. Powoduje, że ");
            Console.WriteLine("              podczas choroby twój organizm nie podejmuje walki z chorobą ");
            Console.WriteLine("               ");
            Console.WriteLine("choroba - jeśli nie użyjesz lekarstwa twoja postać zacznie tracić punkty HP.");
            Console.WriteLine("          Jeśli twoja postać dodatkowo jest odwodniona, to jej organizm nie ");
            Console.WriteLine("          próby zwalczenia choroby.");
            Console.WriteLine("");
            Console.WriteLine("HP - twoje punkty zdrowia, jeśli ten wskaźnik dojdzie do 0% to umierasz.");
            Console.WriteLine("");
            Console.WriteLine("Zdrowie Psychiczne - wskaźnik obrazujący jak blisko jesteś załamania. ");
            Console.WriteLine("                     Gdy wskaźnik spadnie poniżej 20%, może się okazać, że ");
            Console.WriteLine("                     myśli w twojej głowie zaczną mieszać się z rzeczywistością.");
        }
    }
}
