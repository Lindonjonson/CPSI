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