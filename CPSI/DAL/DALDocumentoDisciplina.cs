using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;

namespace CPSI.DAL
{
    public class DALDocumentoDisciplina
    {
        private string connectionString;
        public DALDocumentoDisciplina()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.DocumentoDisciplina obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach (int I in obj.idDocumento)
            {
                  SqlCommand cmd = new SqlCommand("insert into DocumentoDisciplina (IdDisciplina, IdDocumento) values(@IdDisciplina, @IdDocumento)", conn);
                  cmd.Parameters.AddWithValue("@IdDisciplina",obj.idDisciplina);
                  cmd.Parameters.AddWithValue("@IdDocumento", I);
                  cmd.ExecuteNonQuery(); 


            }

            conn.Close();
        }
        

    }
}