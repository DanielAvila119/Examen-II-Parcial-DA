using Examen_II_Parcial_DA.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Parcial_DA.Modelos.DAO
{
    public class TicketsDAO : Conexion
    {
            SqlCommand comando = new SqlCommand();
            public bool InsertarNuevoTicket(Tickets tickets)
            {
                bool inserto = false;
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append(" INSERT INTO TICKET ");
                    sql.Append(" VALUES (@Nombre, @Email, @Dispositivo, @Asunto, @Mensaje, @NumeroTicket); ");
                    comando.Connection = MiExamenConexion;
                    MiExamenConexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql.ToString();
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = tickets.Nombre;
                    comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = tickets.Email;
                    comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = tickets.Dispositivo;
                    comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 50).Value = tickets.Asunto;
                    comando.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 100).Value = tickets.Mensaje;
                    comando.Parameters.Add("@NumeroTicket", SqlDbType.NVarChar, 50).Value = tickets.numTicket;
                    comando.ExecuteNonQuery();
                    inserto = true;
                    MiExamenConexion.Close();
                    //return true;

                }
                catch (Exception)
                {
                    inserto = false;
                }
                return inserto;
            }
            public DataTable GetTicket()
            {
                DataTable dt = new DataTable();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append(" SELECT * FROM TICKET ");
                    comando.Connection = MiExamenConexion;
                    MiExamenConexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql.ToString();
                    SqlDataReader dr = comando.ExecuteReader();
                    dt.Load(dr);
                    MiExamenConexion.Close();
                }
                catch (Exception)
                {


                }
                return dt;
            }
            public bool ActualizarTicket(Tickets tickets)
            {
                bool modifico = false;
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append(" UPDATE TICKET ");
                    sql.Append(" SET NOMBRE = @Nombre, EMAIL = @Email, DISPOSITIVO = @Dispositivo, @ASUNTO = @Asunto, @MENSAJE = @Mensaje ");
                    sql.Append(" WHERE ID = @Id; ");

                    comando.Connection = MiExamenConexion;
                    MiExamenConexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = tickets.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = tickets.Email;
                comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = tickets.Dispositivo;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 50).Value = tickets.Asunto;
                comando.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 100).Value = tickets.Mensaje;
                comando.Parameters.Add("@NumeroTicket", SqlDbType.NVarChar, 50).Value = tickets.numTicket;
                comando.ExecuteNonQuery();
                    modifico = true;
                    MiExamenConexion.Close();

                }
                catch (Exception)
                {

                    return modifico;
                }
                return modifico;
            }
            public bool EliminarTicket(int id)
            {
                bool elimino = false;
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append(" DELETE FROM TICKET ");
                    sql.Append(" WHERE ID = @Id; ");

                    comando.Connection = MiExamenConexion;
                    MiExamenConexion.Open();
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql.ToString();
                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    comando.ExecuteNonQuery();
                    elimino = true;
                    MiExamenConexion.Close();

                }
                catch (Exception)
                {

                    return elimino;
                }
                return elimino;
            }
    }
}
