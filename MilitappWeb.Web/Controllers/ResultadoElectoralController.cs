﻿using MilitappWeb.Business;
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
using System.Reflection;
using System.Web.Script.Serialization;

namespace MilitappWeb.Web.Controllers
{
    public class ResultadoElectoralController : Controller
    {
        public ActionResult Index()
        {
            ResultadoElectoralBusiness resultadoElectoralBusiness = new ResultadoElectoralBusiness();
            DiputadosGanadoresBusiness diputadosGanadoresBusiness = new DiputadosGanadoresBusiness();
            LegisladorGanadoresBusiness legisladorGanadoresBusiness = new LegisladorGanadoresBusiness();
            ResultadosGeneralesDiscriminadoModel model = new ResultadosGeneralesDiscriminadoModel();            
            model.ResultadoElectoral = (ResultadoElectoralEntity)JsonConvert.DeserializeObject(resultadoElectoralBusiness.GetList().ToString(), typeof(ResultadoElectoralEntity));
            model.Diputados = (List<LegisladoresGanadoresEntity>)JsonConvert.DeserializeObject(diputadosGanadoresBusiness.GetList().ToString(), typeof(List<LegisladoresGanadoresEntity>));
            model.Legisladores = (List<LegisladoresGanadoresEntity>)JsonConvert.DeserializeObject(legisladorGanadoresBusiness.GetList().ToString(), typeof(List<LegisladoresGanadoresEntity>));
            model.ListaVotosPorMesa = resultadoElectoralBusiness.GetListVotosPorMesa(model.ResultadoElectoral, model.Diputados, model.Legisladores);
            return View(model);            
        }


                        
        public JsonResult armarDatosGraficoBarras()
        {
            try
            {
                ResultadoElectoralBusiness resultadoElectoralBusiness = new ResultadoElectoralBusiness();
                ResultadoElectoralModel obj = new ResultadoElectoralModel();
                obj.ResultadoElectoral = (ResultadoElectoralEntity)JsonConvert.DeserializeObject(resultadoElectoralBusiness.GetList().ToString(), typeof(ResultadoElectoralEntity));
                Double[] datosBarras = resultadoElectoralBusiness.datosGraficoBarra(obj.ResultadoElectoral);
                return Json(datosBarras, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public JsonResult GetDatosComunaPorMesa()
        {
            try
            {
                ResultadoElectoralBusiness resultadoElectoralBusiness = new ResultadoElectoralBusiness();
                ResultadoElectoralModel obj = new ResultadoElectoralModel();
                obj.ResultadoElectoral = (ResultadoElectoralEntity)JsonConvert.DeserializeObject(resultadoElectoralBusiness.GetList().ToString(), typeof(ResultadoElectoralEntity));
                int[] datosBarras = resultadoElectoralBusiness.GetDatosComunaMesa(obj.ResultadoElectoral);
                return Json(datosBarras, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private decimal[] armarDatosIngresoDiputados(List<LegisladoresGanadoresEntity> obj)
        {
            List<decimal> resultados = new List<decimal>();
            decimal[] res = new decimal[4];
            foreach (LegisladoresGanadoresEntity elem in obj)
            {
                res[elem.tblistacargo.lis_id - 1] = res[elem.tblistacargo.lis_id - 1] + 1;
                resultados.Add(elem.lcc_votos_correspondientes);
            }
            //return resultados.ToArray();
            return res;
        }

                

        public JsonResult armarDatosIngresoDiputados()
        {
            DiputadosGanadoresBusiness diputadosGanadoresBusiness = new DiputadosGanadoresBusiness();
            DiputadosGanadoresModel obj = new DiputadosGanadoresModel();
            obj.ListaDiputadosGanadores = (List<LegisladoresGanadoresEntity>)JsonConvert.DeserializeObject(diputadosGanadoresBusiness.GetList().ToString(), typeof(List<LegisladoresGanadoresEntity>));
            decimal[] datosBarras = armarDatosIngresoDiputados(obj.ListaDiputadosGanadores);
            return Json(datosBarras, JsonRequestBehavior.AllowGet);            
        }
        

        private decimal[] armarDatosIngresoLegisladores(List<LegisladoresGanadoresEntity> obj)
        {
            List<decimal> resultados = new List<decimal>();
            decimal[] res = new decimal[4];
            foreach (LegisladoresGanadoresEntity elem in obj)
            {
                res[elem.tblistacargo.lis_id - 1] = res[elem.tblistacargo.lis_id - 1] + 1;
                resultados.Add(elem.lcc_votos_correspondientes);
            }
            //return resultados.ToArray();
            return res;
        }

        public JsonResult armarDatosIngresoLegisladores()
        {
            LegisladorGanadoresBusiness diputadosGanadoresBusiness = new LegisladorGanadoresBusiness();
            LegisladorGanadoresModel obj = new LegisladorGanadoresModel();
            obj.ListaLesgiladorGanadores = (List<LegisladoresGanadoresEntity>)JsonConvert.DeserializeObject(diputadosGanadoresBusiness.GetList().ToString(), typeof(List<LegisladoresGanadoresEntity>));
            decimal[] datosBarras = armarDatosIngresoLegisladores(obj.ListaLesgiladorGanadores);
            return Json(datosBarras, JsonRequestBehavior.AllowGet);
        }
    }
}

