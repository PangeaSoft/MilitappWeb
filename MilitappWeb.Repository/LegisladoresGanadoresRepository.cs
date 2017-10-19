using MilitappWeb.Entities;
using MilitappWeb.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Configuration;

namespace MilitappWeb.Repository
{
    public class LegisladoresGanadoresRepository : IRepository<LegisladoresGanadoresEntity>
    {
        private static LegisladoresGanadoresRepository instancia = null;
        public static LegisladoresGanadoresRepository GetInstancia()
        {
            if (instancia == null)
                return new LegisladoresGanadoresRepository();
            return instancia;
        }

        public object GetList()
        {
            string url = ConfigurationManager.AppSettings["NombreServidor"] + ConfigurationManager.AppSettings["UrlObtenerDiputadosGanadores"];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "application/json";
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }
        }

        public void Create(LegisladoresGanadoresEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LegisladoresGanadoresEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LegisladoresGanadoresEntity entity)
        {
            throw new NotImplementedException();
        }

        public object GetElement(LegisladoresGanadoresEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
