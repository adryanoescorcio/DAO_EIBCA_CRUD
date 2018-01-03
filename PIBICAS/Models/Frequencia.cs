using System;
using System.Collections.Generic;

namespace PIBICAS.Models
{
    public partial class Frequencia
    {
        public int FrequenciaId { get; set; }
        public int PlanoId { get; set; }
        public int ClasseId { get; set; }
        public int ListaId { get; set; }
        public string FrequenciaSituacao { get; set; }
        public String FrequenciaUnique { get; set; }
        public System.DateTime FrequenciaData { get; set; }
        public string FrequenciaUsuario { get; set; }
        public System.DateTime FrequenciaTempo { get; set; }
        public string FrequenciaTipoOperacao { get; set; }
        public string FrequenciaRastro { get; set; }
        public virtual Classe Classe { get; set; }
        public virtual Plano Plano { get; set; }
        public virtual Lista Lista { get; set; }
    }
}
