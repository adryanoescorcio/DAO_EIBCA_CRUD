using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Membresia
    {
        public Membresia()
        {
            this.Classes = new List<Classe>();
        }

        public int MembresiaId { get; set; }
        public int MembresiaUsuarioId { get; set; }
        public int MembresiaIgrejaID { get; set; }
        public int MembresiaPerfilID { get; set; }
        public string MembresiaMatricula { get; set; }
        public string MembresiaStatus { get; set; }
        public virtual ICollection<Classe> Classes { get; set; }
        public virtual Igreja Igreja { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
