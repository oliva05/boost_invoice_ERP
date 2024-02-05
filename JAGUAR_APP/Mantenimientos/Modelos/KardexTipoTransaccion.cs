using System;

namespace JAGUAR_APP.Mantenimientos.Modelos
{
    public class KardexTipoTransaccion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }

        public KardexTipoTransaccion()
        {
            Enable = true;
            Fecha = DateTime.Now;
        }
    }
}
