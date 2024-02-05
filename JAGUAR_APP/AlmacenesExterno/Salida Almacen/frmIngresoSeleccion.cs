using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAGUAR_APP.Clases;
using ACS.Classes;
//using JAGUAR_APP.RecepcionMP;

namespace JAGUAR_APP.AlmacenesExterno.Salida_Almacen
{
    public partial class frmIngresoSeleccion : DevExpress.XtraEditors.XtraForm
    {
        int id_materia;
        decimal Kg;
        int id_traslado;
        UserLogin UsuarioLogeado;
        public frmIngresoSeleccion(int pid_materia, 
                                    decimal Pkg,
                                    int Pid_traslado
                            ,UserLogin Puser)
        {           
            InitializeComponent();
            id_materia = pid_materia;
            Kg = Pkg;
            id_traslado = Pid_traslado;
            UsuarioLogeado = Puser;
        }

        private void btnTarimas_Click(object sender, EventArgs e)
        {
            //frmTarima frm = new frmTarima(UsuarioLogeado, id_materia, id_traslado);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    this.DialogResult = DialogResult.OK;
            //}
        }
    }
}