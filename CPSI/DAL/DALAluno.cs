using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;

namespace CPSI.DAL
{
    public class DALAluno
    {
        string connectioString;
        public DALAluno()
        {

            connectioString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString; 

        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> SelectALL()
        {
            Modelo.Aluno aluno;
            List<Modelo.Aluno> alunos = new List<Modelo.Aluno>();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText="SELECT * FROM Aluno";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
               
                while (dr.Read())
                {
                     aluno = new Modelo.Aluno(int.Parse(dr["IdAluno"].ToString()),dr["Aluno"].ToString(),DateTime.Parse(dr["DataNascimento"].ToString()),dr["CPF"].ToString(),dr["RG"].ToString(),dr["RGOrgao"].ToString(),int.Parse(dr["EstadoCivil"].ToString()) ,dr["Naturalidade"].ToString(),
                                                          dr["NaturalidadeEstado"].ToString() ,dr["Endereco"].ToString(),dr["Cidade"].ToString(),dr["Estado"].ToString(),dr["Telefone1"].ToString(),dr["Telefone2"].ToString(),dr["Contato"].ToString(),dr["ContatoTelefone"].ToString());

                    alunos.Add(aluno);
                }

            }

            
            conn.Close();
            return alunos;



        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Aluno Select(string id)
        {

            Modelo.Aluno aluno= new Modelo.Aluno();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Aluno where IdAluno=@IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aluno.IdAluno = int.Parse(dr["IdAluno"].ToString());
                    aluno.AlunoNome = dr["Aluno"].ToString();
                    aluno.DataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                    aluno.Cpf = dr["CPF"].ToString();
                    aluno.Rg = dr["RG"].ToString();
                    aluno.RGOrgao = dr["RGOrgao"].ToString();
                    aluno.EstadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                    aluno.Naturalidade = dr["Naturalidade"].ToString();
                    aluno.NaturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                    aluno.Endereco = dr["Endereco"].ToString();
                    aluno.Cidade = dr["Cidade"].ToString();
                    aluno.Estado = dr["Estado"].ToString();
                    aluno.Telefone1 = dr["Telefone1"].ToString();
                    aluno.Telefone2 = dr["Telefone2"].ToString();
                    aluno.Contato = dr["Contato"].ToString();
                    aluno.ContatoTelefone=dr["ContatoTelefone"].ToString();


                }



            }
            conn.Close();
            return aluno;

        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string id)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Aluno WHERE IdAluno=@IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", id);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Aluno A)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Aluno SET Aluno = @Aluno,DataNascimento = @DataNascimento,CPF = @CPF,RG = @RG,RGOrgao = @RGOrgao,EstadoCivil = @EstadoCivil,Naturalidade = @Naturalidade, NaturalidadeEstado = @NaturalidadeEstado, Endereco = @Endereco, Cidade = @Cidade, Estado = @Estado, Telefone1 = @Telefone1, Telefone2 = @Telefone2,Contato = @Contato, ContatoTelefone = @ContatoTelefone,WHERE IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", A.IdAluno);
            cmd.Parameters.AddWithValue("@Aluno", A.AlunoNome);
            cmd.Parameters.AddWithValue("@DataNascimento", A.DataNascimento);
            cmd.Parameters.AddWithValue("@CPF", A.Cpf);
            cmd.Parameters.AddWithValue("@RG", A.Rg);
            cmd.Parameters.AddWithValue("@RGOrgao", A.RGOrgao);
            cmd.Parameters.AddWithValue("@EstadoCivil", A.EstadoCivil);
            cmd.Parameters.AddWithValue("@Naturalidade", A.Naturalidade);
            cmd.Parameters.AddWithValue("@NaturalidadeEstado", A.NaturalidadeEstado);
            cmd.Parameters.AddWithValue("@Endereco", A.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", A.Cidade);
            cmd.Parameters.AddWithValue("@Estado", A.Estado);
            cmd.Parameters.AddWithValue("@Telefone1 ", A.Telefone1);
            cmd.Parameters.AddWithValue("@Telefone2", A.Telefone2);
            cmd.Parameters.AddWithValue("@Contato", A.Contato);
            cmd.Parameters.AddWithValue("@ContatoTelefone", A.ContatoTelefone);

            cmd.ExecuteNonQuery();
            conn.Close();


        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Aluno A)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Aluno (IdAluno,Aluno,DataNascimento,CPF,RG,RGOrgao,EstadoCivil,Naturalidade ,NaturalidadeEstado,Endereco,Cidade,Estado,Telefone1,Telefone2,Contato,ContatoTelefone) VALUES(@IdAluno, @Aluno, @DataNascimento, @CPF, @RG, @RGOrgao, @EstadoCivil, @Naturalidade, @NaturalidadeEstado, @Endereco, @Cidade, @Estado, @Telefone1, @Telefone2, @Contato, @ContatoTelefone)";
            cmd.Parameters.AddWithValue("@IdAluno", GetMax());
            cmd.Parameters.AddWithValue("@Aluno", A.AlunoNome);
            cmd.Parameters.AddWithValue("@DataNascimento", A.DataNascimento);
            cmd.Parameters.AddWithValue("@CPF", A.Cpf);
            cmd.Parameters.AddWithValue("@RG", A.Rg);
            cmd.Parameters.AddWithValue("@RGOrgao", A.RGOrgao);
            cmd.Parameters.AddWithValue("@EstadoCivil", A.EstadoCivil);
            cmd.Parameters.AddWithValue("@Naturalidade", A.Naturalidade);
            cmd.Parameters.AddWithValue("@NaturalidadeEstado", A.NaturalidadeEstado);
            cmd.Parameters.AddWithValue("@Endereco", A.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", A.Cidade);
            cmd.Parameters.AddWithValue("@Estado", A.Estado);
            cmd.Parameters.AddWithValue("@Telefone1 ", A.Telefone1);
            cmd.Parameters.AddWithValue("@Telefone2", A.Telefone2);
            cmd.Parameters.AddWithValue("@Contato", A.Contato);
            cmd.Parameters.AddWithValue("@ContatoTelefone", A.ContatoTelefone);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public int GetMax()
        {
            int max=0;
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MAX(IdAluno) AS MAX FROM ALUNO";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                    max = (int.Parse(dr["MAX"].ToString())+1);


                

            }

            conn.Close();
            return max;



        }



    }
}