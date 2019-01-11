using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.ComponentModel;
using System.Data.SqlClient;

namespace CPSI.DAL
{
    public class DALAlunoDocumento
    {
        private string connectionString;
        public DALAlunoDocumento()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void insert(Modelo.AlunoDocumento obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach (int I in obj.idDocumento)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO AlunoDocumento (IdAluno,IdDocumento) VALUES (@IdAluno,@IdDocumento)";
                cmd.Parameters.AddWithValue("@IdAluno", obj.idAluno);
                cmd.Parameters.AddWithValue("@IdDocumento", I);
                cmd.ExecuteNonQuery();

            }

            conn.Close();
        }
    }
}