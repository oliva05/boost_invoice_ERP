using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen.Models
{
    public class Salida_Externa_Lote
    {
        public int ID { get; set; }
        public int ID_Detalle { get; set; }
        public string Lote { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Unidades { get; set; }
        public int NumLine { get; set; }
        public int Row_ { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaProduccion { get; set; }
    }
}
