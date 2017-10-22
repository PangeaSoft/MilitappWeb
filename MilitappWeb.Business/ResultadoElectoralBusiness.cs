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


        public int[] GetDatosComunaMesa(ResultadoElectoralEntity obj)
        {            

            int[] mesasPorComuna = Enumerable.Repeat(0, 15).ToArray();                       
            foreach (PlanillaEntity elem in obj.ListaPlanillas)
            {
                if (elem.mes_id <= 519)
                    mesasPorComuna[0] = mesasPorComuna[0] + 1;
                else if (elem.mes_id <= 936)
                    mesasPorComuna[1] = mesasPorComuna[1] + 1;
                else if (elem.mes_id <= 1406)
                    mesasPorComuna[2] = mesasPorComuna[2] + 1;
                else if (elem.mes_id <= 1926)
                    mesasPorComuna[3] = mesasPorComuna[3] + 1;
                else if (elem.mes_id <= 2387)
                    mesasPorComuna[4] = mesasPorComuna[4] + 1;
                else if (elem.mes_id <= 2851)
                    mesasPorComuna[5] = mesasPorComuna[5] + 1;
                else if (elem.mes_id <= 3356)
                    mesasPorComuna[6] = mesasPorComuna[6] + 1;
                else if (elem.mes_id <= 3756)
                    mesasPorComuna[7] = mesasPorComuna[7] + 1;
                else if (elem.mes_id <= 4183)
                    mesasPorComuna[8] = mesasPorComuna[8] + 1;
                else if (elem.mes_id <= 4617)
                    mesasPorComuna[9] = mesasPorComuna[9] + 1;
                else if (elem.mes_id <= 5119)
                    mesasPorComuna[10] = mesasPorComuna[10] + 1;
                else if (elem.mes_id <= 5666)
                    mesasPorComuna[11] = mesasPorComuna[11] + 1;
                else if (elem.mes_id <= 6297)
                    mesasPorComuna[12] = mesasPorComuna[12] + 1;
                else if (elem.mes_id <= 6904)
                    mesasPorComuna[13] = mesasPorComuna[13] + 1;
                else
                    mesasPorComuna[14] = mesasPorComuna[14] + 1;
            }
            return mesasPorComuna;
        }

        public List<VotosPorMesaEntity> GetListVotosPorMesa(ResultadoElectoralEntity resultados, List<LegisladoresGanadoresEntity> diputados, List<LegisladoresGanadoresEntity> legisladores)
        {
            List<VotosPorMesaEntity> list = new List<VotosPorMesaEntity>();
            var indice = 1;
            foreach (PlanillaEntity elem in resultados.ListaPlanillas)
            {                
                VotosPorMesaEntity obj = new VotosPorMesaEntity();
                obj.mes_id = elem.mes_id;
                List<int> votosPorCadaLista = new List<int>();
                foreach(TbresultadoEntity elem2 in elem.tbresultado){                                        
                    //obj.lca_id = elem2.lca_id;                                        
                    votosPorCadaLista.Add(elem2.res_cantidad_votos);                    
                }
                int aux = 0;
                foreach (int votos in votosPorCadaLista)
                {
                    switch (aux){
                        case 0:
                            obj.lca1 = votos;
                            break;
                        case 1:
                            obj.lca2 = votos;
                            break;
                        case 2:
                            obj.lca3 = votos;
                            break;
                        case 3:
                            obj.lca4 = votos;
                            break;
                        case 4:
                            obj.lca5 = votos;
                            break;
                        case 5:
                            obj.lca6 = votos;
                            break;
                        case 6:
                            obj.lca7 = votos;
                            break;
                        default:
                            obj.lca8 = votos;
                            break;
                    }
                    aux++;
                }                                    
                obj.id = indice;
                list.Add(obj);
                indice++;
            }
            /*
            var resul2 = legisladores.Select(x => new { x.tblistacargo.tblista.lis_descripcion, x.tblistacargo.lca_id }).Distinct().ToList();
            var resul = diputados.Select(x => new { x.tblistacargo.tblista.lis_descripcion, x.tblistacargo.lca_id }).Distinct().ToList();
            foreach (VotosPorMesaEntity elem in list)
            {
                foreach (var elem2 in resul2.Where(w => w.lca_id == elem.lca_id))                
                    elem.nombreLista = elem2.lis_descripcion + " - Legisladores";                
                foreach (var elem2 in resul.Where(w => w.lca_id == elem.lca_id)) 
                    elem.nombreLista = elem2.lis_descripcion + " - Diputados";                
            }
             */
            return list;
        }        
    }
}
