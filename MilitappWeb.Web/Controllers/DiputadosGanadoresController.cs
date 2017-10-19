using MilitappWeb.Business;
using MilitappWeb.Entities;
using MilitappWeb.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace MilitappWeb.Web.Controllers
{
    public class DiputadosGanadoresController : Controller
    {

        public ActionResult Index()
        {
            LegisladoresGanadoresBusiness diputadosGanadoresBusiness = new LegisladoresGanadoresBusiness();            
            DiputadosGanadoresModel model = new DiputadosGanadoresModel();
            model.ListaDiputadosGanadores = (List<LegisladoresGanadoresEntity>)JsonConvert.DeserializeObject(diputadosGanadoresBusiness.GetList().ToString(), typeof(List<LegisladoresGanadoresEntity>));            
            return View(model);
        }

    }
}

