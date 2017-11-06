using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Acesso
    {
        public int AcessoId { get; set; }
        public int AcessoUsuarioID { get; set; }
        public System.DateTime AcessoDataEntrada { get; set; }
        public Nullable<System.DateTime> AcessoDataSaida { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
