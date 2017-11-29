using SF_13_2017.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_SF_13_2016.DAL
{
    public static class RadSaKorisnik
    {
        public static ObservableCollection<Korisnik> GetList()
        {
            return Projekat.Instanca.KorisniciLista;
        }

        public static void Add(Korisnik korisnik)
        {
            var lista = GetList();
            lista.Add(korisnik);
            Projekat.Instanca.KorisniciLista = lista;
        }
    }
}
