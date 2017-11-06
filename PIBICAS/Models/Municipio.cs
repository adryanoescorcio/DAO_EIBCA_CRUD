using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            this.Usuarios = new List<Usuario>();
        }

        public int MunicipioId { get; set; }
        public int MunicipioUdIf { get; set; }
        public string MunicipioNome { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual Uf Uf { get; set; }
    }
}
