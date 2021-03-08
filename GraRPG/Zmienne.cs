using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace GraRPG
{
    static class Zmienne
    {
        public static string imię { set; get; }
        public static int zdrowiePsychiczne { set; get; } = 50;

        public static int liczbaLiterImienia { set; get; }
        public static int HP { set; get; } = 12;
        public static string przemarznięcie { set; get; } = "Przemarznięcie";
        public static string niedożywienie { set; get; } = "Niedożywienie";
        public static string odwodnienie { set; get; } = "Odwonienie";
        public static string choroba { set; get; } = "";
        public static int wybranaHistoria { set; get; }
        public static int zmiennaUżyteczna { set; get; }
        public static double krok { set; get; }
        public static bool onEkwipunek { set; get; } = false;
        public static int siła { set; get; }
        public static int charyzma { set; get; }
        public static int inżynieria { set; get; }
        public static int logistyka { set; get; }
        public static int wiedzaOPrzetrwaniu { set; get; }
        public static int celność { set; get; }

        //************EKWIPUNEK****************
        public static SortedList ekwipunek = new SortedList();





        
    }
}
