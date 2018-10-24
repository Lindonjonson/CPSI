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
    public class DALListaDeEspera
    {
        private string connectioString;
        public DALListaDeEspera()
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
    }
}