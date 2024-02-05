using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class RegistroPago
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Valor { get; set; }
        public int IdTipo { get; set; }
        public string TipoName { get; set; }
        public string Referencia { get; set; }

        public RegistroPago() { }


    }
}
