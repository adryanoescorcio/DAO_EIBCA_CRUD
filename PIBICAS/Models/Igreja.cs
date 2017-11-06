using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Igreja
    {
        public Igreja()
        {
            this.Membresias = new List<Membresia>();
        }

        public int IgrejaId { get; set; }
        public int IgrejaDenominacaoId { get; set; }
        public string IgrejaNome { get; set; }
        public string IgrejaTelefone { get; set; }
        public string IgrejaSlogan { get; set; }
        public string IgrejaSigla { get; set; }
        public string IgrejaEndereco { get; set; }
        public string IgrejaBairro { get; set; }
        public byte[] IgrejaLogo { get; set; }
        public string IgrejaMunicipio { get; set; }
        public string IgrejaEstado { get; set; }
        public virtual Denominacao Denominacao { get; set; }
        public virtual ICollection<Membresia> Membresias { get; set; }
    }
}
