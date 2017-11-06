using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class ClassePlanoAula
    {
        public int ClassePlanoAulaId { get; set; }
        public int ClasseId { get; set; }
        public int PlanoAulaId { get; set; }
        public virtual Classe Classe { get; set; }
    }
}
