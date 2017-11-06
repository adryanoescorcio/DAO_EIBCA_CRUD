using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Acessoes = new List<Acesso>();
            this.Membresias = new List<Membresia>();
            this.UsuarioFuncionalidades = new List<UsuarioFuncionalidade>();
        }

        public int UsuarioId { get; set; }
        public Nullable<int> UsuarioMunicipioId { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioSobrenome { get; set; }
        public string UsuarioDetalhes { get; set; }
        public string UsuarioSexo { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioCPF { get; set; }
        public int UsuarioTentativaErro { get; set; }
        public string UsuarioTrocarSenha { get; set; }
        public System.DateTime UsuarioDataValidade { get; set; }
        public string UsuarioStatus { get; set; }
        public string UsuarioUsuario { get; set; }
        public System.DateTime UsuarioTempo { get; set; }
        public string UsuarioTipoOperacao { get; set; }
        public string UsuarioRastro { get; set; }
        public virtual ICollection<Acesso> Acessoes { get; set; }
        public virtual ICollection<Membresia> Membresias { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual ICollection<UsuarioFuncionalidade> UsuarioFuncionalidades { get; set; }
    }
}
