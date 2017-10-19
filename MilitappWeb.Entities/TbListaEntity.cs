using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class TbListaEntity
    {
        public int lis_id { get; set; }
        public DateTime ele_fecha { get; set; }
        public int lis_numero { get; set; }
        public string lis_descripcion { get; set; }
        public object[] tblistacargo { get; set; }
    }
}
