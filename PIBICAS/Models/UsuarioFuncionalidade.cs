using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class UsuarioFuncionalidade
    {
        public int UsuarioFuncionalidadeId { get; set; }
        public int UsuarioID { get; set; }
        public int FuncionalidadeId { get; set; }
        public string UsuarioFuncionalidadePrincipal { get; set; }
        public string UsuarioFuncionalidadeUsuario { get; set; }
        public System.DateTime UsuarioFuncionalidadeTempo { get; set; }
        public string UsuarioFuncionalidadeTipoOperacao { get; set; }
        public string UsuarioFuncionalidadeRastro { get; set; }
        public virtual Funcionalidade Funcionalidade { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
