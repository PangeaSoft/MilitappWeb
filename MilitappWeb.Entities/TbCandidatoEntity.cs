using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

using MilitappWeb.Entities.Resources;

namespace MilitappWeb.Entities
{
    public class TbCandidatoEntity
    {

        public int can_id { get; set; }
        
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Ent_TbCandidatoResource_Designer))]
        public string can_nombre { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resources.Ent_TbCandidatoResource_Designer))]
        public string can_apellido { get; set; }
        
        public object[] tblistacandidatocargo { get; set; }        
    }
}
