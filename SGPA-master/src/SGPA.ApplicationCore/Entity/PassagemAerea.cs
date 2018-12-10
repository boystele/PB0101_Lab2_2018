using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.ApplicationCore.Entity
{
    public class PassagemAerea
    {
        public int PassagemAereaId { get; set; }
        public int PassagemId { get; set; }
        public Passagem Passagem { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
    }
}
