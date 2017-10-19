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
    public class PersonaController : Controller
    {
        public ActionResult Index()
        {           
            ResultadoElectoralBusiness resultadoElectoralBusiness = new ResultadoElectoralBusiness();
            ResultadoElectoralModel modelo = new ResultadoElectoralModel();
            modelo.ResultadoElectoral = (ResultadoElectoralEntity)JsonConvert.DeserializeObject(resultadoElectoralBusiness.GetList().ToString(), typeof(ResultadoElectoralEntity));                                    
            return View(modelo);
        }
    }
}
