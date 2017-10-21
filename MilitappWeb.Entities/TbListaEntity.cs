using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MilitappWeb.Entities
{
    public class TbListaEntity
    {
        public int lis_id { get; set; }
        public DateTime ele_fecha { get; set; }
        public int lis_numero { get; set; }

        [Display(Name = "NombreLista", ResourceType = typeof(Resources.Ent_TbCandidatoResource_Designer))]
        public string lis_descripcion { get; set; }
        public object[] tblistacargo { get; set; }
    }
}
