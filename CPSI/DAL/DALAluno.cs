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
        public List<Modelo.Aluno> selectALL()
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
                         dr["NaturalidadeEstado"].ToString(), dr["Endereco"].ToString(),dr["Bairro"].ToString(), dr["Cidade"].ToString(), dr["Estado"].ToString(), dr["Telefone1"].ToString(), dr["Telefone2"].ToString(), dr["Contato"].ToString(), dr["ContatoTelefone"].ToString());

                    alunos.Add(aluno);
                }

            }



            
            conn.Close();
            return alunos;



        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> selectALLFiltro(string filtro)
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
                         dr["NaturalidadeEstado"].ToString(), dr["Endereco"].ToString(), dr["Bairro"].ToString(), dr["Cidade"].ToString(), dr["Estado"].ToString(), dr["Telefone1"].ToString(), dr["Telefone2"].ToString(), dr["Contato"].ToString(), dr["ContatoTelefone"].ToString());

                    alunos.Add(aluno);
                }

            }
            conn.Close();
            return alunos;



        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Aluno select(string id)
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
                    if (!(String.IsNullOrEmpty(StrEstadoCivil)))
                        EstadoCivil = int.Parse(StrEstadoCivil);
                    aluno.idAluno = int.Parse(dr["IdAluno"].ToString());
                    aluno.alunoNome = dr["Aluno"].ToString();
                    aluno.dataNascimento = Data;
                    aluno.cpf = dr["CPF"].ToString();
                    aluno.rg = dr["RG"].ToString();
                    aluno.rgOrgao = dr["RGOrgao"].ToString();
                    aluno.estadoCivil = EstadoCivil;
                    aluno.naturalidade = dr["Naturalidade"].ToString();
                    aluno.naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                    aluno.endereco = dr["Endereco"].ToString();
                    aluno.bairro = dr["Bairro"].ToString();
                    aluno.cidade = dr["Cidade"].ToString();
                    aluno.estado = dr["Estado"].ToString();
                    aluno.telefone1 = dr["Telefone1"].ToString();
                    aluno.telefone2 = dr["Telefone2"].ToString();
                    aluno.contato = dr["Contato"].ToString();
                    aluno.contatoTelefone=dr["ContatoTelefone"].ToString();


                }



            }
            conn.Close();
            return aluno;

        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void delete(string ID)
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
        public void update(Modelo.Aluno A)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Aluno SET Aluno = @Aluno,DataNascimento = @DataNascimento,CPF = @CPF,RG = @RG,RGOrgao = @RGOrgao,EstadoCivil = @EstadoCivil,Naturalidade = @Naturalidade, NaturalidadeEstado = @NaturalidadeEstado, Endereco = @Endereco,Bairro=@Bairro ,Cidade = @Cidade, Estado = @Estado, Telefone1 = @Telefone1, Telefone2 = @Telefone2,Contato = @Contato, ContatoTelefone = @ContatoTelefone WHERE IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdAluno", A.idAluno);
            cmd.Parameters.AddWithValue("@Aluno", A.alunoNome);
            cmd.Parameters.AddWithValue("@DataNascimento", A.dataNascimento);
            cmd.Parameters.AddWithValue("@CPF", A.cpf);
            cmd.Parameters.AddWithValue("@RG", A.rg);
            cmd.Parameters.AddWithValue("@RGOrgao", A.rgOrgao);
            cmd.Parameters.AddWithValue("@EstadoCivil", A.estadoCivil);
            cmd.Parameters.AddWithValue("@Naturalidade", A.naturalidade);
            cmd.Parameters.AddWithValue("@NaturalidadeEstado", A.naturalidadeEstado);
            cmd.Parameters.AddWithValue("@Endereco", A.endereco);
            cmd.Parameters.AddWithValue("@Bairro",A.bairro);
            cmd.Parameters.AddWithValue("@Cidade", A.cidade);
            cmd.Parameters.AddWithValue("@Estado", A.estado);
            cmd.Parameters.AddWithValue("@Telefone1 ", A.telefone1);
            cmd.Parameters.AddWithValue("@Telefone2", A.telefone2);
            cmd.Parameters.AddWithValue("@Contato", A.contato);
            cmd.Parameters.AddWithValue("@ContatoTelefone", A.contatoTelefone);

            cmd.ExecuteNonQuery();
            conn.Close();


        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void insert(Modelo.Aluno A)
        {

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Aluno (IdAluno,Aluno,DataNascimento,CPF,RG,RGOrgao,EstadoCivil,Naturalidade ,NaturalidadeEstado,Endereco,Bairro,Cidade,Estado,Telefone1,Telefone2,Contato,ContatoTelefone) VALUES(@IdAluno, @Aluno, @DataNascimento, @CPF, @RG, @RGOrgao, @EstadoCivil, @Naturalidade, @NaturalidadeEstado, @Endereco,@Bairro ,@Cidade, @Estado, @Telefone1, @Telefone2, @Contato, @ContatoTelefone)";
            cmd.Parameters.AddWithValue("@IdAluno", getMax());
            cmd.Parameters.AddWithValue("@Aluno", A.alunoNome);
            cmd.Parameters.AddWithValue("@DataNascimento", A.dataNascimento);
            cmd.Parameters.AddWithValue("@CPF", A.cpf);
            cmd.Parameters.AddWithValue("@RG", A.rg);
            cmd.Parameters.AddWithValue("@RGOrgao", A.rgOrgao);
            cmd.Parameters.AddWithValue("@EstadoCivil", A.estadoCivil);
            cmd.Parameters.AddWithValue("@Naturalidade", A.naturalidade);
            cmd.Parameters.AddWithValue("@NaturalidadeEstado", A.naturalidadeEstado);
            cmd.Parameters.AddWithValue("@Endereco", A.endereco);
            cmd.Parameters.AddWithValue("@Bairro", A.bairro);
            cmd.Parameters.AddWithValue("@Cidade", A.cidade);
            cmd.Parameters.AddWithValue("@Estado", A.estado);
            cmd.Parameters.AddWithValue("@Telefone1 ", A.telefone1);
            cmd.Parameters.AddWithValue("@Telefone2", A.telefone2);
            cmd.Parameters.AddWithValue("@Contato", A.contato);
            cmd.Parameters.AddWithValue("@ContatoTelefone", A.contatoTelefone);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public int getMax()
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