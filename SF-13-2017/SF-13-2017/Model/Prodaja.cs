﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_13_2017.Model
{
    public class Prodaja
    {
        public List<Namestaj> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string BrojRacuna { get; set; }
        public string Kupac { get; set; }
        public List<DodatneUsluge> DodatneUsluge { get; set; }

        public const double PDV = 0.02;
        public double UkupnaCena { get; set; }
    }
}

