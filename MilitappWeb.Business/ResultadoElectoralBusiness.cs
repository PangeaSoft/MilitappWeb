using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Business
{
    public class ResultadoElectoralBusiness
    {
        private ResultadoElectoralRepository resultadoElectoralRepository = null;
        public ResultadoElectoralBusiness()
        {
            resultadoElectoralRepository = ResultadoElectoralRepository.GetInstancia();
        }

        public object GetList()
        {
            return resultadoElectoralRepository.GetList();                        
        }


        private double[] dontToArray(List<DontEntity> lObjDipu, List<DontEntity> lObjLeg)
        {
            List<DontEntity> result = lObjDipu.Concat(lObjLeg).OrderBy(x => x.id).ToList<DontEntity>();
            List<double> resul = new List<double>();
            foreach (DontEntity elem in result)
            {
                resul.Add(elem.cantidadVotos);                
            }
            return resul.ToArray();
        }

        public double[] datosGraficoBarra(ResultadoElectoralEntity obj)
        {
            List<DontEntity> datosDiputados = new List<DontEntity>();
            foreach (PorcentajeResultadoDiputadosEntity elem in obj.PorcentajeResultadoDiputados)
            {
                DontEntity ob = new DontEntity();
                ob.cantidadVotos = elem.lca_porcentaje_votos;
                ob.id = elem.lca_id;
                datosDiputados.Add(ob);
            }
            List<DontEntity> datosLegisladores = new List<DontEntity>();
            foreach (PorcentajeResultadoLegisladoresEntity elem in obj.PorcentajeResultadoLegisladores)
            {
                DontEntity ob = new DontEntity();
                ob.cantidadVotos = elem.lca_porcentaje_votos;
                ob.id = elem.lca_id;
                datosLegisladores.Add(ob);
            }

            return dontToArray(datosLegisladores, datosDiputados);
        }
    }
}
