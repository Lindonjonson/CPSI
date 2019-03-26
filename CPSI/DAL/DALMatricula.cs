using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

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
        public DataSet SelectAll(string IdTurma)
        {
            DataTable data = new DataTable();

            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText= "SELECT * FROM ViewMatriculadosTurma where Situacao=1 AND IdTurma=@IdTurma";
            cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
            SqlDataAdapter dataAdapterMatriculados = new SqlDataAdapter(cmd);
            DataSet dataSetMatriculados = new DataSet();
            dataAdapterMatriculados.Fill(dataSetMatriculados);
            conn.Close();

            
            
            return dataSetMatriculados; 

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Matricula M)
        {


            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Matricula (IdTurma,IdAluno,Situacao,DataMatricula)  VALUES (@IdTurma,@IdAluno,@Situacao,@DataMatricula)";
            cmd.Parameters.AddWithValue("@IdTurma",M.idTurma);
            cmd.Parameters.AddWithValue("@IdAluno",M.idAluno);
            cmd.Parameters.AddWithValue("@Situacao",M.situacao);
            cmd.Parameters.AddWithValue("@DataMatricula",M.dataMatricula);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Aluno já matriculado na turma selecionada");
            }
            finally
            {
                conn.Close();
            }
            


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

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Matricula M)
        {
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Matricula SET Situacao = @Situacao WHERE IdTurma = @IdTurma  AND IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@Situacao", M.situacao);
            cmd.Parameters.AddWithValue("@IdTurma", M.idTurma);
            cmd.Parameters.AddWithValue("@IdAluno", M.idAluno);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Matricula Select(string IdAluno, string IdTurma)
        {
            Modelo.Matricula matricula = new Modelo.Matricula();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * FROM Matricula  WHERE IdTurma = @IdTurma  AND IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
            cmd.Parameters.AddWithValue("@IdAluno", IdAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                matricula.idAluno = int.Parse(dr["IdAluno"].ToString());
                matricula.idTurma = int.Parse(dr["IdTurma"].ToString());
                matricula.situacao = int.Parse(dr["Situacao"].ToString());
                matricula.dataMatricula = DateTime.Parse(dr["DataMatricula"].ToString());
                

            }
            conn.Close();
            return matricula;


        }
        public bool VagaDisponivel(string IdTurma)
        {

            DALTurma dALTurma = new DALTurma();
            Modelo.Turma turma = dALTurma.Select(IdTurma);
            if (turma.qtdVagas >= (dALTurma.GetCountMatriculados(IdTurma)+1))
                return true;
            else
                return false;

        }
        
        


    }
}