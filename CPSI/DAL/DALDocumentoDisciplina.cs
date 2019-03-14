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
                       ListDocumentoDisciplina.Add(new Modelo.DocumentoDisciplina(int.Parse(dr["IdDisciplina"].ToString()), int.Parse(dr["IdDocumento"].ToString())));
                       

                    }

                }
               return ListDocumentoDisciplina;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet selectALLData(string idDisciplina)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Documento,DocumentoDisciplina.IdDisciplina, Documento.IdDocumento FROM Documento inner join DocumentoDisciplina on Documento.IdDocumento=DocumentoDisciplina.IdDocumento inner join Disciplina On Disciplina.IdDisciplina=DocumentoDisciplina.IdDisciplina where Disciplina.IdDisciplina=@IdDisciplina";
            cmd.Parameters.AddWithValue("@IdDisciplina", idDisciplina);
            SqlDataAdapter DataAdapterDocumentoDisciplina = new SqlDataAdapter(cmd);
            DataSet dataSetDocumentoDisciplina = new DataSet();
            DataAdapterDocumentoDisciplina.Fill(dataSetDocumentoDisciplina);
            conn.Close();
            return dataSetDocumentoDisciplina;


        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Disciplina disciplina)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach (Modelo.DocumentoDisciplina I in disciplina.listDocumento )
            {
                  SqlCommand cmd = new SqlCommand("insert into DocumentoDisciplina (IdDisciplina, IdDocumento) values(@IdDisciplina, @IdDocumento)", conn);
                  cmd.Parameters.AddWithValue("@IdDisciplina",I.idDisciplina);
                  cmd.Parameters.AddWithValue("@IdDocumento", I.idDocumento);
                  cmd.ExecuteNonQuery(); 


            }

            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Disciplina disciplina)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from DocumentoDisciplina where IdDisciplina=@IdDisciplina",conn);
            cmd.Parameters.AddWithValue("IdDisciplina",disciplina.idDisciplina);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void update(Modelo.Disciplina disciplina)
        {
            Delete(disciplina);
            if(disciplina.existDocumento())
               Insert(disciplina);
    
        }


    }
}