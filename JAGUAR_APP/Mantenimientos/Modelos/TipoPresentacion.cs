using System;

namespace JAGUAR_APP.Mantenimientos.Modelos
{
    public class TipoPresentacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Factor { get; set; }
        public int IdTipo { get; set; }

        public TipoPresentacion()
        {
            Enable = true;
            Fecha = DateTime.Now;
        }
    }
}
