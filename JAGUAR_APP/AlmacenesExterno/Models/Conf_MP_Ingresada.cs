using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Models
{
    public class Conf_MP_Ingresada
    {
        public string ItemCode { get; set; }
        public decimal CantIngresada { get; set; }
        public string Descripcion { get; set; }
        public decimal UnidadesIngresadas { get; set; }
        public int LineNum { get; set; }
        public int MPID { get; set; }
        public string bodega { get; set; }
        public int id_presentacion { get; set; }
    }
}
