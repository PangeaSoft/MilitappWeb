using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class TbCandidatoEntity
    {
        public int can_id { get; set; }
        public string can_nombre { get; set; }
        public string can_apellido { get; set; }        
        public object[] tblistacandidatocargo { get; set; }        
    }
}
