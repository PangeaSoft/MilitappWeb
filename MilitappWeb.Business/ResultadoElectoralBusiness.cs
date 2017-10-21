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

        public List<VotosPorMesaEntity> GetListVotosPorMesa(ResultadoElectoralEntity resultados, List<LegisladoresGanadoresEntity> diputados, List<LegisladoresGanadoresEntity> legisladores)
        {
            List<VotosPorMesaEntity> list = new List<VotosPorMesaEntity>();
            foreach (PlanillaEntity elem in resultados.ListaPlanillas)
            {                
                int mes_id = elem.mes_id;
                foreach(TbresultadoEntity elem2 in elem.tbresultado){
                    VotosPorMesaEntity obj = new VotosPorMesaEntity();
                    obj.mes_id = mes_id;
                    obj.lca_id = elem2.lca_id;                    
                    obj.pca_cantidad_votos = elem2.res_cantidad_votos;
                    list.Add(obj);
                }                
            }
            var resul2 = legisladores.Select(x => new { x.tblistacargo.tblista.lis_descripcion, x.tblistacargo.lca_id }).Distinct().ToList();
            var resul = diputados.Select(x => new { x.tblistacargo.tblista.lis_descripcion, x.tblistacargo.lca_id }).Distinct().ToList();
            foreach (VotosPorMesaEntity elem in list)
            {
                foreach (var elem2 in resul2.Where(w => w.lca_id == elem.lca_id))                
                    elem.nombreLista = elem2.lis_descripcion + " - Legisladores";                
                foreach (var elem2 in resul.Where(w => w.lca_id == elem.lca_id)) 
                    elem.nombreLista = elem2.lis_descripcion + " - Diputados";                
            }
            return list;
        }        
    }
}
