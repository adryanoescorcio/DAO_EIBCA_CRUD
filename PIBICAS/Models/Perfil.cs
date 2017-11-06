using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            this.Membresias = new List<Membresia>();
        }

        public int PerfilId { get; set; }
        public string PerfilNome { get; set; }
        public int PerfilNivel { get; set; }
        public virtual ICollection<Membresia> Membresias { get; set; }
    }
}
