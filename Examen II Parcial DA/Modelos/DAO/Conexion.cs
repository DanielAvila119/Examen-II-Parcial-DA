using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Parcial_DA.Modelos.DAO
{
    public class Conexion
    {
        protected SqlConnection MiExamenConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ExamenConexion"].ConnectionString);

    }
}
