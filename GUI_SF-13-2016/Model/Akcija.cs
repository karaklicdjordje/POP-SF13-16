using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_13_2017.Model
{ 
    public class Akcija //asdasdasd
    {
        public int Id{ get; set; }
        public DateTime DatumPocetka { get; set; }
        public decimal Popust { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public bool Obrisana { get; set; }
    }
}
