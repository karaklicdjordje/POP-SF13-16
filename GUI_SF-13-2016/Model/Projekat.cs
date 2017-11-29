using SF_13_2017.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_13_2017.Model
{
    public class Projekat
    {
        public static Projekat Instanca { get; private set; } = new Projekat();
        
        private ObservableCollection<TipNamestaja> tipoviNamestajaLista;
        private ObservableCollection<Namestaj> namestajLista;
        private ObservableCollection<Akcija> akcijeLista;
        private ObservableCollection<DodatneUsluge> dodatneUslugeLista;
        private ObservableCollection<Korisnik> korisniciLista;
        private ObservableCollection<Prodaja> prodajaNamestajaLista;
        private ObservableCollection<Salon> salonLista;

        public ObservableCollection<TipNamestaja> TipoviNamestajaLista
        {
            get
            {
                tipoviNamestajaLista = GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");
                return tipoviNamestajaLista;
            }
            set
            {
                tipoviNamestajaLista = value;
                GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", tipoviNamestajaLista);
            }
        }

        public ObservableCollection<Namestaj> NamestajLista
        {
            get
            {
                namestajLista = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");
                return namestajLista;
            }
            set
            {
                namestajLista = value;
                GenericSerializer.Serialize<Namestaj>("namestaj.xml", namestajLista);
            }
        }

        public ObservableCollection<Akcija> AkcijeLista
        {
            get
            {
                akcijeLista = GenericSerializer.Deserialize<Akcija>("akcija.xml");
                return akcijeLista;
            }
            set
            {
                akcijeLista = value;
                GenericSerializer.Serialize<Akcija>("akcija.xml", akcijeLista);
            }
        }

        public ObservableCollection<DodatneUsluge> DodatneUslugeLista
        {
            get
            {
                dodatneUslugeLista = GenericSerializer.Deserialize<DodatneUsluge>("dodatne_usluge.xml");
                return dodatneUslugeLista;
            }
            set
            {
                dodatneUslugeLista = value;
                GenericSerializer.Serialize<DodatneUsluge>("dodatne_usluge.xml", dodatneUslugeLista);
            }
        }

        public ObservableCollection<Korisnik> KorisniciLista
        {
            get
            {
                korisniciLista = GenericSerializer.Deserialize<Korisnik>("korisnici.xml");
                return korisniciLista;
            }
            set
            {
                korisniciLista = value;
                GenericSerializer.Serialize<Korisnik>("korisnici.xml", korisniciLista);
            }
        }

        
        public ObservableCollection<Prodaja> ProdajaNamestaja
        {
            get
            {
                prodajaNamestajaLista = GenericSerializer.Deserialize<Prodaja>("prodaja_namestaja.xml");
                return prodajaNamestajaLista;
            }
            set
            {
                prodajaNamestajaLista = value;
                GenericSerializer.Serialize<Prodaja>("prodaja_namestaja.xml", prodajaNamestajaLista);
            }
        }
        

        public ObservableCollection<Salon> SalonLista
        {
            get
            {
                salonLista = GenericSerializer.Deserialize<Salon>("salon.xml");
                return salonLista;
            }
            set
            {
                salonLista = value;
                GenericSerializer.Serialize<Salon>("salon.xml", salonLista);
            }
        }
    }
}
