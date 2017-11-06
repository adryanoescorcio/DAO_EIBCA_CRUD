using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Denominacao
    {
        public Denominacao()
        {
            this.Igrejas = new List<Igreja>();
        }

        public int DenominacaoId { get; set; }
        public string DenominacaoNome { get; set; }
        public virtual ICollection<Igreja> Igrejas { get; set; }
    }
}
