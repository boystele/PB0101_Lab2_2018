using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.ApplicationCore.Entity
{
    public class Passagem
    {
        public int PassagemId { get; set; }
        public DateTime DataEmissao { get; set; }
        public Double Valor { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<PassagemAerea> PassagensAerea { get; set; }



    }
}
