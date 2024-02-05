using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
   public class ListaPrecioClientesAplica
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public string Cliente { get; set; }
        public DateTime CreateDate { get; set; }
        public int  UsuariID { get; set; }
        public string  Usuario { get; set; }
    }
}
