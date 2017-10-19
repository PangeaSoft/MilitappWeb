using MilitappWeb.Entities;
using MilitappWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Business
{
    public class PersonaBusiness
    {
        private PersonaRepository personaRepository = null;
        public PersonaBusiness()
        {
            personaRepository = PersonaRepository.GetInstancia();

        }

        public void Create(PersonaEntity entity)
        {
            personaRepository.Create(entity);
        }

        public void Update(PersonaEntity entity)
        {
            personaRepository.Update(entity);
        }

        public void Delete(PersonaEntity entity)
        {
            personaRepository.Delete(entity);
        }

        public object GetElement(PersonaEntity entity)
        {
            return personaRepository.GetElement(entity);
        }

        public object GetList()
        {
            return personaRepository.GetList();
        }
    }
}
