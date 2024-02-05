using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//using Devart.Data.PostgreSql;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using ACS.Classes;
//using JAGUAR_APP.MigracionACS.RPTS.PRD;

namespace JAGUAR_APP.Clases
{
    class FMOP
    {
        DataOperations dp = new DataOperations();
        SecOps sec = new SecOps();

        #region ACS DB Related Methods

        #region External Formulas Related

        /// <summary>
        /// Retorna la informacion de encabezado de la formula original
        /// </summary>
        /// <param name="formula_ff">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable ext_formula_get_main(int formula_ff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_ff;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Main", cmd);
        }

        /// <summary>
        /// Retorna la estructura de la formula original
        /// </summary>
        /// <param name="formula_ff">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable ext_formula_get_structure(int formula_ff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_ff;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Structure", cmd);
        }

        /// <summary>
        /// Retorna la estructura de la formula original
        /// </summary>
        /// <param name="formula_ff">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable ext_formula_get_structure_cost(int formula_ff)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_ff;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Structure_cost", cmd);
        }

        /// <summary>
        /// Gets the Main information of the formula, considering the status and the available and due date
        /// </summary>
        /// <param name="min_status">Minimum status for query</param>
        /// <param name="max_status">Maximum status for query</param>
        /// <returns>Returns a Datatable with the fomrula information</returns>
        public DataTable ext_formula_get_available_planning(int min_status, int max_status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@min_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@max_status", SqlDbType.Int));

            cmd.Parameters["@min_status"].Value = min_status;
            cmd.Parameters["@max_status"].Value = max_status;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Available_Planning", cmd);
        }

        /// <summary>
        /// Gets the Main information of the formula, considering the status Only
        /// </summary>
        /// <param name="min_status">Minimum status for query</param>
        /// <param name="max_status">Maximum status for query</param>
        /// <param name="pespecie">Maximum status for query</param>
        /// <returns>Returns a Datatable with the fomrula information</returns>
        public DataTable ext_formula_get_by_status(int min_status, int max_status, int pespecie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@min_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@max_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));

            cmd.Parameters["@min_status"].Value = min_status;
            cmd.Parameters["@max_status"].Value = max_status;
            cmd.Parameters["@especie"].Value = pespecie;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_By_Statusv2", cmd);
        }

        /// <summary>
        /// Gets the Main information of the formula and its structure, considering the status Only
        /// </summary>
        /// <param name="min_status">Minimum status for query</param>
        /// <param name="max_status">Maximum status for query</param>
        /// <returns>Returns a Datatable with the fomrula information</returns>
        public DataTable ext_formula_get_by_status_with_structure(int min_status, int max_status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@min_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@max_status", SqlDbType.Int));

            cmd.Parameters["@min_status"].Value = min_status;
            cmd.Parameters["@max_status"].Value = max_status;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_By_Status_With_Structure", cmd);
        }

        /// <summary>
        /// Inserta comentario en la tabla "FML_FF_Comments"
        /// </summary>
        /// <param name="formula">ID de la formula a la que hace referencia le comentario</param>
        /// <param name="user">Usuario que inserta el comentario</param>
        /// <param name="comment">Comentario</param>
        /// <param name="is_reject">Flag que determina si el comentario esta relacionado a un rechazo de formula</param>
        public void ext_formula_comment_entry(int formula, int user, string comment, bool is_reject)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@comment_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@is_reject", SqlDbType.Bit));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@comment_by"].Value = user;
            cmd.Parameters["@comment"].Value = comment;
            cmd.Parameters["@is_reject"].Value = is_reject;

            dp.ACS_Exec_SP("FM_FF_Insert_Comment", cmd);
        }

        /// <summary>
        /// Retorna la lista de comentarios relacionados a una formula externa
        /// </summary>
        /// <param name="formula">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable ext_formula_get_comments(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));

            cmd.Parameters["@formula"].Value = formula;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Comments", cmd);
        }

        /// <summary>
        /// Retorna la lista de eventos relacionados a una formula externa
        /// </summary>
        /// <param name="formula">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable ext_formula_get_events(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));

            cmd.Parameters["@formula"].Value = formula;

            return dp.ACS_Exec_SP_Get_Data("FM_FF_Get_Events", cmd);
        }

        /// <summary>
        /// Inserta evento en la tabla "FML_FF_Events"
        /// </summary>
        /// <param name="formula">ID de la formula a la que hace referencia el evento</param>
        /// <param name="user">Usuario que ocaciona el evento</param>
        /// <param name="event_type">Tipo de evento</param>
        /// <param name="event_comment">Comentario del evento</param>
        public void ext_formula_event_entry(int formula, int user, string event_type, string event_comment)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@event_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@event_type", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@event_comment", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@event_by"].Value = user;
            cmd.Parameters["@event_type"].Value = event_type;
            cmd.Parameters["@event_comment"].Value = event_comment;

            dp.ACS_Exec_SP("FM_FF_Insert_Event", cmd);
        }

        /// <summary>
        /// Metodo para aprovacion de la formula, las validaciones para su ejecucion deben hacerce antes
        /// </summary>
        /// <param name="formula">ID de la formula que se aprobara</param>
        /// <param name="user_approve">Usuario que aprobo la formula</param>
        /// <param name="approval_type">Tipo de aprovacion puede ser "FIN" o "PRD" segun sea el caso.</param>
        public void ext_formula_approve(int formula, int user_approve, string approval_type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@approve_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_type", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@approve_by"].Value = user_approve;
            cmd.Parameters["@user_type"].Value = approval_type;

            dp.ACS_Exec_SP("FM_FF_Approve", cmd);
        }

        /// <summary>
        /// Method to know a specific formula status
        /// </summary>
        /// <param name="formula"> ID of formula to be consulted</param>
        /// <returns>INT with status.</returns>
        public int ext_formula_get_status(int formula)
        {
            return int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT [status] FROM [dbo].[FML_Fomulas_FF_H] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
        }

        /// <summary>
        /// Method to validate if some kind of approval has been made to a formula
        /// </summary>
        /// <param name="formula">Formula ID to be consulted</param>
        /// <param name="approval_type">Type of approval searched -  Can be "PRD" or "FIN"</param>
        /// <returns></returns>
        public bool ext_formula_exist_approve(int formula, string approval_type)
        {
            int value;

            if (approval_type == "FIN")
            {
                value = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([aprove_fin], -1) AS aprove_fin FROM [dbo].[FML_Fomulas_FF_H] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
            }
            else if (approval_type == "PRD")
            {
                value = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([approve_prod], -1) AS approve_prod FROM [dbo].[FML_Fomulas_FF_H] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
            }
            else
            {
                value = 1;
            }

            if (value == -1)
            {
                return false;
            }
            else
            {
                return Convert.ToBoolean(value);
            }
        }

        /// <summary>
        /// Metodo para rechazar la formula, las validaciones para su ejecucion deben hacerce antes
        /// </summary>
        /// <param name="formula">ID de la formula que se rechazara</param>
        /// <param name="user_approve">Usuario que rechazo la formula</param>
        /// <param name="reject_type">Tipo de rechazo puede ser "FIN" o "PRD" segun sea el caso.</param>
        public void ext_formula_reject(int formula, int user_approve, string reject_type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@reject_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_type", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@reject_by"].Value = user_approve;
            cmd.Parameters["@user_type"].Value = reject_type;

            dp.ACS_Exec_SP("FM_FF_Reject", cmd);
        }

        /// <summary>
        /// Method to change formula status, validations had to be made before.
        /// </summary>
        /// <param name="formula">ID of the formula to update</param>
        /// <param name="user_change">User ID who made the change</param>
        /// <param name="status">requested status to be set </param>
        public void ext_formula_change_status(int formula, int user_change, int status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_change", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@user_change"].Value = user_change;
            cmd.Parameters["@status"].Value = status;

            dp.ACS_Exec_SP("FM_FF_Change_Status", cmd);
        }

        /// <summary>
        /// Method to clean the approval registered for the formula, should be used for fresh approval reques only.
        /// </summary>
        /// <param name="formula">ID of the formula to be changed</param>
        public void ext_formula_clean_approvals(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula;

            dp.ACS_Exec_SP("FM_FF_Clean_Approvals", cmd);
        }

        #endregion

        #region Local Formula Related

        /// <summary>
        /// Gets the Main information of the formula, considering the status Only
        /// </summary>
        /// <param name="min_status">Minimum status for query</param>
        /// <param name="max_status">Maximum status for query</param>
        /// <returns>Returns a Datatable with the fomrula information</returns>
        public DataTable local_formula_get_by_status(int min_status, int max_status, int pespecie)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@min_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@max_status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));

            cmd.Parameters["@min_status"].Value = min_status;
            cmd.Parameters["@max_status"].Value = max_status;
            cmd.Parameters["@especie"].Value = pespecie;

            return dp.ACS_Exec_SP_Get_Data("FM_FL_Get_By_Statusv2", cmd);
        }

        /// <summary>
        /// Retorna la estructura de la formula generada localmente.
        /// </summary>
        /// <param name="formula_id">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable local_formula_get_structure(int formula_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_id;

            return dp.ACS_Exec_SP_Get_Data("FM_FL_Get_Structure", cmd);
        }
        public DataTable formula_get_structure_SAP(int formula_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_id;

            return dp.ACS_Exec_SP_Get_Data("[FM_FF_Get_Structure_SAP_V2]", cmd);
        }

        /// <summary>
        /// Retorna la informacion de encabezado de la formula original
        /// </summary>
        /// <param name="formula_id">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable local_formula_get_main(int formula_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_id;

            return dp.ACS_Exec_SP_Get_Data("FM_FL_Get_Main", cmd);
        }

        /// <summary>
        /// Inserta comentario en la tabla "FML_Formulas_Comments"
        /// </summary>
        /// <param name="formula">ID de la formula a la que hace referencia le comentario</param>
        /// <param name="user">Usuario que inserta el comentario</param>
        /// <param name="comment">Comentario</param>
        /// <param name="is_reject">Flag que determina si el comentario esta relacionado a un rechazo de formula</param>
        public void local_formula_comment_entry(int formula, int user, string comment, bool is_reject)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@comment_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@is_reject", SqlDbType.Bit));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@comment_by"].Value = user;
            cmd.Parameters["@comment"].Value = comment;
            cmd.Parameters["@is_reject"].Value = is_reject;

            dp.ACS_Exec_SP("FM_Insert_Comment", cmd);
        }

        /// <summary>
        /// Retorna la lista de comentarios relacionados a una formula
        /// </summary>
        /// <param name="formula">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable local_formula_get_comments(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));

            cmd.Parameters["@formula"].Value = formula;

            return dp.ACS_Exec_SP_Get_Data("FM_FL_Get_Comments", cmd);
        }

        /// <summary>
        /// Retorna la lista de eventos relacionados a una formula externa
        /// </summary>
        /// <param name="formula">ID de la formula que sera consultada</param>
        /// <returns>DataTable con la informacion Requerida</returns>
        public DataTable local_formula_get_events(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));

            cmd.Parameters["@formula"].Value = formula;

            return dp.ACS_Exec_SP_Get_Data("FM_FL_Get_Events", cmd);
        }

        /// <summary>
        /// Inserta evento en la tabla "FML_FF_Events"
        /// </summary>
        /// <param name="formula">ID de la formula a la que hace referencia el evento</param>
        /// <param name="user">Usuario que ocaciona el evento</param>
        /// <param name="event_type">Tipo de evento</param>
        /// <param name="event_comment">Comentario del evento</param>
        public void local_formula_event_entry(int formula, int user, string event_type, string event_comment)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@event_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@event_type", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@event_comment", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@event_by"].Value = user;
            cmd.Parameters["@event_type"].Value = event_type;
            cmd.Parameters["@event_comment"].Value = event_comment;

            dp.ACS_Exec_SP("FM_FL_Insert_Event", cmd);
        }

        /// <summary>
        /// Method to change formula status, validations had to be made before.
        /// </summary>
        /// <param name="formula">ID of the formula to update</param>
        /// <param name="user_change">User ID who made the change</param>
        /// <param name="status">requested status to be set </param>
        public void local_formula_change_status(int formula, int user_change, int status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_change", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@user_change"].Value = user_change;
            cmd.Parameters["@status"].Value = status;

            dp.ACS_Exec_SP("FM_FL_Change_Status", cmd);
        }

        /// <summary>
        /// Method to know a specific formula status
        /// </summary>
        /// <param name="formula"> ID of formula to be consulted</param>
        /// <returns>INT with status.</returns>
        public int local_formula_get_status(int formula)
        {
            return int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT [estado] FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
        }

        /// <summary>
        /// Method to validate if some kind of approval has been made to a formula
        /// </summary>
        /// <param name="formula">Formula ID to be consulted</param>
        /// <param name="approval_type">Type of approval searched -  Can be "PRD" or "FIN"</param>
        /// <returns></returns>
        public bool local_formula_exist_approve(int formula, string approval_type)
        {
            int value;

            if (approval_type == "FIN")
            {
                value = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([aprov_fin], -1) AS aprove_fin FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
            }
            else if (approval_type == "PRD")
            {
                value = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([aprov_prod], -1) AS approve_prod FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", formula)).Tables[0].Rows[0][0].ToString());
            }
            else
            {
                value = 1;
            }

            if (value == -1)
            {
                return false;
            }
            else
            {
                return Convert.ToBoolean(value);
            }
        }

        /// <summary>
        /// Metodo para aprovacion de la formula, las validaciones para su ejecucion deben hacerce antes
        /// </summary>
        /// <param name="formula">ID de la formula que se aprobara</param>
        /// <param name="user_approve">Usuario que aprobo la formula</param>
        /// <param name="approval_type">Tipo de aprovacion puede ser "FIN" o "PRD" segun sea el caso.</param>
        public void local_formula_approve(int formula, int user_approve, string approval_type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@approve_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_type", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@approve_by"].Value = user_approve;
            cmd.Parameters["@user_type"].Value = approval_type;

            dp.ACS_Exec_SP("FM_FL_Approve", cmd);
        }

        /// <summary>
        /// Metodo para rechazar la formula, las validaciones para su ejecucion deben hacerce antes
        /// </summary>
        /// <param name="formula">ID de la formula que se rechazara</param>
        /// <param name="user_approve">Usuario que rechazo la formula</param>
        /// <param name="reject_type">Tipo de rechazo puede ser "FIN" o "PRD" segun sea el caso.</param>
        public void local_formula_reject(int formula, int user_approve, string reject_type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@reject_by", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@user_type", SqlDbType.VarChar));

            cmd.Parameters["@id_formula"].Value = formula;
            cmd.Parameters["@reject_by"].Value = user_approve;
            cmd.Parameters["@user_type"].Value = reject_type;

            dp.ACS_Exec_SP("FM_FL_Reject", cmd);
        }

        /// <summary>
        /// Method to clean the approval registered for the formula, should be used for fresh approval reques only.
        /// </summary>
        /// <param name="formula">ID of the formula to be changed</param>
        public void local_formula_clean_approvals(int formula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula;

            dp.ACS_Exec_SP("FM_FL_Clean_Approvals", cmd);
        }

        /// <summary>
        /// Procedure, to Copy the local formula
        /// </summary>
        /// <param name="formula_id">ID of the formula to be copied</param>
        /// <returns>ID of the recently copy of the formula</returns>
        public int local_formula_copy(int formula_id, string parent_code, string formula_type)
        {
            int version = (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [tipo] = '{1}'", parent_code, formula_type)).Tables[0].Rows[0][0].ToString()));
            if (version <= 0)
            {
                version = 0;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = formula_id;
            cmd.Parameters["@version"].Value = version;

            SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
            param.Direction = ParameterDirection.ReturnValue;

            return int.Parse(dp.ACS_Exec_SP_GetID("FM_FL_Copy", cmd, param).ToString());
        }

        public void local_formula_gen_NC_Build_Report(int nc_id, Double pattern_weight, bool direct_Print) 
        {
            try
            {
                #region Report Generation

                //SplashScreenManager.ShowForm(typeof(WaitForm1));

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                cmd.Parameters["@id_formula"].Value = nc_id;

                DataTable datos = dp.ACS_Exec_SP_Get_Data("RPT_FM_FF_NC_Build", cmd);
                datos.TableName = "materials";

                foreach (DataColumn col in datos.Columns) 
                {
                    col.ReadOnly = false;
                }

                foreach (DataRow row in datos.Rows)
                {
                    row["formula_calc_weight"] = (pattern_weight * Convert.ToDouble(row["fomula_inclusion"].ToString()));
                }

                datos.AcceptChanges();

                //RPT_NC_BuildReport report = new RPT_NC_BuildReport() { DataSource = datos, DataMember = "materials", ShowPrintMarginsWarning = false };
                //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                //ReportPrintTool printReport = new ReportPrintTool(report);
                //if (direct_Print)
                //    printReport.PrintDialog();
                //else
                //    printReport.ShowPreview();

                SplashScreenManager.CloseForm();

                #endregion
            }
            catch (Exception) { SplashScreenManager.CloseForm(); throw; }
        }

        public void local_formula_gen_Manual_RM_Report(int fb_id, bool direct_Print, string pCodigoFormula, string pCodigoInterno, string pVersionFormula)
        {
            try
            {
                #region Report Generation

                //SplashScreenManager.ShowForm(typeof(WaitForm1));

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                cmd.Parameters["@id_formula"].Value = fb_id;

                DataTable datos = dp.ACS_Exec_SP_Get_Data("RPT_FM_FF_FB_Manual_Materials", cmd);
                datos.TableName = "materials";

                datos.AcceptChanges();

                //RPT_FB_Manual_RM report = new RPT_FB_Manual_RM(fb_id, pCodigoFormula, pCodigoInterno, pVersionFormula) { DataSource = datos, DataMember = "materials", ShowPrintMarginsWarning = false };
                //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                //ReportPrintTool printReport = new ReportPrintTool(report);
                //if (direct_Print)
                //    printReport.PrintDialog();
                //else
                //    printReport.ShowPreview();

                //SplashScreenManager.CloseForm();

                #endregion
            }
            catch (Exception) { SplashScreenManager.CloseForm(); throw; }
        }

        #endregion

        #region Business Intelligence Related

        public Double FML_BI_get_cost_variation_index(int parent_id, int local_id)
        {
            SqlCommand cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@parent_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@local_id", SqlDbType.Int));

            cmd.Parameters["@parent_id"].Value = parent_id;
            cmd.Parameters["@local_id"].Value = local_id;

            return Convert.ToDouble(dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_variation_index", cmd).Rows[0][0].ToString());
        }

        public DataTable FML_BI_FL_FF_get_cost_compare(int local_formula_id)
        {
            SqlCommand cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = local_formula_id;

            return dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_compare", cmd);
        }

        public DataTable FML_BI_FL_FF_get_cost_structure_compare(int local_formula_id, int parent_formula_id)
        {
            SqlCommand cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@local_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@parent_formula", SqlDbType.Int));

            cmd.Parameters["@local_formula"].Value = local_formula_id;
            cmd.Parameters["@parent_formula"].Value = parent_formula_id;

            return dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_structure_compare", cmd);
        }

        public DataTable FML_BI_FL_FF_cost_variation_get_receivers() 
        {
            return dp.ACS_GetSelectData("SELECT [mail] FROM [dbo].[conf_destinatarios] WHERE [fml_alert_cost_variation] = 1").Tables[0];
        }

        public void FML_BI_cost_variation_send_mail_alert(DataTable receivers, int local_formula_id, int parent_formula_id) 
        {
            DataTable summary = FML_BI_FL_FF_get_cost_compare(local_formula_id);
            DataTable details = FML_BI_FL_FF_get_cost_structure_compare(local_formula_id, parent_formula_id);


            string MessageBody = "<h3><!-- #######  ACS MAIL! #########--></h3>"
                   + "     <h2><span style=\"color: #000080;\"><span style=\"text-decoration: underline;\">AQUAFEED S.A. de C.V.</span><br /></span></h2>"
                   + "     <h3><span style=\"color: #666699;\">Mensaje Autom&aacute;tico de ACS</span></h3> "
                   + "     <p><strong><span style=\"color: #333333;\">ACS ha detectado un porcentaje de variaci&oacute;n anormal en costo para la formula local '" + summary.Rows[0]["local_name"].ToString() + "' creada el " + summary.Rows[0]["local_created_date"].ToString() + " por " + summary.Rows[0]["local_created_by"].ToString() + " </span></strong></p> "
                   + "     <h3><span style=\"text-decoration: underline;\"><strong><span style=\"color: #333333; text-decoration: underline;\">Resumen</span></strong></span></h3> "
                   + "     <table style=\"height: 92px; border-color: #333333;\" border=\"1\" width=\"1300\"> "
                   + "     <tbody> "
                   + "     <tr> "
                   + "     <td style=\"text-align: center;\" colspan=\"4\"> "
                   + "     <h3><span style=\"color: #003300;\">Base</span></h3> "
                   + "     </td> "
                   + "     <td style=\"text-align: center;\" colspan=\"4\"> "
                   + "     <h3><span style=\"color: #003366;\">Local</span></h3> "
                   + "     </td> "
                   + "     <td style=\"text-align: center;\" colspan=\"2\"> "
                   + "     <h3><span style=\"color: #ff0000;\">Variaci&oacute;n</span></h3> "
                   + "     </td> "
                   + "     </tr> "
                   + "     <tr> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>C&oacute;digo</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>Nombre</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>Batch Size</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>Cost Batch</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>C&oacute;digo</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>Nombre</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>Batch&nbsp; Size</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>Cost Batch</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\"><strong>USD</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\"><strong>%</strong></span></td> "
                   + "     </tr> "


                   + "    <!-- #######  Summary Replace Variable Values #########--> "
                   + "     <tr> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\">" + summary.Rows[0]["parent_code"].ToString() + "</span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\">" + summary.Rows[0]["parent_name"].ToString() + "<br /></span></td> "
                   + "     <td style=\"text-align: center;\">" + summary.Rows[0]["parent_batch_size"].ToString() +" Kg" + "</td> "
                   + "     <td style=\"text-align: center;\">" + "$" + summary.Rows[0]["parent_cost"].ToString() + "</td> "
                   + "     <td style=\"text-align: center;\">" + summary.Rows[0]["local_code"].ToString() + "." + summary.Rows[0]["local_version"].ToString() + "</td> "
                   + "     <td style=\"text-align: center;\">" + summary.Rows[0]["local_name"].ToString() + "</td> "
                   + "     <td style=\"text-align: center;\">" + summary.Rows[0]["local_batch_size"].ToString() + " Kg" + "</td> "
                   + "     <td style=\"text-align: center;\">" + "$" + summary.Rows[0]["local_cost"].ToString() + "</td> "
                   + "     <td style=\"text-align: center;\">"  + "$" + summary.Rows[0]["cost_var_usd"].ToString() + "</td> "
                   + "     <td style=\"text-align: center;\">" + (Math.Round((Convert.ToDouble(summary.Rows[0]["cost_var_per"].ToString())*100), 4)).ToString() + "%" + "</td> "
                   + "    </tr> "
                   + "     <!-- #######  Summary Replace Variable Values #########--> "

                   + "     </tbody> "
                   + "     </table> "
                   + "     <p>&nbsp;</p> "
                   + "     <h3><span style=\"text-decoration: underline; color: #333333;\">Detalle</span></h3> "
                   + "     <table style=\"height: 44px; border-color: #333333;\" border=\"1\" width=\"1000\"> "
                   + "     <tbody> "
                   + "     <tr> "
                   + "     <td style=\"text-align: center;\" rowspan=\"2\"> "
                   + "     <h3><span style=\"color: #333333;\">C&oacute;digo</span></h3> "
                   + "     </td> "
                   + "     <td rowspan=\"2\"> "
                   + "     <h3><span style=\"color: #333333;\">Material</span></h3> "
                   + "     </td> "
                   + "     <td style=\"text-align: center;\" colspan=\"2\"><span style=\"color: #003300;\"><strong>Base</strong></span></td> "
                   + "     <td style=\"text-align: center;\" colspan=\"2\"><span style=\"color: #003366;\"><strong>Local</strong></span></td> "
                   + "     <td style=\"text-align: center;\" colspan=\"2\"><span style=\"color: #ff0000;\"><strong>Variación</strong></span></td> "
                   + "     </tr> "
                   + "     <tr> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>USD</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\"><strong>Incl.</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>USD</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\"><strong>Incl.</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\"><strong>Var USD</strong></span></td> "
                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\"><strong>%</strong></span></td> "
                   + "     </tr> ";

            foreach (DataRow row in details.Rows) 
            {
                if (Convert.ToDouble(row["variation_per"].ToString()) != 0 || Convert.ToDouble(row["variation_usd"].ToString()) != 0) 
                {
                    MessageBody += "     <!-- #######  Detalle de Materiales (Un bloque por linea) #########--> "
                                   + "     <tr> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #333333;\">" + row["rm_code"].ToString() + "</span></td> "
                                   + "     <td><span style=\"color: #333333;\">" + row["rm_name"].ToString() + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\">" + "$" + row["parent_inclusion_cost"].ToString() + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #003300;\">" + row["parent_inclusion_kg"].ToString() + " Kg" + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\">"+ "$" + row["local_inclusion_cost"].ToString() + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #003366;\">" + Math.Round(Convert.ToDouble(row["local_inclusion_kg"].ToString()), 4).ToString() + " Kg" + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\">" + "$" + row["variation_usd"].ToString() + "</span></td> "
                                   + "     <td style=\"text-align: center;\"><span style=\"color: #ff0000;\">" + Math.Round((Convert.ToDouble(row["variation_per"].ToString())*100), 4).ToString() + "%" + "</span></td> "
                                   + "     </tr> "
                                   + "     <!-- #######  Detalle de Materiales (Un bloque por linea) #########--> ";
                }
            }
            
            MessageBody += "     </tbody> "
                           + "    </table> "
                           + "     <p>&nbsp;</p> "
                           + "     <p><strong>&ldquo;La informaci&oacute;n contenida en este correo es confidencial, no debe ser reenviada o distribuida a personas no autorizadas.&rdquo;</strong></p> "
                           + "     <p>&nbsp;</p>";

            sec.SendEmailAlert_GD(receivers, 0, "Alerta - Variación de Costo En Formula", MessageBody, true, System.Net.Mail.MailPriority.High);

        }

        #endregion

        #region Production Plans & Orders

        /// <summary>
        /// Method to get the PO information related to a production plan
        /// </summary>
        /// <param name="plan_id">ID of the plan to be consuted</param>
        /// <returns>Datatable containing the information of the Orders, this Datatable stucture y alike the original table.</returns>
        public DataTable pp_get_plan_pos(int plan_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@plan", SqlDbType.Int));

            cmd.Parameters["@plan"].Value = plan_id;

            return dp.ACS_Exec_SP_Get_Data("PP_Get_Plan_PO", cmd);
        }
        public int pp_get_lote_fp_inserted_in_order(int id_orden)
        {
            int ID = -1;
            try
            {

                string query = @"pp_get_lote_from_pp_order";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden", id_orden);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID = dr.GetInt32(0);
                }
                else
                {
                    ID = -1;
                }
                dr.Close();
                cn.Close();
                return ID;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ID = -1;
                return ID;
            }
        }
        public int pp_order_get_next_lot_number() 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.Parameters.Add(new SqlParameter("@lot_number", SqlDbType.Int));
            param.Direction = ParameterDirection.ReturnValue;

            return dp.ACS_Exec_SP_GetID("PP_Get_Lot_Number", cmd, param);
        }

        //public DataTable pp_validate_rm_stock(int order_id) 
        //{
            
        //}

        public void pp_change_order_status(int id_orden, int status) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_orden", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

            cmd.Parameters["@id_orden"].Value = id_orden;
            cmd.Parameters["@status"].Value = status;

            dp.ACS_Exec_SP("PP_Plan_Ordenes_Change_Status", cmd);
        }

        public void pp_change_order_status(int id_orden, int status, int lot_number)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_orden", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@lot_number", SqlDbType.BigInt));

            cmd.Parameters["@id_orden"].Value = id_orden;
            cmd.Parameters["@status"].Value = status;
            cmd.Parameters["@lot_number"].Value = lot_number;

            dp.ACS_Exec_SP("PP_Plan_Ordenes_Change_Status_OP", cmd);
        }
        #endregion

        #endregion

        #region APMS DB Related Methods

        #region apms_order_save_main
        /// <summary>
        /// Metodo para guardar la informacion del encabezado de la orden de produccion por el lado del APMS
        /// </summary>
        /// <param name="acs_order_id"></param>
        /// <param name="order_number"></param>
        /// <param name="order_code"></param>
        /// <param name="line_id"></param>
        /// <param name="fp_lot_number"></param>
        /// <param name="fp_id"></param>
        /// <param name="ext_fp_id"></param>
        /// <param name="ext_fml_id"></param>
        /// <param name="fml_code"></param>
        /// <param name="fml_version"></param>
        /// <param name="plan_kg"></param>
        /// <param name="plan_batch"></param>
        /// <param name="plan_kg_p"></param>
        /// <param name="plan_batch_p"></param>
        /// <param name="plan_kg_s"></param>
        /// <param name="plan_batch_s"></param>
        /// <param name="plan_bag"></param>
        /// <param name="real_kg"></param>
        /// <param name="real_batch"></param>
        /// <param name="real_kg_p"></param>
        /// <param name="real_batch_p"></param>
        /// <param name="real_kg_s"></param>
        /// <param name="real_batch_s"></param>
        /// <param name="real_bag"></param>
        /// <param name="plan_date_start"></param>
        /// <param name="plan_date_finish"></param>
        /// <param name="plan_line"></param>
        /// <param name="created_by"></param>
        /// <param name="created_date"></param>
        /// <param name="loaded_by"></param>
        /// <param name="loaded_date"></param>
        /// <param name="start_prod_by"></param>
        /// <param name="start_prod_date"></param>
        /// <param name="close_prod_by"></param>
        /// <param name="close_prod_date"></param>
        /// <param name="status"></param>
        /// <param name="netx_batch_close"></param>
        /// <param name="comment_cancel"></param>
        /// <param name="comment_operator"></param>
        /// <returns>Retorna un numero entero (ID del row insertado)</returns>
        public int apms_order_save_main
            (
            int acs_order_id
            ,int order_number
            ,string order_code
            ,int line_id
            ,int fp_lot_number
            ,int fp_id
            ,int ext_fp_id
            ,int ext_fml_id
            ,int fml_code
            ,int fml_version
            ,Double plan_kg
            ,int plan_batch
            ,Double plan_kg_p
            ,int plan_batch_p
            ,Double plan_kg_s
            ,int plan_batch_s
            ,int plan_bag
            , Double real_kg
            ,int real_batch
            , Double real_kg_p
            ,int real_batch_p
            , Double real_kg_s
            ,int real_batch_s
            ,int real_bag
            ,DateTime plan_date_start
            //,DateTime plan_date_finish
            ,int plan_line
            ,string created_by
            ,DateTime created_date
            ,string loaded_by
            //,DateTime loaded_date
            //,int start_prod_by
            //,DateTime start_prod_date
            //,int close_prod_by
            //,DateTime close_prod_date
            ,int status
            //,bool netx_batch_close
            ,string comment_cancel
            ,string comment_operator
            ) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@acs_id", SqlDbType.BigInt));
                cmd.Parameters.Add(new SqlParameter("@order_number", SqlDbType.BigInt));
                cmd.Parameters.Add(new SqlParameter("@order_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@line_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@fp_lot_number", SqlDbType.BigInt));
                cmd.Parameters.Add(new SqlParameter("@fp_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ext_fp_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ext_fml_id", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@fml_code", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@fml_version", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@plan_kg", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@plan_batch", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@plan_kg_p", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@plan_batch_p", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@plan_kg_s", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@plan_batch_s", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@plan_bag", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@real_kg", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@real_batch", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@real_kg_p", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@real_batch_p", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@real_kg_s", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@real_batch_s", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@real_bag", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@plan_date_start", SqlDbType.DateTime));
                //cmd.Parameters.Add(new SqlParameter("@plan_date_finish", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@plan_line", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@created_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@loaded_by", SqlDbType.VarChar));
                //cmd.Parameters.Add(new SqlParameter("@loaded_date", SqlDbType.DateTime));
                //cmd.Parameters.Add(new SqlParameter("@start_prod_by", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@start_prod_date", SqlDbType.DateTime));
                //cmd.Parameters.Add(new SqlParameter("@close_prod_by", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@close_prod_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@netx_batch_close", SqlDbType.Bit));
                cmd.Parameters.Add(new SqlParameter("@comment_cancel", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@comment_operator", SqlDbType.VarChar));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@acs_id"].Value = acs_order_id;
                cmd.Parameters["@order_number"].Value = order_number;
                cmd.Parameters["@order_code"].Value = order_code;
                cmd.Parameters["@line_id"].Value = line_id;
                cmd.Parameters["@fp_lot_number"].Value = fp_lot_number;
                cmd.Parameters["@fp_id"].Value = fp_id;
                cmd.Parameters["@ext_fp_id"].Value = ext_fp_id;
                cmd.Parameters["@ext_fml_id"].Value = ext_fml_id;
                cmd.Parameters["@fml_code"].Value = fml_code;
                cmd.Parameters["@fml_version"].Value = fml_version;
                cmd.Parameters["@plan_kg"].Value = plan_kg;
                cmd.Parameters["@plan_batch"].Value = plan_batch;
                cmd.Parameters["@plan_kg_p"].Value = plan_kg_p;
                cmd.Parameters["@plan_batch_p"].Value = plan_batch_p;
                cmd.Parameters["@plan_kg_s"].Value = plan_kg_s;
                cmd.Parameters["@plan_batch_s"].Value = plan_batch_s;
                cmd.Parameters["@plan_bag"].Value = plan_bag;
                cmd.Parameters["@real_kg"].Value = real_kg;
                cmd.Parameters["@real_batch"].Value = real_batch;
                cmd.Parameters["@real_kg_p"].Value = real_kg_p;
                cmd.Parameters["@real_batch_p"].Value = real_batch_p;
                cmd.Parameters["@real_kg_s"].Value = real_kg_s;
                cmd.Parameters["@real_batch_s"].Value = real_batch_s;
                cmd.Parameters["@real_bag"].Value = real_bag;
                cmd.Parameters["@plan_date_start"].Value = plan_date_start;
                //cmd.Parameters["@plan_date_finish"].Value = plan_date_finish;
                cmd.Parameters["@plan_line"].Value = plan_line;
                cmd.Parameters["@created_by"].Value = created_by;
                cmd.Parameters["@created_date"].Value = created_date;
                cmd.Parameters["@loaded_by"].Value = loaded_by;
                //cmd.Parameters["@loaded_date"].Value = loaded_date;
                //cmd.Parameters["@start_prod_by"].Value = start_prod_by;
                //cmd.Parameters["@start_prod_date"].Value = start_prod_date;
                //cmd.Parameters["@close_prod_by"].Value = close_prod_by;
                //cmd.Parameters["@close_prod_date"].Value = close_prod_date;
                cmd.Parameters["@status"].Value = status;
                //cmd.Parameters["@netx_batch_close"].Value = netx_batch_close;
                cmd.Parameters["@comment_cancel"].Value = comment_cancel;
                cmd.Parameters["@comment_operator"].Value = comment_operator;

                return dp.APMS_Exec_SP_GetID("OP_Production_Orders_Insert_Main", cmd, param);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        #endregion

        /// <summary>
        /// Gets the APMS FP Equivalent From ACS
        /// </summary>
        /// <param name="acs_id">ACS FP ID to be compared</param>
        /// <returns>APMS FP ID</returns>
        public int apms_get_equivalent_fp(int acs_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@acs_id", SqlDbType.Int));

            cmd.Parameters["@acs_id"].Value = acs_id;

            return int.Parse(dp.APMS_Exec_SP_Get_Data("MD_Get_Equivalent_FP", cmd).Rows[0]["id"].ToString());
        }

        /// <summary>
        /// Busca el ID equivalente de la materia prima en APMS
        /// </summary>
        /// <param name="acs_id"></param>
        /// <returns>Retorna el ID APMS de la una materia prima buscada con id ACS</returns>
        public int apms_get_equivalent_rm(int acs_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@acs_id", SqlDbType.Int));

            cmd.Parameters["@acs_id"].Value = acs_id;

            return int.Parse(dp.APMS_Exec_SP_Get_Data("MD_Get_Equivalent_RM", cmd).Rows[0]["id"].ToString());
        }

        /// <summary>
        /// Busca y compara ID APMS con ACS para nucleos
        /// </summary>
        /// <param name="acs_id"></param>
        /// <returns>Retorna el ID equivalente en APMS de un nucleo en ACS</returns>
        public int apms_get_equivalent_nc(int acs_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@acs_id", SqlDbType.Int));

            cmd.Parameters["@acs_id"].Value = acs_id;

            return int.Parse(dp.APMS_Exec_SP_Get_Data("MD_Get_Equivalent_NC", cmd).Rows[0]["id"].ToString());
        }

        #region apms_order_save_main_mix_line

        /// <summary>
        /// Guarda la informacion de linea de mix de la orden de produccion
        /// </summary>
        /// <param name="order_id"></param>
        /// <param name="mix_num"></param>
        /// <param name="mix_code"></param>
        /// <param name="mix_fullCode"></param>
        /// <param name="plan_kg"></param>
        /// <param name="plan_batch"></param>
        /// <param name="real_kg"></param>
        /// <param name="real_batch"></param>
        /// <param name="status"></param>
        /// <param name="active_mix"></param>
        /// <param name="allow_suspend"></param>
        /// <returns>retorna el ID insertado</returns>
        public int apms_order_save_main_mix_line
            (int order_id
            , int mix_num
            , string mix_code
            , string mix_fullCode
            , int fp_lot_number
            , Double plan_kg
            , int plan_batch
            , Double real_kg
            , int real_batch
            , int status
            , bool active_mix
            , bool allow_suspend)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@order_id", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@mix_num", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@mix_code", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@mix_fullCode", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@fp_lot_number", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@plan_kg", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@plan_batch", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@real_kg", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@real_batch", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@active_mix", SqlDbType.Bit));
            cmd.Parameters.Add(new SqlParameter("@allow_suspend", SqlDbType.Bit));

            SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
            param.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters["@order_id"].Value = order_id;
            cmd.Parameters["@mix_num"].Value = mix_num;
            cmd.Parameters["@mix_code"].Value = mix_code;
            cmd.Parameters["@mix_fullCode"].Value = mix_fullCode;
            cmd.Parameters["@fp_lot_number"].Value = fp_lot_number;
            cmd.Parameters["@plan_kg"].Value = plan_kg;
            cmd.Parameters["@plan_batch"].Value = plan_batch;
            cmd.Parameters["@real_kg"].Value = real_kg;
            cmd.Parameters["@real_batch"].Value = real_batch;
            cmd.Parameters["@status"].Value = status;
            cmd.Parameters["@active_mix"].Value = active_mix;
            cmd.Parameters["@allow_suspend"].Value = allow_suspend;

            return dp.APMS_Exec_SP_GetID("OP_Production_Orders_Insert_Main_Mix", cmd, param);
        }

        #endregion

        /// <summary>
        /// Guarda los datos de la estructura de la formula de la orden de produccion
        /// </summary>
        /// <param name="order_id"></param>
        /// <param name="mix_id"></param>
        /// <param name="material_id"></param>
        /// <param name="material_type">el tipo puede ser RM, FP, NC y SFP</param>
        /// <param name="mix_num"></param>
        /// <param name="mix_code"></param>
        /// <param name="plan_batch"></param>
        /// <param name="plan_kg_batch"></param>
        /// <param name="plan_kg_total"></param>
        /// <param name="real_batch"></param>
        /// <param name="real_kg_total"></param>
        public void apms_order_save_main_structure(int order_id, int mix_id, int material_id, string material_type, int mix_num, string mix_code, int plan_batch, Double plan_kg_batch, Double plan_kg_total, int real_batch, Double real_kg_total)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@order_id", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@mix_id", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@rm_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@nc_id", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@pt_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@sfp_id", SqlDbType.BigInt));
            cmd.Parameters.Add(new SqlParameter("@material_type", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@mix_num", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@mix_code", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@plan_batch", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@plan_kg_batch", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@plan_kg_total", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@real_batch", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@real_kg_total", SqlDbType.Decimal));

            cmd.Parameters["@order_id"].Value = order_id;
            cmd.Parameters["@mix_id"].Value = mix_id;

            switch (material_type) 
            {
                case "RM":
                    cmd.Parameters["@rm_id"].Value = apms_get_equivalent_rm(material_id);
                    cmd.Parameters["@nc_id"].Value = DBNull.Value;
                    cmd.Parameters["@pt_id"].Value = DBNull.Value;
                    cmd.Parameters["@sfp_id"].Value = DBNull.Value;
                    break;
                case "FP":
                    cmd.Parameters["@rm_id"].Value = DBNull.Value;
                    cmd.Parameters["@nc_id"].Value = DBNull.Value;
                    cmd.Parameters["@pt_id"].Value = apms_get_equivalent_fp(material_id);
                    cmd.Parameters["@sfp_id"].Value = DBNull.Value;
                    break;
                case "NC":
                    cmd.Parameters["@rm_id"].Value = DBNull.Value;
                    cmd.Parameters["@nc_id"].Value = apms_get_equivalent_nc(material_id);
                    cmd.Parameters["@pt_id"].Value = DBNull.Value;
                    cmd.Parameters["@sfp_id"].Value = DBNull.Value;
                    break;
                case "SFP":
                    cmd.Parameters["@rm_id"].Value = DBNull.Value;
                    cmd.Parameters["@nc_id"].Value = DBNull.Value;
                    cmd.Parameters["@pt_id"].Value = DBNull.Value;
                    cmd.Parameters["@sfp_id"].Value = material_id;
                    break;
            }

            cmd.Parameters["@material_type"].Value = material_type;
            cmd.Parameters["@mix_num"].Value = mix_num;
            cmd.Parameters["@mix_code"].Value = mix_code;
            cmd.Parameters["@plan_batch"].Value = plan_batch;
            cmd.Parameters["@plan_kg_batch"].Value = plan_kg_batch;
            cmd.Parameters["@plan_kg_total"].Value = plan_kg_total;
            cmd.Parameters["@real_batch"].Value = real_batch;
            cmd.Parameters["@real_kg_total"].Value = real_kg_total;

            dp.APMS_Exec_SP("OP_Production_Orders_Insert_Structure", cmd);
        }

        /// <summary>
        /// Crea un nucleo en APMS, antes validando si existe o no.
        /// </summary>
        /// <param name="id_nc"> id de ACS del nucleo a crear en APMS</param>
        public void apms_create_new_NC(int id_nc) 
        {
            DataTable main = new DataTable();
            DataTable structure = new DataTable();

            main = local_formula_get_main(id_nc);
            structure = local_formula_get_structure(id_nc);

            #region Save Main Data

            int inserted_main = -1;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nc_acs_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@fml_code", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@fml_version", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@nc_code", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@nc_name", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

            SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
            param.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters["@nc_acs_id"].Value = Convert.ToInt32(main.Rows[0]["id"].ToString());
            cmd.Parameters["@fml_code"].Value = Convert.ToInt32(main.Rows[0]["codigo"].ToString());
            cmd.Parameters["@fml_version"].Value = Convert.ToInt32(main.Rows[0]["version"].ToString());
            cmd.Parameters["@nc_code"].Value = main.Rows[0]["nc_code"].ToString();
            cmd.Parameters["@nc_name"].Value = main.Rows[0]["nombre"].ToString();
            cmd.Parameters["@status"].Value = 50;

            inserted_main = dp.APMS_Exec_SP_GetID("MD_Insert_NC_Main", cmd, param);

            #endregion

            #region Inserted Structure

            if (inserted_main > 0)
            {
                foreach (DataRow row in structure.Rows)
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nc_id", SqlDbType.BigInt));
                    cmd.Parameters.Add(new SqlParameter("@rm_id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@inclusion", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@weight", SqlDbType.Decimal));

                    cmd.Parameters["@nc_id"].Value = inserted_main;
                    cmd.Parameters["@rm_id"].Value = apms_get_equivalent_rm(Convert.ToInt32(row["id_item"].ToString()));
                    cmd.Parameters["@inclusion"].Value = Convert.ToDouble(row["inclusion"].ToString());
                    cmd.Parameters["@weight"].Value = Convert.ToDouble(row["peso"].ToString());

                    dp.APMS_Exec_SP("MD_Insert_NC_Structure", cmd);
                }
            }

            #endregion
        }

        /// <summary>
        /// Returns the stock line info. if exist.
        /// </summary>
        /// <param name="material_id">ACS Material ID, No Foreing Key Validation</param>
        /// <param name="material_type">Material Type, can only be RM</param>
        /// <param name="min_status">Estado minimo de linea</param>
        /// <param name="max_status">Estado maximo de linea</param>
        /// <param name="unlimited">indica si es una linea ilimitada que indica una no validacion de stock</param>
        /// <returns>data table con estructura de la informacion de linea de stock</returns>
        public DataTable apms_get_available_stock_lines_info(int material_id, string material_type, int min_status, int max_status, int unlimited, bool active_only) 
        {
            if(active_only)
                return dp.APMS_GetSelectData(@"   SELECT [id]
                                                    ,[lot_number]
                                                    ,[lot_description]
                                                    ,[material_code]
                                                    ,[material_type]
                                                    ,[material_loc_id]
                                                    ,[material_ext_id]
                                                    ,[received_kg]
                                                    ,[used_kg]
                                                    ,[remaining_kg]
                                                    ,[received_date]
                                                    ,[received_by]
                                                    ,[last_update]
                                                    ,[last_update_by]
                                                    ,[close_date]
                                                    ,[close_by]
                                                    ,[status]
                                                    ,[unlimited]
                                                    ,[active]
                                                    ,[auto_close]
                                                    ,[receive_comment]
                                                    ,[close_comment]
                                                FROM [dbo].[OP_Raw_Material_Lot]
                                                WHERE [material_ext_id] = " + material_id + @"
                                                AND [status] >= " + min_status.ToString() + @" AND [status] <= " + max_status + @"
                                                AND [unlimited] = " + unlimited + @" AND [active] = 1").Tables[0];
            else
                return dp.APMS_GetSelectData(@"   SELECT [id]
                                                    ,[lot_number]
                                                    ,[lot_description]
                                                    ,[material_code]
                                                    ,[material_type]
                                                    ,[material_loc_id]
                                                    ,[material_ext_id]
                                                    ,[received_kg]
                                                    ,[used_kg]
                                                    ,[remaining_kg]
                                                    ,[received_date]
                                                    ,[received_by]
                                                    ,[last_update]
                                                    ,[last_update_by]
                                                    ,[close_date]
                                                    ,[close_by]
                                                    ,[status]
                                                    ,[unlimited]
                                                    ,[active]
                                                    ,[auto_close]
                                                    ,[receive_comment]
                                                    ,[close_comment]
                                                FROM [dbo].[OP_Raw_Material_Lot]
                                                WHERE [material_ext_id] = " + material_id + @"
                                                AND [status] >= " + min_status.ToString() + @" AND [status] <= " + max_status + @"
                                                AND [unlimited] = " + unlimited + @" --AND [active] = 1").Tables[0];
        }

        /// <summary>
        /// Coprueba si el nucleo existe ya.
        /// </summary>
        /// <param name="nucleo_acs_id">id del nucleo en ACS</param>
        /// <returns>True or False</returns>
        public bool apms_nc_exist(int nucleo_acs_id) 
        {
            int result = int.Parse(dp.APMS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[MD_NC_Main] WHERE [nc_acs_id] = {0}", nucleo_acs_id)).Tables[0].Rows[0][0].ToString());

            if (result >= 1)
                return true;
            else
                return false;
        }

        public int apms_get_nc_id(int nucleo_acs_id)
        {
            return int.Parse(dp.APMS_GetSelectData(string.Format(@"SELECT [id] FROM [dbo].[MD_NC_Main] WHERE [nc_acs_id] = {0}", nucleo_acs_id)).Tables[0].Rows[0][0].ToString());
        }
        #endregion

        #region ODOO Related Methods

        //public void odoo_insert_new_production_order(string x_codigo_orden, string x_formula, Int64 x_id_orden_acs, DateTime x_fecha_produccion, string x_codigo_formula, int x_version_formula, string x_name, Int64 x_id_formula, int x_status) 
        //{
        //    PgSqlCommand cmd = new PgSqlCommand();

        //    cmd.Parameters.Add(new PgSqlParameter(":x_codigo_orden", DbType.AnsiString));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_formula", DbType.AnsiString));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_id_orden_acs", DbType.Int64));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_fecha_produccion", DbType.DateTime));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_codigo_formula", DbType.AnsiString));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_version_formula", DbType.Int32));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_name", DbType.AnsiString));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_id_formula", DbType.Int64));
        //    cmd.Parameters.Add(new PgSqlParameter(":x_status", DbType.Int32));

        //    cmd.Parameters[":x_codigo_orden"].Value = x_codigo_orden;
        //    cmd.Parameters[":x_formula"].Value = x_formula;
        //    cmd.Parameters[":x_id_orden_acs"].Value = x_id_orden_acs;
        //    cmd.Parameters[":x_fecha_produccion"].Value = x_fecha_produccion;
        //    cmd.Parameters[":x_codigo_formula"].Value = x_codigo_formula;
        //    cmd.Parameters[":x_version_formula"].Value = x_version_formula;
        //    cmd.Parameters[":x_name"].Value = x_name;
        //    cmd.Parameters[":x_id_formula"].Value = x_id_formula;
        //    cmd.Parameters[":x_status"].Value = x_status;

        //    dp.ODOO_Exec_SP("x_sp_insert_production_order", cmd);
        //}

        #endregion
    }
}
