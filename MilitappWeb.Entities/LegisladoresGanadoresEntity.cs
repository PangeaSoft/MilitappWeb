using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class LegisladoresGanadoresEntity
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Ent_LegisladoresGanadores_Designer))]
        public int lca_id { get; set; }
        [Display(Name = "LastName", ResourceType = typeof(Resources.Ent_LegisladoresGanadores_Designer))]
        public int can_id { get; set; }
        [Display(Name = "NombreLista", ResourceType = typeof(Resources.Ent_LegisladoresGanadores_Designer))]
        public int lcc_orden { get; set; }
        public TbCandidatoEntity tbcandidato { get; set; }
        public TbListaCargoEntity tblistacargo { get; set; }
        [Display(Name = "Votos", ResourceType = typeof(Resources.Ent_LegisladoresGanadores_Designer))]
        public decimal lcc_votos_correspondientes { get; set; }
    }
}