using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace veterinaria_1._3
{
    internal class Helper
    {
        private static Helper instancia;
        SqlConnection cnn = new SqlConnection(Properties.Resources.cnnVeterinaria);        
        SqlCommand cmd = new SqlCommand();
       

        public static Helper ObtenerInstancia()
        {
            if (instancia == null)
            
               instancia = new Helper();                
            
            return instancia;

        }
        private void conectar(string sp_nombre)
        {
            cnn.Open();
            cmd.Connection=cnn;
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = sp_nombre;      
        }
        private void desconectar()
        {
            cmd.Parameters.Clear();
            cnn.Close();
        }
        public int ObtenerProximo(string sp_nombre,string nombreOutPut)
        {
            cnn.Open();
            cmd.Connection= cnn;
            cmd.CommandText= sp_nombre;
            cmd.CommandType=CommandType.StoredProcedure;
            SqlParameter outPut = new SqlParameter();
            outPut.ParameterName= nombreOutPut;
            outPut.Direction= ParameterDirection.Output;
            outPut.DbType=DbType.Int32;
            cmd.Parameters.Add(outPut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)outPut.Value;
        }

        public DataTable conectarBD(string sp_nombre)
        {   
            DataTable tabla = new DataTable();
            conectar(sp_nombre);          
            
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        //public int proximoCliente(string sp_nombre)
        //{
        //    conectar(sp_nombre);
        //    cmd.CommandText=sp_nombre;
        //    SqlParameter OutPut = new SqlParameter();
        //    OutPut.ParameterName = "@Next";
        //    OutPut.DbType = DbType.Int32;
        //    OutPut.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(OutPut);
        //    cmd.ExecuteNonQuery();
        //    desconectar();
        //    return (int)OutPut.Value;
        //}
        public int actualizarBD(string sp_nombre)
        {
            int filasAfectadas = 0;
            conectar(sp_nombre);

            SqlTransaction t = null;

            try
            {

               

                t=cnn.BeginTransaction();

         

                filasAfectadas=cmd.ExecuteNonQuery();
                desconectar();

                t.Commit();
            }

            catch (Exception)
            {
                t.Rollback();
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return filasAfectadas;

            }
        
    }
}
