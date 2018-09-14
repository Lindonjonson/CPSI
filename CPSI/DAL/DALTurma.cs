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
            Modelo.Turma ATurma;
            List<Modelo.Turma> aListTurma = new List<Modelo.Turma>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Turma";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    ATurma = new Modelo.Turma(
                        int.Parse(dr["IdTurma"].ToString()),
                        dr["Turma"].ToString(),
                        int.Parse(dr["Ano"].ToString()),
                        dr["Horario"].ToString(),
                        DateTime.Parse(dr["DataInicio"].ToString()),
                        DateTime.Parse(dr["DataFim"].ToString()),
                        int.Parse(dr["QtdVagas"].ToString()),
                        int.Parse(dr["IdDisciplina"].ToString()));
                        

                    aListTurma.Add(ATurma);
                }
            }

            dr.Close();
            conn.Close();

            return aListTurma;
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Turma obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();



            SqlCommand cmd = new SqlCommand("INSERT INTO Turma(IdTurma, Turma, Ano, Horario, DataInicio, DataFim, QtdVagas, IdDisciplina)VALUES(@IdTurma, @Turma, @Ano, @Horario, @DataInicio, @DataFim, @QtdVagas, @IdDisciplina)", conn);
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
            Modelo.Turma ATurma = new Modelo.Turma();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * FROM Turma WHERE IdTurma = @idTurma";
            cmd.Parameters.AddWithValue("@idTurma", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                      ATurma.IdTurma=int.Parse(dr["IdTurma"].ToString());
                      ATurma.NomeTurma= dr["Turma"].ToString();
                      ATurma.ano= int.Parse(dr["Ano"].ToString());
                      ATurma.horario = dr["Horario"].ToString();
                      ATurma.DataInicio=  DateTime.Parse(dr["DataInicio"].ToString());
                      ATurma.DataFim=  DateTime.Parse(dr["DataFim"].ToString());
                      ATurma.QtdVagas=  int.Parse(dr["QtdVagas"].ToString());
                      ATurma.IdDisciplina=  int.Parse(dr["IdDisciplina"].ToString());


            }
            conn.Close();
            return ATurma;


        }

    }
}