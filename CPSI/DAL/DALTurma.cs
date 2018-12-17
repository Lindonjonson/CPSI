using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;

namespace CPSI.DAL
{
    public class DALTurma
    {
        string connectionString = "";

        public DALTurma()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                      ["CPSIConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Turma> SelectAll()
        {
            Modelo.Turma Turma;
            List<Modelo.Turma> ListTurma = new List<Modelo.Turma>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Turma order by DataInicio";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    Turma = new Modelo.Turma(
                        int.Parse(dr["IdTurma"].ToString()),
                        dr["Turma"].ToString(),
                        int.Parse(dr["Ano"].ToString()),
                        dr["Horario"].ToString(),
                        DateTime.Parse(dr["DataInicio"].ToString()),
                        DateTime.Parse(dr["DataFim"].ToString()),
                        int.Parse(dr["QtdVagas"].ToString()),
                        int.Parse(dr["IdDisciplina"].ToString()));
                        

                    ListTurma.Add(Turma);
                }
            }

            dr.Close();
            conn.Close();

            return ListTurma;
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Turma obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();



            SqlCommand cmd = new SqlCommand("INSERT INTO Turma(IdTurma, Turma, Ano, Horario, DataInicio, DataFim, QtdVagas, IdDisciplina)VALUES(@IdTurma, @Turma, @Ano, @Horario, @DataInicio, @DataFim, @QtdVagas, @IdDisciplina)", conn);
            cmd.Parameters.AddWithValue("@IdTurma", GetIdMax());
            cmd.Parameters.AddWithValue("@Turma", obj.NomeTurma);
            cmd.Parameters.AddWithValue("@Ano", obj.ano);
            cmd.Parameters.AddWithValue("@Horario", obj.horario);
            cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
            cmd.Parameters.AddWithValue("@DataFim", obj.DataFim);
            cmd.Parameters.AddWithValue("@QtdVagas", obj.QtdVagas);
            cmd.Parameters.AddWithValue("@IdDisciplina", obj.IdDisciplina);




            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Turma obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Turma SET IdTurma = IdTurma, Turma = @Turma, Ano = @Ano,Horario = @Horario,DataInicio = @DataInicio,DataFim = @DataFim,QtdVagas = @QtdVagas,IdDisciplina = @IdDisciplina WHERE IdTurma=@IdTurma", conn);
            cmd.Parameters.AddWithValue("@IdTurma", obj.IdTurma);
            cmd.Parameters.AddWithValue("@Turma", obj.NomeTurma);
            cmd.Parameters.AddWithValue("@Ano", obj.ano);
            cmd.Parameters.AddWithValue("@Horario", obj.horario);
            cmd.Parameters.AddWithValue("@DataInicio", obj.DataInicio);
            cmd.Parameters.AddWithValue("@DataFim", obj.DataFim);
            cmd.Parameters.AddWithValue("@QtdVagas", obj.QtdVagas);
            cmd.Parameters.AddWithValue("@IdDisciplina", obj.IdDisciplina);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string id)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();



            SqlCommand cmd = new SqlCommand("DELETE FROM Turma WHERE idTurma = @IdTurma", conn);
            cmd.Parameters.AddWithValue("@IdTurma", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Turma Select(string ID)
        {
            Modelo.Turma Turma = new Modelo.Turma();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * FROM Turma WHERE IdTurma = @idTurma";
            cmd.Parameters.AddWithValue("@idTurma", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                      Turma.IdTurma=int.Parse(dr["IdTurma"].ToString());
                      Turma.NomeTurma= dr["Turma"].ToString();
                      Turma.ano= int.Parse(dr["Ano"].ToString());
                      Turma.horario = dr["Horario"].ToString();
                      Turma.DataInicio=  DateTime.Parse(dr["DataInicio"].ToString());
                      Turma.DataFim=  DateTime.Parse(dr["DataFim"].ToString());
                      Turma.QtdVagas=  int.Parse(dr["QtdVagas"].ToString());
                      Turma.IdDisciplina=  int.Parse(dr["IdDisciplina"].ToString());


            }
            conn.Close();
            return Turma;


        }
        public int GetIdMax()
        {
            int max=0;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Max(IdTurma) as Max From Turma",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    max = (int.Parse(dr["Max"].ToString())) + 1;
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