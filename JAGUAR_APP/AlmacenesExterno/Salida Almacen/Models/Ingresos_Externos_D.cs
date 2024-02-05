using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen.Models
{
    public class Ingresos_Externos_D
    {
        public int ID { get; set; }
        public int NumLine { get; set; }
        public int DocEntry { get; set; }
        public int IDMP { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal Peso { get; set; }
        public decimal Unidades { get; set; }
        public string BodegaIN { get; set; }
        public string BodegaOUT { get; set; }
        public int id_presentacion { get; set; }
        public string factura { get; set; }
        public int docnum { get; set; }        

    }
}
