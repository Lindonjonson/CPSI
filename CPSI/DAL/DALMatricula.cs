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
        private string connectionString;
        public DALMatricula()
        {

            connectionString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }   
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Matricula> SelectAll(string IdTurma)
        {

            List<Modelo.Matricula> Matriculas = new List<Modelo.Matricula>();
            Modelo.Matricula Matricula;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Aluno.Aluno,Aluno.CPF, Matricula.Situacao, Matricula.DataMatricula from Aluno inner join Matricula on Matricula.IdAluno = Aluno.IdAluno where IdTurma = @IdTurma";
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
            
    }
}