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
    public class DALListaEspera
    {
        private string connectioString;
        public DALListaEspera()
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
            cmd.CommandText = "select * from ViewListaEspera where IdTurma=@IdTurma";
            cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
            SqlDataAdapter dataAdapterListaEsperaTurma = new SqlDataAdapter(cmd);
            DataSet dataSetMatriculados = new DataSet();
            dataAdapterListaEsperaTurma.Fill(dataSetMatriculados);
            conn.Close();



            return dataSetMatriculados;

        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.ListaEspera Select(string IdAluno, string IdTurma)
        {
            Modelo.ListaEspera listaEspera = new Modelo.ListaEspera();
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * FROM ListaEspera WHERE IdTurma = @IdTurma  AND IdAluno = @IdAluno";
            cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
            cmd.Parameters.AddWithValue("@IdAluno", IdAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEspera.IdAluno = int.Parse(dr["IdAluno"].ToString());
                listaEspera.IdTurma = int.Parse(dr["IdTurma"].ToString());
                listaEspera.DataInscricao = DateTime.Parse(dr["DataInscricao"].ToString());


            }
            conn.Close();
            return listaEspera;


        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.ListaEspera L)
        {


            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO ListaEspera (IdTurma,IdAluno,DataInscricao)  VALUES (@IdTurma,@IdAluno,@DataInscricao)";
            cmd.Parameters.AddWithValue("@IdTurma", L.IdTurma);
            cmd.Parameters.AddWithValue("@IdAluno", L.IdAluno);
            cmd.Parameters.AddWithValue("@DataInscricao", L.DataInscricao);
            cmd.ExecuteNonQuery();
            conn.Close();



        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string IdAluno, string IdTurma)
        {
            SqlConnection conn = new SqlConnection(connectioString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM ListaEspera WHERE IdAluno=@IdAluno AND IdTurma=@IdTurma";
            cmd.Parameters.AddWithValue("@IdAluno", IdAluno);
            cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}