using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class PlanillasAbiertasCerradasEntity
    {
        public int indice { get; set; }
        public int pla_id { get; set; }
        public DateTime ele_fecha { get; set; }
        public int esc_id { get; set; }
        public int mes_id { get; set; }
        public int fis_id {get;set;}
        public DateTime pla_apertura {get;set;}
        public DateTime pla_cierre { get; set; }
        public int pla_sobres {get;set;}
        public List<TbplanillaCargoEntity> tbplanillacargo {get;set;}
        public List<TbresultadoEntity> tbresultado {get;set;}
    }
}
