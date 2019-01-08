using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CPSI.DAL
{
    public class DALDocumentoDisciplina
    {
        private string connectionString;
        public DALDocumentoDisciplina()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.DocumentoDisciplina> SelectALL(string IdDisciplina)
        {


                List<Modelo.DocumentoDisciplina> ListDocumentoDisciplina = new List<Modelo.DocumentoDisciplina>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DocumentoDisciplina where IdDisciplina=@IdDisciplina";
                cmd.Parameters.AddWithValue("@IdDisciplina",IdDisciplina);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       ListDocumentoDisciplina.Add(new Modelo.DocumentoDisciplina(int.Parse(dr["IdDisciplina"].ToString()), int.Parse(dr["idDocumento"].ToString())));

                    }

                }
               return ListDocumentoDisciplina;
        }
       



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Disciplina disciplina)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            List<Modelo.DocumentoDisciplina> ListDocumento = disciplina.GetDocumentoDisciplina();
            foreach (Modelo.DocumentoDisciplina documentoDisciplina in ListDocumento)
            {
                  SqlCommand cmd = new SqlCommand("insert into DocumentoDisciplina (IdDisciplina, IdDocumento) values(@IdDisciplina, @IdDocumento)", conn);
                  cmd.Parameters.AddWithValue("@IdDisciplina",documentoDisciplina.idDisciplina);
                  cmd.Parameters.AddWithValue("@IdDocumento", documentoDisciplina.idDocumento);
                  cmd.ExecuteNonQuery(); 


            }

            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string IdDisciplina)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from DocumentoDisciplina where IdDisciplina=@IdDisciplina",conn);
            cmd.Parameters.AddWithValue("IdDisciplina",IdDisciplina);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        

    }
}