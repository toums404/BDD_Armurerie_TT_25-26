using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.Entites
{
    public class Vente
    {
        public int IdVente { get; set; }
        public DateTime DateVente { get; set; }
        public int IdClient { get; set; }
        public string TypeDocument { get; set; }

    }
}
