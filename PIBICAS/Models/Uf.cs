using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Uf
    {
        public Uf()
        {
            this.Municipios = new List<Municipio>();
        }

        public int UfId { get; set; }
        public string UfSigla { get; set; }
        public string UfNome { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
