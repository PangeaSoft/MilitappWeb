using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MilitappWeb.Business
{
    public class PlanillasAbiertasCerradasBusiness
    {
        private PlanillasAbiertasCerradasRepository planillasAbiertasCerradasRepository = null;
        public PlanillasAbiertasCerradasBusiness()
        {
            planillasAbiertasCerradasRepository = PlanillasAbiertasCerradasRepository.GetInstancia();
        }

        
        public int[] datosGraficoBarra(List<PlanillasAbiertasCerradasEntity> list)
        {
                    
            int[] mesasPorComuna = Enumerable.Repeat(0, 15).ToArray();                       
            foreach (PlanillasAbiertasCerradasEntity elem in list)
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
        public object GetList()
        {
            return planillasAbiertasCerradasRepository.GetList();
        }
    }
}
