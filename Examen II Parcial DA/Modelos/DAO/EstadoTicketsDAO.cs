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
    public class EstadoTicketsDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoEstadoTicket(EstadoTickets tickets)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADOTICKET ");
                sql.Append(" VALUES (@NumeroTicket, @EstadoTicket); ");
                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NumeroTicket", SqlDbType.NVarChar, 50).Value = tickets.numeroTicket;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = tickets.estadoTicket;
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
        public DataTable GetEstadoTicket()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADOTICKET ");
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
        public bool ActualizarEstadoTicket(EstadoTickets tickets)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADOTICKET ");
                sql.Append(" SET NUMEROTICKET = @NumeroTicket, ESTADOTICKET = @EstadoTicket ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tickets.Id;
                comando.Parameters.Add("@NumeroTicket", SqlDbType.NVarChar, 50).Value = tickets.numeroTicket;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = tickets.estadoTicket;
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
        public bool EliminarEstadoTicket(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADOTICKET ");
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
