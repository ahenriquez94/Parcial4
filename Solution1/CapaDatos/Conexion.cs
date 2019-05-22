using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class Conexion
    {
        String cadenaconex = "Data Source=.;Initial Catalog=hospital;Integrated Security=True";
        SqlConnection cn=new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        

        //public Conexion()
        //{
            //cn = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
            //cn.Open();
        //}

        public SqlConnection Conex
        {
            get { return cn; }
            set { cn = value; }
        }

        public bool Conectar()
        {
            bool conn = false;
            try
            {
                cn.ConnectionString = cadenaconex;
                cn.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }
        public void Desconectar()
        {
            cn.Close();
        }

        public void consultaSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Correctamente conectado";
            }
            catch
            {
                mensaje ="Error";
            }
        }
    }
}
