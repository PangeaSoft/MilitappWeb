using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class TbplanillaCargoEntity : PlanillaEntity
    {
        public int pla_id { get; set; }
        public int car_id { get; set; }
        public int pca_cantidad_votos { get; set; }
    }
}
