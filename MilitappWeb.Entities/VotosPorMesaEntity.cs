using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class VotosPorMesaEntity
    {

        public int id { get; set; }
        [Display(Name = "Mesa", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int mes_id { get; set; }

        [Display(Name = "listaCandidato", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int lca_id { get; set; }
        [Display(Name = "votosPorFuerza", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int lca1 { get; set; }
        public int lca2 { get; set; }
        public int lca3 { get; set; }
        public int lca4 { get; set; }
        public int lca5 { get; set; }
        public int lca6 { get; set; }
        public int lca7 { get; set; }
        public int lca8 { get; set; }

        public string nombreLista { get; set; }
    }
}
