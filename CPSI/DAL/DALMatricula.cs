using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;

namespace CPSI.DAL
{
    public class DALMatricula
    {
        private string connectioString;
        public DALMatricula()
        {

            connectioString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }   
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Matricula> SelectAll(string IdTurma)
        {

            List<Modelo.Matricula> Matriculas = new List<Modelo.Matricula>();
            Modelo.Matricula Matricula;
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Aluno.Aluno,Aluno.CPF, Matricula.Situacao, Matricula.DataMatricula,Matricula.IdAluno, Matricula.IdTurma from Aluno inner join Matricula on Matricula.IdAluno = Aluno.IdAluno where IdTurma = @IdTurma";
            cmd.Parameters.AddWithValue("@IdTurma",IdTurma);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // Matricula(int IdAluno,int IdTurma,int Situacao ,DateTime DataMatricula,string AlunoNome, string Cpf)
                    Matricula = new Modelo.Matricula(
                        int.Parse(dr["IdAluno"].ToString()), int.Parse(dr["IdTurma"].ToString()),
                        int.Parse(dr["Situacao"].ToString()), DateTime.Parse(dr["DataMatricula"].ToString()),
                        dr["Aluno"].ToString(), dr["CPF"].ToString()
                        );
                    Matriculas.Add(Matricula);


                }

            }
            conn.Close();



            return Matriculas;

        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Matricula M)
        {


            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Matricula (IdTurma,IdAluno,Situacao,DataMatricula)  VALUES (@IdTurma,@IdAluno,@Situacao,@DataMatricula)";
            cmd.Parameters.AddWithValue("@IdTurma",M.IdTurma);
            cmd.Parameters.AddWithValue("@IdAluno",M.IdAluno);
            cmd.Parameters.AddWithValue("@Situacao",1);
            cmd.Parameters.AddWithValue("@DataMatricula",DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string IdAluno)
        {
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Matricula WHERE IdAluno=@IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno",IdAluno);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
            
    }
}