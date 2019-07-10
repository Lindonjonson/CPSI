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
        public void insert(Modelo.Aluno Aluno)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach(Modelo.AlunoDocumento I in Aluno.ListAlunoDocumento)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO AlunoDocumento (IdAluno,IdDocumento) VALUES (@IdAluno,@IdDocumento)";
                cmd.Parameters.AddWithValue("@IdAluno", Aluno.idAluno);
                cmd.Parameters.AddWithValue("@IdDocumento", I.idDocumento);
                cmd.ExecuteNonQuery();
            }
           
           
            conn.Close();
        }
        public void insert(Modelo.AlunoDocumento alunoDocumento)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO AlunoDocumento (IdAluno,IdDocumento) VALUES (@IdAluno,@IdDocumento)";
            cmd.Parameters.AddWithValue("@IdAluno", alunoDocumento.idAluno);
            cmd.Parameters.AddWithValue("@IdDocumento",alunoDocumento.idDocumento);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insertComValidade(Modelo.AlunoDocumento alunoDocumento)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO AlunoDocumento (IdAluno,IdDocumento,DataValidade) VALUES (@IdAluno,@IdDocumento,@DataValidade)";
            cmd.Parameters.AddWithValue("@IdAluno", alunoDocumento.idAluno);
            cmd.Parameters.AddWithValue("@IdDocumento", alunoDocumento.idDocumento);
            cmd.Parameters.AddWithValue("@DataValidade", alunoDocumento.DataValidade);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(Modelo.AlunoDocumento obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM AlunoDocumento WHERE IdAluno=@IdAluno AND IdDocumento=@IdDocumento";
            cmd.Parameters.AddWithValue("@IdDocumento", obj.idDocumento);
            cmd.Parameters.AddWithValue("@IdAluno",obj.idAluno);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.AlunoDocumento> SelectAll(string idAluno)
        {

            List<Modelo.AlunoDocumento> alunoDocumento = new List<Modelo.AlunoDocumento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from AlunoDocumento where IdAluno=@IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno",idAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            { 
                while (dr.Read())
                {
                    DateTime data = DateTime.Parse("01/01/1990");
                    if (!string.IsNullOrEmpty(dr["DataValidade"].ToString()))
                    {
                        data = DateTime.Parse(dr["DataValidade"].ToString());
                    }
                    alunoDocumento.Add(new Modelo.AlunoDocumento(int.Parse(dr["IdAluno"].ToString()), int.Parse(dr["idDocumento"].ToString()),data));
                }
            }
            return alunoDocumento;

        }
        
        
    }
}