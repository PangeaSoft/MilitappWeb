using MilitappWeb.Entities;
using MilitappWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Repository
{
    public class PersonaRepository : IRepository<PersonaEntity>
    {
        private static PersonaRepository instancia = null;
        public static PersonaRepository GetInstancia()
        {
            if (instancia == null)
                return new PersonaRepository();

            return instancia;
        }

        public void Create(PersonaEntity entity)
        {
            //Crear metodo POST a rest services
            throw new NotImplementedException();
        }

        public void Update(PersonaEntity entity)
        {
            //Crear metodo PUT a rest services
            throw new NotImplementedException();
        }

        public void Delete(PersonaEntity entity)
        {
            //Crear metodo DELETE a rest services
            throw new NotImplementedException();
        }

        public object GetElement(PersonaEntity entity)
        {
            //Crear metodo GET a rest services
            throw new NotImplementedException();
        }

        public object GetList()
        {
            //Crear metodo GET a rest services

            //Provisoriamente y solo a modo de prueba, se invoca al metodo Obtener listado de prueba
            return ObtenerListaDePrueba();
        }

        private List<PersonaEntity> ObtenerListaDePrueba()
        {
            List<PersonaEntity> lista = new List<PersonaEntity>();
            for (int i = 0; i <= 20; i++)
                lista.Add(new PersonaEntity { Nombre = "Pepe" + i.ToString(), Apellido = "Pompin" + i.ToString(), FechaNacimiento = DateTime.Today });

            return lista;
        }
    }
}
    

