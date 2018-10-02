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
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string IdDisciplina,string IdDocumento)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from DocumentoDisciplina where IdDisciplina=@IdDisciplina and IdDocumento=@IdDocumento",conn);
            cmd.Parameters.AddWithValue("IdDisciplina",IdDisciplina);
            cmd.Parameters.AddWithValue("IdDocumento", IdDocumento);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.DocumentoDisciplina> Select(string IdDisciplina)
        {
            List<Modelo.DocumentoDisciplina> documentoDisciplina = new List<Modelo.DocumentoDisciplina>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from  DocumentoDisciplina where  IdDisciplina=@IdDisciplina", conn);
            cmd.Parameters.AddWithValue("@IdDisciplina",IdDisciplina);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Modelo.DocumentoDisciplina D = new Modelo.DocumentoDisciplina();
                    


                }

            }
            conn.Close();



            return documentoDisciplina;

            

        }
        

    }
}