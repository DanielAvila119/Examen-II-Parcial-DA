﻿using Examen_II_Parcial_DA.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Parcial_DA.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIO WHERE EMAIL = @Email AND CLAVE = @Clave;");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
                MiExamenConexion.Close();
            }
            catch (Exception)
            {


            }
            return valido;
        }

        public bool InsertarNuevoUsuario(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO USUARIO ");
                sql.Append(" VALUES (@Nombre, @Email, @Clave); ");


                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 50).Value = EncriptarClave(user.Clave);
                comando.ExecuteNonQuery();
                MiExamenConexion.Close();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();


        }
        public DataTable GetUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM USUARIO ");
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
        public bool ActualizarUsuario(Usuario user)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE USUARIO ");
                sql.Append(" SET NOMBRE = @Nombre, EMAIL = @Email, CLAVE = @Clave, ESADMINISTRADOR = @EsAdministrador ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 50).Value = EncriptarClave(user.Clave);
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
        public bool EliminarUsuario(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM USUARIO ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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
    }
}

