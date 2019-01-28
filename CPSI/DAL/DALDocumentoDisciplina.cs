﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CPSI.DAL
{
    public class DALDocumentoDisciplina
    {
        private string connectionString;
        public DALDocumentoDisciplina()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CPSIConnectionString"].ConnectionString;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<int> SelectALL(string IdDisciplina)
        {


                List<int> ListDocumentoDisciplina = new List<int>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DocumentoDisciplina where IdDisciplina=@IdDisciplina";
                cmd.Parameters.AddWithValue("@IdDisciplina",IdDisciplina);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       ListDocumentoDisciplina.Add(int.Parse(dr["idDocumento"].ToString()));

                    }

                }
               return ListDocumentoDisciplina;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Disciplina disciplina)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            List<Modelo.DocumentoDisciplina> documentoDisciplinas= disciplina.getDocumentoDisciplina();
            foreach (Modelo.DocumentoDisciplina I in documentoDisciplinas )
            {
                  SqlCommand cmd = new SqlCommand("insert into DocumentoDisciplina (IdDisciplina, IdDocumento) values(@IdDisciplina, @IdDocumento)", conn);
                  cmd.Parameters.AddWithValue("@IdDisciplina",I.idDisciplina);
                  cmd.Parameters.AddWithValue("@IdDocumento", I.idDocumento);
                  cmd.ExecuteNonQuery(); 


            }

            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Disciplina disciplina)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from DocumentoDisciplina where IdDisciplina=@IdDisciplina",conn);
            cmd.Parameters.AddWithValue("IdDisciplina",disciplina.idDisciplina);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void update(Modelo.Disciplina disciplina)
        {
            Delete(disciplina);
            if(disciplina.existDocumento())
               Insert(disciplina);
    
        }


    }
}