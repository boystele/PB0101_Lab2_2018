using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.ApplicationCore.Entity
{
    public class Voo
    {
        public int VooId { get; set; }
        public string Descricao { get; set; }
        public int Numero { get; set; }
        public List<Passagem> Passagens { get; set; }

    }
}
