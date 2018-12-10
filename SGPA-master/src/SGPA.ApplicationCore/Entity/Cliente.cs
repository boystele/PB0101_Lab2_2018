using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.ApplicationCore.Entity
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Passagem> Passagens { get; set; }
        public Endereco Enderecos { get; set; }
    }
}
