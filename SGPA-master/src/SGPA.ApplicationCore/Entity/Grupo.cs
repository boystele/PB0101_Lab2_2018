using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.ApplicationCore.Entity
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public string Descricao { get; set; }
        public List<PassagemAerea> PassagensAerea { get; set; }

    }
}
