using SF_13_2017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_13_2017
{
    class Program
    {
        private static List<Namestaj> Namestaj = new List<Namestaj>();
        private static List<TipNamestaja> TipoviNamestaja = new List<TipNamestaja>();
        static void Main(string[] args)
        {
            Salon s1 = new Salon()
            {
                Id = 1,
                Adresa = "Trg Dositeja Obradovica 6",
                BrojZiroRacuna = "840-000171666-45",
                Email = "dekan@ftn.uns.ac.rs",
                MaticniBroj = 324324324,
                Naziv = "Forma FTNale",
                PIB = 123213,
                Telefon = "021/454-3434",
                WebSajt = "http://www.ftn.uns.ac.rs"
            };

            var tp1 = new TipNamestaja()
            {
                Id = 1,
                Naziv = "Krevet"
            };
            var namestaj1 = new Namestaj()
            {
                Id = 1,
                Cena = 777,
                TipNamestaja = tp1,
                Naziv = "Ekstra krevet socijalni",
                KolicinaUMagacinu = 100,
                Sifra = "KR3993434SC",

            };
            Namestaj.Add(namestaj1);

            Console.WriteLine($"===== Dobrodosli u salon namestaja {s1.Naziv}=====");
            Console.ReadLine();
        }

        private static void IspisiGlavniMeni()
        {
            int izbor = 0;
            do
            {
                do
                {
                    Console.WriteLine("==== GLAVNI MENI =====");
                    Console.WriteLine("1. Rad sa namestajem");
                    Console.WriteLine("2. Rad sa tipom namestaja");
                    //... dovrsiti
                    Console.WriteLine("0. Izlaz iz aplikacije");

                    izbor = int.Parse(Console.ReadLine());
                } while (izbor < 0 || izbor > 2);
                switch (izbor)
                {
                    case 1:
                        NamestajMeni();
                        break;
                    default:
                        break;
                }

            } while (izbor != 0);
        }

        private static void NamestajMeni()
        {
            int izbor = 0;
            do
            {
                do
                {
                    Console.WriteLine("===== RAD SA NAMESTAJEM =====");
                    IspisiCRUDMeni();

                    izbor = int.Parse(Console.ReadLine());
                } while (izbor < 0 || izbor > 4);

                switch (izbor)
                {
                    case 1:
                        PrikaziNamestaj();
                        break;
                    case 2:
                        DodajNamestaj();
                        break;

                    default:
                        break;
                }

            } while (izbor != 0);


        }

        private static void DodajNamestaj()
        {
            Console.WriteLine("===== DODAJ NAMESTAJ ====");
            Console.WriteLine("Id: ");
            Console.WriteLine("Naziv: ");
            Console.WriteLine("Sifra: ");
            Console.WriteLine("Cena: ");
            Console.WriteLine("Kolicina u magacinu: ");
            Console.WriteLine("Tip namestaja: ");


        }

        private static void PrikaziNamestaj()
        {
            Console.WriteLine("==== LISTING NAMESTAJA ====");

            for (int i = 0; i < Namestaj.Count; i++)
            {
                Console.WriteLine($"{i + 1}. naziv: {Namestaj[i].Naziv}, cena: {Namestaj[i].Cena}");
            }
        }

        private static void IspisiCRUDMeni()
        {
            Console.WriteLine("1. Prikazi listing");
            Console.WriteLine("2. Dodaj novi");
            Console.WriteLine("3. Izmeni postojeci");
            Console.WriteLine("4. Obrisi postojeci");
            Console.WriteLine("0. Povratak na glavni meni");
        }
    }
}
