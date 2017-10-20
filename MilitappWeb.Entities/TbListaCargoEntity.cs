using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class TbListaCargoEntity
    {
        [Display(Name = "listaCandidato", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int lca_id { get; set; }
        public int lis_id { get; set; }
        public int car_id { get; set; }
        public TbListaEntity tblista { get; set; }
        public object[] tblistacandidatocargo { get; set; }
        public object[] tbresultado { get; set; }
    }
}
