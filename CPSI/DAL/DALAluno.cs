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
                    Modelo.Aluno aluno = new Modelo.Aluno();
                    int idAluno = 0;
                    string strAluno = "";
                    DateTime dataNascimento =DateTime.Now;
                    string strCpf = "";
                    string strRg = "";
                    string RgOrgao= "";
                    int estadoCivil=0;
                    string naturalidade = "";
                    string naturalidadeEstado = "";
                    string endereco = "";
                    string cidade = "";
                    string bairro="";
                    string estado = "";
                    string telefone1 = "";
                    string telefone2 = "";
                    string contato = "";
                    string contatoTelefone = "";
                    try
                    {
                        idAluno = int.Parse(dr["IdAluno"].ToString());
                        strAluno = dr["Aluno"].ToString();
                        dataNascimento =DateTime.Parse(dr["DataNascimento"].ToString()); 
                        strCpf = dr["CPF"].ToString();
                        strRg = dr["RG"].ToString();
                        RgOrgao = dr["RGOrgao"].ToString();
                        estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        naturalidade = dr["Naturalidade"].ToString();
                        naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        endereco = dr["Endereco"].ToString();
                        cidade = dr["Cidade"].ToString();
                        bairro = dr["Bairro"].ToString();
                        estado = dr["Estado"].ToString();
                        telefone1 = dr["Telefone1"].ToString();
                        telefone2 = dr["Telefone2"].ToString();
                        contato = dr["Contato"].ToString();
                        contatoTelefone = dr["ContatoTelefone"].ToString();

                    }
                    catch(FormatException)
                    {
                        if(!String.IsNullOrEmpty(dr["IdAluno"].ToString()))
                            idAluno = int.Parse(dr["IdAluno"].ToString());
                        if (!String.IsNullOrEmpty(dr["Aluno"].ToString()))
                            strAluno = dr["Aluno"].ToString();
                        if (!String.IsNullOrEmpty(dr["DataNascimento"].ToString()))
                            dataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                        if (!String.IsNullOrEmpty(dr["CPF"].ToString()))
                            strCpf = dr["CPF"].ToString();
                        if (!String.IsNullOrEmpty(dr["RG"].ToString()))
                            strRg = dr["RG"].ToString();
                        if (!String.IsNullOrEmpty(dr["RGOrgao"].ToString()))
                            RgOrgao = dr["RGOrgao"].ToString();
                        if (!String.IsNullOrEmpty(dr["EstadoCivil"].ToString()))
                            estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        if (!String.IsNullOrEmpty(dr["Naturalidade"].ToString()))
                            naturalidade = dr["Naturalidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["NaturalidadeEstado"].ToString()))
                            naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Endereco"].ToString()))
                            endereco = dr["Endereco"].ToString();
                        if (!String.IsNullOrEmpty(dr["Cidade"].ToString()))
                            cidade = dr["Cidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["Bairro"].ToString()))
                            bairro = dr["Bairro"].ToString();
                        if (!String.IsNullOrEmpty(dr["Estado"].ToString()))
                            estado = dr["Estado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone1"].ToString()))
                            telefone1 = dr["Telefone1"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone2"].ToString()))
                            telefone2 = dr["Telefone2"].ToString();
                        if (!String.IsNullOrEmpty(dr["Contato"].ToString()))
                            contato = dr["Contato"].ToString();
                        if (!String.IsNullOrEmpty(dr["ContatoTelefone"].ToString()))
                            contatoTelefone = dr["ContatoTelefone"].ToString();
                    }
                    finally
                    {
                        aluno.idAluno = idAluno;
                        aluno.alunoNome = strAluno;
                        aluno.dataNascimento = dataNascimento;
                        aluno.cpf = strCpf;
                        aluno.rg = strRg;
                        aluno.rgOrgao = RgOrgao;
                        aluno.estadoCivil = estadoCivil;
                        aluno.naturalidade = naturalidade;
                        aluno.naturalidadeEstado= naturalidadeEstado;
                        aluno.endereco = endereco;
                        aluno.cidade = cidade;
                        aluno.bairro = bairro;
                        aluno.estado = estado;
                        aluno.telefone1 = telefone1;
                        aluno.telefone2 = telefone2;
                        aluno.contato = contato;
                        aluno.contatoTelefone = contatoTelefone;
                        alunos.Add(aluno);
                    }

                }

            }

            conn.Close();
            return alunos;



        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> selectALLFiltro(string filtro)
        {
           
           
            List<Modelo.Aluno> alunos = new List<Modelo.Aluno>();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (String.IsNullOrEmpty(filtro))
                cmd.CommandText = "SELECT TOP 5 * FROM Aluno";
            else
                cmd.CommandText = "SELECT * FROM Aluno where ((Aluno like '%" + filtro + "%') or (DataNascimento like '%" + filtro + "%') or (CPF like '%" + filtro + "%') or (RG like '%" + filtro + "%') or (Estado like '%" + filtro + "%') or (Cidade like '%" + filtro + "%') or (Bairro like '%" + filtro + "%')) order by Aluno";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Modelo.Aluno aluno = new Modelo.Aluno();
                    int idAluno = 0;
                    string strAluno = "";
                    DateTime dataNascimento = DateTime.Now;
                    string strCpf = "";
                    string strRg = "";
                    string RgOrgao = "";
                    int estadoCivil = 0;
                    string naturalidade = "";
                    string naturalidadeEstado = "";
                    string endereco = "";
                    string cidade = "";
                    string bairro = "";
                    string estado = "";
                    string telefone1 = "";
                    string telefone2 = "";
                    string contato = "";
                    string contatoTelefone = "";
                    try
                    {
                        idAluno = int.Parse(dr["IdAluno"].ToString());
                        strAluno = dr["Aluno"].ToString();
                        dataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                        strCpf = dr["CPF"].ToString();
                        strRg = dr["RG"].ToString();
                        RgOrgao = dr["RGOrgao"].ToString();
                        estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        naturalidade = dr["Naturalidade"].ToString();
                        naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        endereco = dr["Endereco"].ToString();
                        cidade = dr["Cidade"].ToString();
                        bairro = dr["Bairro"].ToString();
                        estado = dr["Estado"].ToString();
                        telefone1 = dr["Telefone1"].ToString();
                        telefone2 = dr["Telefone2"].ToString();
                        contato = dr["Contato"].ToString();
                        contatoTelefone = dr["ContatoTelefone"].ToString();

                    }
                    catch (FormatException)
                    {
                        if (!String.IsNullOrEmpty(dr["IdAluno"].ToString()))
                            idAluno = int.Parse(dr["IdAluno"].ToString());
                        if (!String.IsNullOrEmpty(dr["Aluno"].ToString()))
                            strAluno = dr["Aluno"].ToString();
                        if (!String.IsNullOrEmpty(dr["DataNascimento"].ToString()))
                            dataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                        if (!String.IsNullOrEmpty(dr["CPF"].ToString()))
                            strCpf = dr["CPF"].ToString();
                        if (!String.IsNullOrEmpty(dr["RG"].ToString()))
                            strRg = dr["RG"].ToString();
                        if (!String.IsNullOrEmpty(dr["RGOrgao"].ToString()))
                            RgOrgao = dr["RGOrgao"].ToString();
                        if (!String.IsNullOrEmpty(dr["EstadoCivil"].ToString()))
                            estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        if (!String.IsNullOrEmpty(dr["Naturalidade"].ToString()))
                            naturalidade = dr["Naturalidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["NaturalidadeEstado"].ToString()))
                            naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Endereco"].ToString()))
                            endereco = dr["Endereco"].ToString();
                        if (!String.IsNullOrEmpty(dr["Cidade"].ToString()))
                            cidade = dr["Cidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["Bairro"].ToString()))
                            bairro = dr["Bairro"].ToString();
                        if (!String.IsNullOrEmpty(dr["Estado"].ToString()))
                            estado = dr["Estado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone1"].ToString()))
                            telefone1 = dr["Telefone1"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone2"].ToString()))
                            telefone2 = dr["Telefone2"].ToString();
                        if (!String.IsNullOrEmpty(dr["Contato"].ToString()))
                            contato = dr["Contato"].ToString();
                        if (!String.IsNullOrEmpty(dr["ContatoTelefone"].ToString()))
                            contatoTelefone = dr["ContatoTelefone"].ToString();
                    }
                    finally
                    {
                        aluno.idAluno = idAluno;
                        aluno.alunoNome = strAluno;
                        aluno.dataNascimento = dataNascimento;
                        aluno.cpf = strCpf;
                        aluno.rg = strRg;
                        aluno.rgOrgao = RgOrgao;
                        aluno.estadoCivil = estadoCivil;
                        aluno.naturalidade = naturalidade;
                        aluno.naturalidadeEstado = naturalidadeEstado;
                        aluno.endereco = endereco;
                        aluno.cidade = cidade;
                        aluno.bairro = bairro;
                       aluno.estado = estado;
                        aluno.telefone1 = telefone1;
                        aluno.telefone2 = telefone2;
                        aluno.contato = contato;
                        aluno.contatoTelefone = contatoTelefone;
                        alunos.Add(aluno);
                    }
                }

            }
            conn.Close();
            return alunos;



        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Aluno select(string id)
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
                    int idAluno = 0;
                    string strAluno = "";
                    DateTime dataNascimento = DateTime.Now;
                    string strCpf = "";
                    string strRg = "";
                    string RgOrgao = "";
                    int estadoCivil = 0;
                    string naturalidade = "";
                    string naturalidadeEstado = "";
                    string endereco = "";
                    string cidade = "";
                    string bairro = "";
                    string estado = "";
                    string telefone1 = "";
                    string telefone2 = "";
                    string contato = "";
                    string contatoTelefone = "";
                    try
                    {
                        idAluno = int.Parse(dr["IdAluno"].ToString());
                        strAluno = dr["Aluno"].ToString();
                        dataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                        strCpf = dr["CPF"].ToString();
                        strRg = dr["RG"].ToString();
                        RgOrgao = dr["RGOrgao"].ToString();
                        estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        naturalidade = dr["Naturalidade"].ToString();
                        naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        endereco = dr["Endereco"].ToString();
                        cidade = dr["Cidade"].ToString();
                        bairro = dr["Bairro"].ToString();
                        estado = dr["Estado"].ToString();
                        telefone1 = dr["Telefone1"].ToString();
                        telefone2 = dr["Telefone2"].ToString();
                        contato = dr["Contato"].ToString();
                        contatoTelefone = dr["ContatoTelefone"].ToString();

                    }
                    catch (FormatException)
                    {
                        if (!String.IsNullOrEmpty(dr["IdAluno"].ToString()))
                            idAluno = int.Parse(dr["IdAluno"].ToString());
                        if (!String.IsNullOrEmpty(dr["Aluno"].ToString()))
                            strAluno = dr["Aluno"].ToString();
                        if (!String.IsNullOrEmpty(dr["DataNascimento"].ToString()))
                            dataNascimento = DateTime.Parse(dr["DataNascimento"].ToString());
                        if (!String.IsNullOrEmpty(dr["CPF"].ToString()))
                            strCpf = dr["CPF"].ToString();
                        if (!String.IsNullOrEmpty(dr["RG"].ToString()))
                            strRg = dr["RG"].ToString();
                        if (!String.IsNullOrEmpty(dr["RGOrgao"].ToString()))
                            RgOrgao = dr["RGOrgao"].ToString();
                        if (!String.IsNullOrEmpty(dr["EstadoCivil"].ToString()))
                            estadoCivil = int.Parse(dr["EstadoCivil"].ToString());
                        if (!String.IsNullOrEmpty(dr["Naturalidade"].ToString()))
                            naturalidade = dr["Naturalidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["NaturalidadeEstado"].ToString()))
                            naturalidadeEstado = dr["NaturalidadeEstado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Endereco"].ToString()))
                            endereco = dr["Endereco"].ToString();
                        if (!String.IsNullOrEmpty(dr["Cidade"].ToString()))
                            cidade = dr["Cidade"].ToString();
                        if (!String.IsNullOrEmpty(dr["Bairro"].ToString()))
                            bairro = dr["Bairro"].ToString();
                        if (!String.IsNullOrEmpty(dr["Estado"].ToString()))
                            estado = dr["Estado"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone1"].ToString()))
                            telefone1 = dr["Telefone1"].ToString();
                        if (!String.IsNullOrEmpty(dr["Telefone2"].ToString()))
                            telefone2 = dr["Telefone2"].ToString();
                        if (!String.IsNullOrEmpty(dr["Contato"].ToString()))
                            contato = dr["Contato"].ToString();
                        if (!String.IsNullOrEmpty(dr["ContatoTelefone"].ToString()))
                            contatoTelefone = dr["ContatoTelefone"].ToString();
                    }
                    finally
                    {
                        aluno.idAluno = idAluno;
                        aluno.alunoNome = strAluno;
                        aluno.dataNascimento = dataNascimento;
                        aluno.cpf = strCpf;
                        aluno.rg = strRg;
                        aluno.rgOrgao = RgOrgao;
                        aluno.estadoCivil = estadoCivil;
                        aluno.naturalidade = naturalidade;
                        aluno.naturalidadeEstado = naturalidadeEstado;
                        aluno.endereco = endereco;
                        aluno.cidade = cidade;
                        aluno.bairro = bairro;
                       aluno.estado = estado;
                        aluno.telefone1 = telefone1;
                        aluno.telefone2 = telefone2;
                        aluno.contato = contato;
                        aluno.contatoTelefone = contatoTelefone;
                        
                    }


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
            
            A.idAluno = getMax();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Aluno (IdAluno,Aluno,DataNascimento,CPF,RG,RGOrgao,EstadoCivil,Naturalidade ,NaturalidadeEstado,Endereco,Bairro,Cidade,Estado,Telefone1,Telefone2,Contato,ContatoTelefone) VALUES(@IdAluno, @Aluno, @DataNascimento, @CPF, @RG, @RGOrgao, @EstadoCivil, @Naturalidade, @NaturalidadeEstado, @Endereco,@Bairro ,@Cidade, @Estado, @Telefone1, @Telefone2, @Contato, @ContatoTelefone)";
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
            cmd.Parameters.AddWithValue("@Bairro", A.bairro);
            cmd.Parameters.AddWithValue("@Cidade", A.cidade);
            cmd.Parameters.AddWithValue("@Estado", A.estado);
            cmd.Parameters.AddWithValue("@Telefone1 ", A.telefone1);
            cmd.Parameters.AddWithValue("@Telefone2", A.telefone2);
            cmd.Parameters.AddWithValue("@Contato", A.contato);
            cmd.Parameters.AddWithValue("@ContatoTelefone", A.contatoTelefone);
            cmd.ExecuteNonQuery();
            if (A.existDocumento())
            {
                new DAL.DALAlunoDocumento().insert(A);
            }
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