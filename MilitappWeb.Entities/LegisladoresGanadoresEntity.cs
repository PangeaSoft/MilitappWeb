using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class LegisladoresGanadoresEntity
    {
        public int lca_id { get; set; }
        public int can_id { get; set; }
        public int lcc_orden { get; set; }
        public TbCandidatoEntity tbcandidato { get; set; }
        public TbListaCargoEntity tblistacargo { get; set; }
        public decimal lcc_votos_correspondientes { get; set; }
    }
}