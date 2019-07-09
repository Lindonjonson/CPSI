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
        public DataSet SelectALL(string IdDisciplina)
        {

          
              
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Documento,DocumentoDisciplina.IdDisciplina, Documento.IdDocumento FROM Documento inner join DocumentoDisciplina on Documento.IdDocumento=DocumentoDisciplina.IdDocumento inner join Disciplina On Disciplina.IdDisciplina=DocumentoDisciplina.IdDisciplina where Disciplina.IdDisciplina=@IdDisciplina";
                cmd.Parameters.AddWithValue("@IdDisciplina",IdDisciplina);
                SqlDataAdapter DataAdapterDocumentoDisciplina = new SqlDataAdapter(cmd);
                DataSet dataSetDocumentoDisciplina= new DataSet();
                DataAdapterDocumentoDisciplina.Fill(dataSetDocumentoDisciplina);
                conn.Close();
                return dataSetDocumentoDisciplina;




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

        

    }
}