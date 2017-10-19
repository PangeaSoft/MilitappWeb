using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MilitappWeb.Business
{
    public class LegisladoresGanadoresBusiness
    {
        private LegisladoresGanadoresRepository legisladoresGanadoresRepository = null;
        public LegisladoresGanadoresBusiness()
        {
            legisladoresGanadoresRepository = LegisladoresGanadoresRepository.GetInstancia();
        }

        public object GetList()
        {
            return legisladoresGanadoresRepository.GetList();                        
        }
    }
}
