using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class CantidadVotosDiputadosEntity : PorcentajeResultadoDiputadosEntity
    {
        public int lca_id { get; set; }
        public int lis_id { get; set; }
        public int car_id { get; set; }
        public List<TbListaCandidatoCargoEntity> tblistacandidatocargo { get; set; }
        public List<TbresultadoEntity> tbresultado { get; set; }
        public double lca_porcentaje_votos { get; set; }
        public double lca_cantidad_votos { get; set; }
    }
}
