using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MilitappWeb.Business
{
    public class LegisladorGanadoresBusiness
    {
        private LegisladorGanadoresRepository legisladorGanadoresRepository = null;
        public LegisladorGanadoresBusiness()
        {
            legisladorGanadoresRepository = LegisladorGanadoresRepository.GetInstancia();
        }

        public object GetList()
        {
            return legisladorGanadoresRepository.GetList();
        }
    }
}
