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
            string strData;
            DateTime Data;
            int EstadoCivil;
            string StrEstadoCivil;
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
                    strData = dr["DataNascimento"].ToString();
                    Data = DateTime.Parse("01/01/1900");
                    if (strData != "") Data = DateTime.Parse(dr["DataNascimento"].ToString());
                    StrEstadoCivil = dr["EstadoCivil"].ToString();
                    EstadoCivil = 0;
                    if (StrEstadoCivil != "") EstadoCivil = int.Parse(dr["EstadoCivil"].ToString());

                    aluno = new Modelo.Aluno(int.Parse(dr["IdAluno"].ToString()), dr["Aluno"].ToString(),
                         Data,
                         dr["CPF"].ToString(), dr["RG"].ToString(), dr["RGOrgao"].ToString(),
                         EstadoCivil,
                         dr["Naturalidade"].ToString(),
                         dr["NaturalidadeEstado"].ToString(), dr["Endereco"].ToString(), dr["Cidade"].ToString(), dr["Estado"].ToString(), dr["Telefone1"].ToString(), dr["Telefone2"].ToString(), dr["Contato"].ToString(), dr["ContatoTelefone"].ToString());

                    alunos.Add(aluno);
                }

            }



            
            conn.Close();
            return alunos;



        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> SelectALLFiltro(string filtro)
        {
            string strData;
            DateTime Data;
            int EstadoCivil;
            string StrEstadoCivil;
            Modelo.Aluno aluno;
            List<Modelo.Aluno> alunos = new List<Modelo.Aluno>();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (String.IsNullOrEmpty(filtro))
                cmd.CommandText = "SELECT TOP 10 * FROM Aluno";
            else
                cmd.CommandText = "SELECT * FROM Aluno where ((Aluno like '%" + filtro + "%') or (DataNascimento like '%" + filtro + "%') or (CPF like '%" + filtro + "%') or (RG like '%" + filtro + "%') or (Estado like '%" + filtro + "%') or (Cidade like '%" + filtro + "%') or (Bairro like '%" + filtro + "%')) order by Aluno";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    strData = dr["DataNascimento"].ToString();
                    Data = DateTime.Parse("01/01/1900");
                    if (strData != "") Data = DateTime.Parse(dr["DataNascimento"].ToString());
                    StrEstadoCivil = dr["EstadoCivil"].ToString();
                    EstadoCivil = 0;
                    if (StrEstadoCivil != "") EstadoCivil = int.Parse(dr["EstadoCivil"].ToString());

                    aluno = new Modelo.Aluno(int.Parse(dr["IdAluno"].ToString()), dr["Aluno"].ToString(),
                         Data,
                         dr["CPF"].ToString(), dr["RG"].ToString(), dr["RGOrgao"].ToString(),
                         EstadoCivil,
                         dr["Naturalidade"].ToString(),
                         dr["NaturalidadeEstado"].ToString(), dr["Endereco"].ToString(), dr["Cidade"].ToString(), dr["Estado"].ToString(), dr["Telefone1"].ToString(), dr["Telefone2"].ToString(), dr["Contato"].ToString(), dr["ContatoTelefone"].ToString());

                    alunos.Add(aluno);
                }

            }
            conn.Close();
            return alunos;



        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Aluno Select(string id)
        {

            string strData;
            DateTime Data;
            int EstadoCivil;
            string StrEstadoCivil;
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
                    strData = dr["DataNascimento"].ToString();
                    Data = DateTime.Parse("01/01/1900");
                    if (strData != "") Data = DateTime.Parse(dr["DataNascimento"].ToString());
                    StrEstadoCivil = dr["EstadoCivil"].ToString();
                    EstadoCivil = 0;
                    aluno.IdAluno = int.Parse(dr["IdAluno"].ToString());
                    aluno.AlunoNome = dr["Aluno"].ToString();
                    aluno.DataNascimento = Data;
                    aluno.Cpf = dr["CPF"].ToString();
                    aluno.Rg = dr["RG"].ToString();
                    aluno.RGOrgao = dr["RGOrgao"].ToString();
                    aluno.EstadoCivil = EstadoCivil;
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
        public void Delete(string ID)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Aluno WHERE IdAluno=@IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", ID);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Aluno A)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Aluno SET Aluno = @Aluno,DataNascimento = @DataNascimento,CPF = @CPF,RG = @RG,RGOrgao = @RGOrgao,EstadoCivil = @EstadoCivil,Naturalidade = @Naturalidade, NaturalidadeEstado = @NaturalidadeEstado, Endereco = @Endereco, Cidade = @Cidade, Estado = @Estado, Telefone1 = @Telefone1, Telefone2 = @Telefone2,Contato = @Contato, ContatoTelefone = @ContatoTelefone WHERE IdAluno = @IdAluno";
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
            try
            {
                if (dr.Read())
                {

                    max = (int.Parse(dr["MAX"].ToString()) + 1);


                }


            }
            catch(FormatException)
            {
               
                max = 1;
              

            }
            conn.Close();
            return max;




        }



    }
}