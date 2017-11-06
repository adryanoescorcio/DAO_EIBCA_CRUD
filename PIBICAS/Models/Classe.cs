using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Classe
    {
        public Classe()
        {
            this.ClassePlanoAulas = new List<ClassePlanoAula>();
            this.Planoes = new List<Plano>();
            this.Listas = new List<Lista>();
            this.Frequencias = new List<Frequencia>();
        }

        public int ClasseId { get; set; }
        public int ClasseMembresiaId { get; set; }
        public string ClasseCodigo { get; set; }
        public System.DateTime ClasseDataInicio { get; set; }
        public System.DateTime ClasseDataFim { get; set; }
        public string ClasseObservacao { get; set; }
        public string ClasseCargaHoraria { get; set; }
        public string ClasseStatus { get; set; }
        public string ClasseUsuario { get; set; }
        public System.DateTime ClasseTempo { get; set; }
        public string ClasseTipoOperacao { get; set; }
        public string ClasseRastro { get; set; }
        public virtual ICollection<ClassePlanoAula> ClassePlanoAulas { get; set; }
        public virtual Membresia Membresia { get; set; }
        public virtual ICollection<Plano> Planoes { get; set; }
        public virtual ICollection<Lista> Listas { get; set; }
        public virtual ICollection<Frequencia> Frequencias { get; set; }
    }
}
