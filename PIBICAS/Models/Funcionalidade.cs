using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Funcionalidade
    {
        public Funcionalidade()
        {
            this.UsuarioFuncionalidades = new List<UsuarioFuncionalidade>();
        }

        public int FuncionalidadeId { get; set; }
        public string FuncionalidadeNome { get; set; }
        public string FuncionalidadeUsuario { get; set; }
        public System.DateTime FuncionalidadeTempo { get; set; }
        public string FuncionalidadeTipoOperacao { get; set; }
        public string FuncionalidadeRastro { get; set; }
        public virtual ICollection<UsuarioFuncionalidade> UsuarioFuncionalidades { get; set; }
    }
}
