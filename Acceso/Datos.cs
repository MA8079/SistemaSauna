using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Configuration;

namespace SistemaPiscina.Acceso
{
    public class Datos
    {
        private SqlConnection Conexion;
        public Datos()
        { 
            Conexion= new SqlConnection(ConfigurationManager.ConnectionStrings["acceso"].ConnectionString);
        }
        //Consultas sin condiciones, como listados de registro
        public DataSet LeerRegistro(String query)
        {
            SqlCommand Query = new SqlCommand(query,Conexion);
            Query.CommandType = CommandType.Text;
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            return Data;
        }
        //Consultas con condiciones como estado de casillero
        public DataSet LeerRegistro(String consulta,List<SqlParameter>parametros)
        {
            
            SqlCommand Query = new SqlCommand(consulta,Conexion);
            Query.CommandType = CommandType.Text;
            for (int i = 0; i <parametros.Count; i++)
            {
                Query.Parameters.Add(parametros[i]);
            }
            SqlDataAdapter Adaptador = new SqlDataAdapter(Query);
            DataSet Data = new DataSet();
            Adaptador.Fill(Data);
            return Data;
        }
        public void TransaccionSQL(String consulta,List<SqlParameter>parametros)
        {
            if (Conexion.State==ConnectionState.Open)
            {
                Conexion.Close();
            }
            SqlCommand Query = new SqlCommand(consulta,Conexion);
            Query.CommandType = CommandType.Text;
            for (int i = 0; i <parametros.Count; i++)
            {
                Query.Parameters.Add(parametros[i]);
            }
            Conexion.Open();
            Query.ExecuteNonQuery();
            Conexion.Close();
        }
        //Consulta a la tabla de usuarios
        public SqlDataReader Lector(string consulta ,List<SqlParameter>parametros)
        {
            SqlDataReader Lector;
            SqlCommand Query = new SqlCommand(consulta,Conexion);
            Query.CommandType = CommandType.Text;
            for (int i = 0; i <parametros.Count; i++)
            {
                Query.Parameters.Add(parametros[i]); ;
            }
            Conexion.Open();
            return Lector = Query.ExecuteReader(CommandBehavior.CloseConnection);           
            
        }

    }
}