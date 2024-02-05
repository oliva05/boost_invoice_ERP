using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Facturacion.Notas.Model
{
  public  class FacturasSeleccionadasParaAplicarNota
    {
        public long FacturaId { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public decimal TotalLinea { get; set; }
        public int ProductoTerminadoId { get; set; }
    }
}
