using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.LogisticaJaguar.Models
{
   public class RecepcionFacturasProveedor
    {
        public Int64 ID { get; set; }
        public int DocNum { get; set; }
        public string NumeroFactura { get; set; }
        public string Observaciones { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string EntregadoPor { get; set; }
        public string EntregadoPorTelefono { get; set; }
        public string EntregadoPorIdentidad { get; set; }
        public DateTime EntregadoPorHora { get; set; }
        public string RecibidoPor { get; set; }
        public string RecibidoPorTelefono { get; set; }
        public string RecibidoPorIdentidad { get; set; }
        public string RevisadoPor { get; set; }
        public DateTime RevisadoPorHora { get; set; }
        public DateTime RecibidoPorHora { get; set; }
    }
}
