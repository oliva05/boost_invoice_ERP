using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.AlmacenesExterno.Models
{
    public class Ingreso_Almacenes_Externos_H
    {
        public int ID { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public int DocEntry { get; set; }
        public string BodegaIN { get; set; }
        public string BodegaOUT { get; set; }
        public int Id_presentacion { get; set; }
    }
}
