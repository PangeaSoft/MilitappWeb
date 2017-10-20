using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MilitappWeb.Business
{
    public class DiputadosGanadoresBusiness
    {
        private DiputadosGanadoresRepository legisladoresGanadoresRepository = null;
        public DiputadosGanadoresBusiness()
        {
            legisladoresGanadoresRepository = DiputadosGanadoresRepository.GetInstancia();
        }

        public object GetList()
        {
            return legisladoresGanadoresRepository.GetList();                        
        }
        
    }
}
