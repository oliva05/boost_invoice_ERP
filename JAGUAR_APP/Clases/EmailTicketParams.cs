using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    class EmailTicketParams
    {
        public string Destinatario { get; set; }
        public List<String> CorreosCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Boolean  IsHTML { get; set; }
        public int Port { get; set; }
        public int TicketID { get; set; }
        public string Nombre { get; set; }
        public string UsuarioAsignado { get; set; }
        public string Estado { get; set; }
        public string PrioridadTicket { get; set; }
        public string TituloTicket { get; set; }
        //public string Comentario { get; set; }

    }
}
