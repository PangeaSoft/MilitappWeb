using MilitappWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilitappWeb.Web.Models
{
    public class ResultadosGeneralesDiscriminadoModel
    {
        public List<ResultadoElectoralEntity> ListaResultadoElectoral;
        public ResultadoElectoralEntity ResultadoElectoral;
        public LegisladoresGanadoresEntity Funcionarios;
        public List<LegisladoresGanadoresEntity> Legisladores;
        public List<LegisladoresGanadoresEntity> Diputados;
        public List<VotosPorMesaEntity> ListaVotosPorMesa;
        public VotosPorMesaEntity votosPorMesa;
    }
}