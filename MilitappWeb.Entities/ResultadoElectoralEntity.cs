using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class ResultadoElectoralEntity
    {
        public List<PorcentajeResultadoDiputadosEntity> PorcentajeResultadoDiputados { get; set; }
        public List<PorcentajeResultadoLegisladoresEntity> PorcentajeResultadoLegisladores { get; set; }
        public List<CantidadVotosDiputadosEntity> CantidadVotosDiputados { get; set; }
        public List<CantidadVotosLegisladoresEntity> CantidadVotosLegisladores { get; set; }
        public List<PlanillaEntity> ListaPlanillas { get; set; }
    }
}

