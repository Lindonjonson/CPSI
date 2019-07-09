﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CPSI.Modelo;

namespace CPSI.DAL
{
    public class DALDocumento
    {
        private string connectionString = "";

        public DALDocumento()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                      ["CPSIConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Documento> SelectAll()
        {
            Modelo.Documento documento;
            List<Modelo.Documento> ListaDocumento = new List<Modelo.Documento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Documento", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    documento = new Modelo.Documento(
                        int.Parse(dr["IdDocumento"].ToString()),
                        dr["Documento"].ToString()
                        );
                    ListaDocumento.Add(documento);

                }
            }

            dr.Close();

            conn.Close();

            return ListaDocumento;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Documento Select(string ID)
        {

            Modelo.Documento documento = new Modelo.Documento();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Documento where IdDocumento= @ID", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                documento.idDocumento = int.Parse(dr["IdDocumento"].ToString());
                documento.documento = dr["Documento"].ToString();

            }



            conn.Close();
            dr.Close();
            return documento;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Documento obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Documento (IdDocumento,Documento) values(@IdDocumento,@Documento)", conn);
            cmd.Parameters.AddWithValue("@IdDocumento", GetIdMax());
            cmd.Parameters.AddWithValue("@Documento", obj.documento);
            cmd.ExecuteNonQuery();
            conn.Close();



        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string id)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Documento WHERE IdDocumento = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();



        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Documento obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Documento SET Documento = @documento WHERE IdDocumento = @id", conn);
            cmd.Parameters.AddWithValue("@documento", obj.documento);
            cmd.Parameters.AddWithValue("@id", obj.idDocumento);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public int GetIdMax()
        {
            int max = 0;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Max(IdDocumento) as Max FROM Documento";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                max = (int.Parse(dr["Max"].ToString()))+1;
            }
            conn.Close();
            return max;

        }




    }
}