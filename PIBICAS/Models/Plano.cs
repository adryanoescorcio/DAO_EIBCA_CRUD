using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Plano
    {
        public Plano()
        {
            this.ClassePlanoAulas = new List<ClassePlanoAula>();
            this.Frequencias = new List<Frequencia>();
        }

        public int PlanoId { get; set; }
        public int PlanoClasseId { get; set; }
        public string PlanoDescricao { get; set; }
        public string PlanoProfessor { get; set; }
        public System.DateTime PlanoDataPrevista { get; set; }
        public int PlanoHoraAula { get; set; }
        public string PlanoObservacao { get; set; }
        public string PlanoUsuario { get; set; }
        public System.DateTime PlanoTempo { get; set; }
        public string PlanoTipoOperacao { get; set; }
        public string PlanoRastro { get; set; }
        public virtual ICollection<ClassePlanoAula> ClassePlanoAulas { get; set; }
        public virtual Classe Classe { get; set; }
        public virtual ICollection<Frequencia> Frequencias { get; set; }
    }
}
