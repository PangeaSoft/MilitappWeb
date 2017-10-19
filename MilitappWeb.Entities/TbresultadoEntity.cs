using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class TbresultadoEntity : PlanillaEntity
    {
        public int lca_id { get; set; }
        public int pla_id { get; set; }
        public int res_cantidad_votos { get; set; }      
    }
}
