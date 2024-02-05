using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    class Email_IT_RequestParams
    {
        //public List<String> CorreosCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Boolean  IsHTML { get; set; }
        public int Port { get; set; }
        public int TicketID { get; set; }
        public string NombreUsuarioAcceso { get; set; }
        public string NombreUsuarioSolicita { get; set; }
        public string MailUsuarioSolicita { get; set; }
        public string Estado { get; set; }
        //public string PrioridadTicket { get; set; }
        public string TituloTicket { get; set; }
        public string Departamento { get; set; }
        public string Razon { get; set; }
        public string Asignado_A { get; set; }
        public List<string> Accesos { get; set; }
    }
}
