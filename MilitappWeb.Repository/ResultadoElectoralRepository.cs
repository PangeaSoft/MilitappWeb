using MilitappWeb.Entities;
using MilitappWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;


namespace MilitappWeb.Repository
{
    public class ResultadoElectoralRepository : IRepository<ResultadoElectoralEntity>
    {
        private static ResultadoElectoralRepository instancia = null;
        public static ResultadoElectoralRepository GetInstancia()
        {
            if (instancia == null)
                return new ResultadoElectoralRepository();
            return instancia;
        }

        public object GetList()
        {
            //string url = ConfigurationManager.AppSettings["NombreServidor"].ToString() + ConfigurationManager.AppSettings["UrlObtenerResultadosParciales"].ToString(); 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://sanmartinserver.eastus.cloudapp.azure.com/MilitappRest/api/Resultado/ObtenerResultadosParciales");
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

        public void Create(ResultadoElectoralEntity entity)
        {
            //Crear metodo POST a rest services
            throw new NotImplementedException();
        }

        public void Update(ResultadoElectoralEntity entity)
        {
            //Crear metodo PUT a rest services
            throw new NotImplementedException();
        }

        public void Delete(ResultadoElectoralEntity entity)
        {
            //Crear metodo DELETE a rest services
            throw new NotImplementedException();
        }

        public object GetElement(ResultadoElectoralEntity entity)
        {
            //Crear metodo GET a rest services
            throw new NotImplementedException();
        }

    }
}