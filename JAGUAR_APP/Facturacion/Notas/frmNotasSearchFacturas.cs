using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_APP.Clases;
using JAGUAR_APP.Facturacion.Notas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP.Facturacion.Notas
{
    public partial class frmNotasSearchFacturas : DevExpress.XtraEditors.XtraForm
    {

        public int id_cliente = 0;
        public int id_pdv = 0;
        public string pdv = "";
        public List< FacturasSeleccionadasParaAplicarNota> facturasSeleccionadas = new List<FacturasSeleccionadasParaAplicarNota>();
        
        public frmNotasSearchFacturas(int id_pdv_p, int pIdCliente)
        {
            InitializeComponent();
            id_cliente = pIdCliente;
            id_pdv = id_pdv_p;
            Loadfacturas();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            facturasSeleccionadas = new List<FacturasSeleccionadasParaAplicarNota>();
            FacturaDetalle factura_detalle = new FacturaDetalle();

            foreach (var item in dsFacturasGestion.HomeFacturas)
            {
                if (item.seleccionado==true)
                {

                    factura_detalle = new FacturaDetalle();

                    if (factura_detalle.RecuperaDetallFactura(item.id))
                    {

                        foreach (var item2 in factura_detalle.factura_detalle)
                        {

                           facturasSeleccionadas.Add(new FacturasSeleccionadasParaAplicarNota { FacturaId=item.id,
                            NumeroDocumento=item.numero_documento,
                            TotalLinea=item2.TotalLinea,
                            Cantidad= item2.Cantidad,
                            Precio = item2.Precio,
                            Descripcion= item2.Descripcion,
                            ProductoTerminadoId=item2.ProductoTerminadoId
                        });
                        }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

    
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void Loadfacturas()
        {
          try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_facturas_of_Client]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_punto_venta", id_pdv);
                cmd.Parameters.AddWithValue("@Id_cliente", id_cliente);


                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsFacturasGestion.HomeFacturas.Clear();
                adat.Fill(dsFacturasGestion.HomeFacturas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}