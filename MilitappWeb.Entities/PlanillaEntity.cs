using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitappWeb.Entities
{
    public class PlanillaEntity
    {
        public int pla_id { get; set; }
        public DateTime ele_fecha { get; set; }
        public int esc_id { get; set; }
        public int mes_id { get; set; }
        public int fis_id { get; set; }
        public int pla_electores { get; set; }
        public int pla_sobres { get; set; }
        public List<TbplanillaCargoEntity> tbplanillacargo { get; set; }
        public List<TbresultadoEntity> tbresultado { get; set; }

    }
}



public class Rootobject
{
    public Porcentajeresultadodiputado[] PorcentajeResultadoDiputados { get; set; }
    public Porcentajeresultadolegisladore[] PorcentajeResultadoLegisladores { get; set; }
    public Cantidadvotosdiputado[] CantidadVotosDiputados { get; set; }
    public Cantidadvotoslegisladore[] CantidadVotosLegisladores { get; set; }
    public Listaplanilla[] ListaPlanillas { get; set; }
}

public class Porcentajeresultadodiputado
{
    public int lca_id { get; set; }
    public int lis_id { get; set; }
    public int car_id { get; set; }
    public object[] tblistacandidatocargo { get; set; }
    public object[] tbresultado { get; set; }
    public float lca_porcentaje_votos { get; set; }
    public int lca_cantidad_votos { get; set; }
}

public class Porcentajeresultadolegisladore
{
    public int lca_id { get; set; }
    public int lis_id { get; set; }
    public int car_id { get; set; }
    public object[] tblistacandidatocargo { get; set; }
    public object[] tbresultado { get; set; }
    public float lca_porcentaje_votos { get; set; }
    public int lca_cantidad_votos { get; set; }
}

public class Cantidadvotosdiputado
{
    public int lca_id { get; set; }
    public int lis_id { get; set; }
    public int car_id { get; set; }
    public object[] tblistacandidatocargo { get; set; }
    public object[] tbresultado { get; set; }
    public int lca_porcentaje_votos { get; set; }
    public int lca_cantidad_votos { get; set; }
}

public class Cantidadvotoslegisladore
{
    public int lca_id { get; set; }
    public int lis_id { get; set; }
    public int car_id { get; set; }
    public object[] tblistacandidatocargo { get; set; }
    public object[] tbresultado { get; set; }
    public int lca_porcentaje_votos { get; set; }
    public int lca_cantidad_votos { get; set; }
}

public class Listaplanilla
{
    public int pla_id { get; set; }
    public DateTime ele_fecha { get; set; }
    public int esc_id { get; set; }
    public int mes_id { get; set; }
    public int fis_id { get; set; }
    public int pla_electores { get; set; }
    public int pla_sobres { get; set; }
    public Tbplanillacargo[] tbplanillacargo { get; set; }
    public Tbresultado[] tbresultado { get; set; }
}

public class Tbplanillacargo
{
    public int pla_id { get; set; }
    public int car_id { get; set; }
    public int pca_cantidad_votos { get; set; }
}

public class Tbresultado
{
    public int lca_id { get; set; }
    public int pla_id { get; set; }
    public int res_cantidad_votos { get; set; }
}
