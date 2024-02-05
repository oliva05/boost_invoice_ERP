using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.LogisticaJaguar.Models
{
   public class PT_Selection
    {
        public int PT_ID { get; set; }
        public string PT_Name { get; set; }
        public string Codigo { get; set; }
        public string Lote { get; set; }
        public decimal Existencia { get; set; }
        public decimal Cantidad_Despachar { get; set; }
        public int PresentacionID { get; set; }
        public string Presentacion { get; set; }
    }
}
