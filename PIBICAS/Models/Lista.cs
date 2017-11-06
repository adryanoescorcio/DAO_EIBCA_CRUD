using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Lista
    {
        public Lista()
        {
            this.Frequencias = new List<Frequencia>();
        }

        public int ListaId { get; set; }
        public int ListaClasseId { get; set; }
        public int ListaAlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Classe Classe { get; set; }
        public virtual ICollection<Frequencia> Frequencias { get; set; }
    }
}
