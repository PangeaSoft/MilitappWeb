using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class PlanillaEntity
    {
        public int pla_id { get; set; }
        public DateTime ele_fecha { get; set; }
        public int esc_id { get; set; }
        [Display(Name = "Mesa", ResourceType = typeof(Resources.Ent_VotosPorMesaEntity_Designer))]
        public int mes_id { get; set; }
        public int fis_id { get; set; }
        public int pla_electores { get; set; }
        public int pla_sobres { get; set; }
        public List<TbplanillaCargoEntity> tbplanillacargo { get; set; }
        public List<TbresultadoEntity> tbresultado { get; set; }

    }
}
