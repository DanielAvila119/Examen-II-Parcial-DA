﻿using Examen_II_Parcial_DA.Modelos.Entidades;
using Examen_II_Parcial_DA.Vistas;
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
    public class ClienteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoCliente(Cliente cliente)
        {
            //bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Identidad, @Nombre, @Email, @Direccion); ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 30).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 70).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = cliente.Direccion;
                comando.ExecuteNonQuery();
                //inserto = true;
                MiExamenConexion.Close();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
            //return inserto;
        }
        public DataTable GetCliente()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT FROM CLIENTE ");
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
        public bool ActualizarCliente(Cliente cliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append(" SET IDENTIDAD = @Identidad, NOMBRE = @Nombre, EMAIL = @Email, DIRECCION = @Direccion; ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiExamenConexion;
                MiExamenConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 70).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = cliente.Direccion;
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
        public bool EliminarCliente(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
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
