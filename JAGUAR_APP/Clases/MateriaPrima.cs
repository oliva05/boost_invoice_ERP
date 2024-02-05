using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Clases
{
    public class MateriaPrima
    {
        public MateriaPrima()
        {
            TableMasterData = new dsColleccionesClases.materia_prima_acsDataTable();
            //LoadMasterDataList();
        }

        public MateriaPrima(int pIdMP)
        {
            IdMP_ACS = pIdMP;
        }

        public string GenerarSiguienteCodigoMP()
        {
            string codigo_var = "N/D";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.[sp_get_siguiente_codigo_mp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ver_todos", 0);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigo_var = dr.GetString(0);
                    while (codigo_var.Length < 3)
                    {
                        codigo_var = "0"+codigo_var;
                    }
                    codigo_var = "MP" + codigo_var;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return codigo_var;
        }


        dsColleccionesClases.materia_prima_acsDataTable TableMasterData;
        int _IdMP_ACS;
        string _CodeMP_SAP;
        string _CodigoODOO;
        string _Name;
        bool _enable;
        string _NameComercial;
        bool _Recuperado;
        int _IdPresentacionDefault;


        public int IdMP_ACS { get => _IdMP_ACS; set => _IdMP_ACS = value; }
        public string CodeMP_SAP { get => _CodeMP_SAP; set => _CodeMP_SAP = value; }
        public string Codigo { get => _CodigoODOO; set => _CodigoODOO = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string NameComercial { get => _NameComercial; set => _NameComercial = value; }
        public bool Recuperado { get => _Recuperado; set => _Recuperado = value; }
        public int IdPresentacionDefault { get => _IdPresentacionDefault; set => _IdPresentacionDefault = value; }
        public bool Enable { get => _enable; set => _enable = value; }

        private void LoadMasterDataList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_recuperar_registro_materias_primas_all", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_bodega", pCodigoBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(TableMasterData);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public bool RecuperarRegistroPreLoaded(string pCodigoSAP)
        {
            Recuperado = false;
            foreach (dsColleccionesClases.materia_prima_acsRow row in TableMasterData.Rows)
            {
                if (row.code_sap == pCodigoSAP)
                {
                    this.IdMP_ACS = row.id;
                    this._CodigoODOO = row.codigo;
                    this.Name = row.material;
                    this.NameComercial = row.nombre_comercial;
                    Enable = row.enable; 
                    Recuperado = true;
                    break;
                }
            }
            return Recuperado;
        }

        public bool RecuperarRegistroFromID_RM(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_clase_mp_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.IdMP_ACS = dr.GetInt32(0);
                    Name = NameComercial = dr.GetString(1);
                    Codigo = dr.GetString(2);
                    IdPresentacionDefault = dr.GetInt32(3);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool RecuperarRegistroFromItemCode(string pItemCode)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_clase_mp_from_itemcode]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", pItemCode);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.IdMP_ACS = dr.GetInt32(0);
                    Name = NameComercial = dr.GetString(1);
                    Codigo = dr.GetString(2);
                    IdPresentacionDefault = dr.GetInt32(3);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool Get_if_mp_is_granel(int pIdRM)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("codesahn.sp_get_si_mp_is_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp_is_mp_granel", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int i = dr.GetInt32(0);
                    if (i > 0)
                        r = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                r = false;
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }














    }
}
