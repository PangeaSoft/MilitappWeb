using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class VotosPorMesaEntity
    {
        [Display(Name = "Mesa", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int mes_id { get; set; }

        [Display(Name = "listaCandidato", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int lca_id { get; set; }
        [Display(Name = "votosPorFuerza", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int pca_cantidad_votos { get; set; }

        public string nombreLista { get; set; }
    }
}
