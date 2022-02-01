using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder tower = new Neboder (200, 100,0);
            tower.Visina +=10;
            tower.BrojKatova +=1;
            Console.WriteLine("Visina je "+ tower.Visina+"m ");
            Console.WriteLine("Broj katova je " + tower.BrojKatova);
            tower.Prosjek=tower.Visina/tower.BrojKatova;
            Console.WriteLine("prosjek je: "+tower.Prosjek);
            Console.ReadKey();

        }
    }
    class Neboder
    {

      
        private int  visina, brojKatova;
        double prosjek;

        public Neboder(int visina, int brojKatova, double prosjek)
        {
            Visina = visina;
            BrojKatova = brojKatova;
            Prosjek = prosjek;
        }

        public int Visina { get =>visina; set=>visina = value; }
        public int BrojKatova { get => brojKatova;set => brojKatova = value;}

        public double Prosjek { get => prosjek; set => prosjek = value; }



    }
}
