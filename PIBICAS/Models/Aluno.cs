using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIBICAS.Models
{
    public partial class Aluno
    {
        public Aluno()
        {
            this.Listas = new List<Lista>();
        }
        
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; }
        public string AlunoCPF { get; set; }
        public string AlunoSituacao { get; set; }
        public string AlunoRepetir { get; set; }
        public System.DateTime AlunoDataNascimento { get; set; }
        public System.DateTime AlunoDataMatricula { get; set; }
        public string AlunoCelular1 { get; set; }
        public string AlunoCelular2 { get; set; }
        public string AlunoEscolaridade { get; set; }
        public string AlunoEquipe { get; set; }
        public string AlunoCelula { get; set; }
        public string AlunoDiscipulador { get; set; }
        public Nullable<System.DateTime> AlunoBatismo { get; set; }
        public string AlunoUsuario { get; set; }
        public System.DateTime AlunoTempo { get; set; }
        public string AlunoTipoOperacao { get; set; }
        public string AlunoRastro { get; set; }
        public virtual ICollection<Lista> Listas { get; set; }
    }
}
