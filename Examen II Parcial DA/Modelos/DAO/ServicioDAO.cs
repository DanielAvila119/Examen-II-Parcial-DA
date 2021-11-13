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
    public class ServicioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoServicio(Servicio servicio)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO SERVICIO ");
                sql.Append(" VALUES (@Cliente, @Dispositivo, @Problema); ");
                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Cliente", SqlDbType.NVarChar, 70).Value = servicio.Cliente;
                comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = servicio.Dispositivo;
                comando.Parameters.Add("@Problema", SqlDbType.NVarChar, 50).Value = servicio.Problema;
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
        public DataTable GetServicio()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM SERVICIO ");
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
        public bool ActualizarServicio(Servicio servicio)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE SERVICIO ");
                sql.Append(" SET CLIENTE = @Cliente, DISPOSITIVO = @Dispositivo, PROBLEMA = @Problema ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = servicio.Id;
                comando.Parameters.Add("@Cliente", SqlDbType.NVarChar, 70).Value = servicio.Cliente;
                comando.Parameters.Add("@Dispositivo", SqlDbType.NVarChar, 50).Value = servicio.Dispositivo;
                comando.Parameters.Add("@Problema", SqlDbType.NVarChar, 50).Value = servicio.Problema;
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
        public bool EliminarServicio(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM SERVICIO ");
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
