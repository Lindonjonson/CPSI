using System;
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
           
            List<Modelo.Documento> ListaDocumento = new List<Modelo.Documento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Documento", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Modelo.Documento documento = new Modelo.Documento();
                    int idDocumento=0;
                    string nomeDocumento="";
                    bool validade = false; 
                    int tipo=0;
                    try
                    {  
                        idDocumento = int.Parse(dr["IdDocumento"].ToString());
                        nomeDocumento = dr["Documento"].ToString();
                        validade = Convert.ToBoolean(dr["Validade"]);
                        tipo = Convert.ToInt32(dr["Tipo"]);
                    }
                    catch (InvalidCastException)
                    {
                        idDocumento = 0;
                        nomeDocumento = "";
                        validade = false;
                        tipo = 1;

                 
                    }
                    finally
                    {
                        documento.idDocumento = idDocumento;
                        documento.documento = nomeDocumento;
                        documento.validade = validade;
                        documento.tipo = tipo;
                        if(documento.idDocumento!=0)
                           ListaDocumento.Add(documento);

                    }


                }
            }

            dr.Close();

            conn.Close();

            return ListaDocumento;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Documento> SelectAll(string tipo)
        {
            Modelo.Documento documento;
            List<Modelo.Documento> ListaDocumento = new List<Modelo.Documento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Documento Where Tipo=@Tipo", conn);
            cmd.Parameters.AddWithValue("@Tipo", tipo);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {

                    documento = new Modelo.Documento(
                        int.Parse(dr["IdDocumento"].ToString()),
                        dr["Documento"].ToString(), Convert.ToBoolean(dr["Validade"]), Convert.ToInt32(dr["Tipo"])
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
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int idDocumento = 0;
                    string nomeDocumento = "";
                    bool validade = false;
                    int tipo = 0;
                    try
                    {
                        idDocumento = int.Parse(dr["IdDocumento"].ToString());
                        nomeDocumento = dr["Documento"].ToString();
                        validade = Convert.ToBoolean(dr["Validade"]);
                        tipo = Convert.ToInt32(dr["Tipo"]);
                    }
                    catch (InvalidCastException)
                    {
                        validade = false;
                        tipo = 1;


                    }
                    finally
                    {
                        documento.idDocumento = idDocumento;
                        documento.documento = nomeDocumento;
                        documento.validade = validade;
                        documento.tipo = tipo;
                        

                    }
                   

                }
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
            SqlCommand cmd = new SqlCommand("insert into Documento (IdDocumento,Documento,Tipo,Validade) values(@IdDocumento,@Documento,@Tipo,@Validade)", conn);
            cmd.Parameters.AddWithValue("@IdDocumento", GetIdMax());
            cmd.Parameters.AddWithValue("@Documento", obj.documento);
            cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
            cmd.Parameters.AddWithValue("@Validade", obj.validade);
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
            SqlCommand cmd = new SqlCommand("UPDATE Documento SET Documento =  @Documento,Tipo =  @Tipo,Validade =  @Validade WHERE IdDocumento =  @IdDocumento", conn);
            cmd.Parameters.AddWithValue("@IdDocumento", obj.idDocumento);
            cmd.Parameters.AddWithValue("@Documento", obj.documento);
            cmd.Parameters.AddWithValue("@Tipo", obj.tipo);
            cmd.Parameters.AddWithValue("@Validade",Convert.ToInt32(obj.validade));
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
            try
            {
                if (dr.Read())
                {
                    max = (int.Parse(dr["Max"].ToString())) + 1;
                }
            }
            catch (FormatException)
            {
                max = 1;

            }
            conn.Close();
            return max;

        }




    }
}