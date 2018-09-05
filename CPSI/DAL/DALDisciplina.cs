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
    public class DALDisciplina
    {
        string connectionString = "";

        public DALDisciplina()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                      ["CPSIConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Disciplina> SelectAll()
        {
            Modelo.Disciplina aTitle;
            List<Modelo.Disciplina> aListDisciplina = new List<Modelo.Disciplina>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Disciplina";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) 
                {
            
                    aTitle = new Modelo.Disciplina(
                        int.Parse(dr["idDisciplina"].ToString()),
                        dr["Disciplina"].ToString(),
                        dr["Codigo"].ToString()
                        );
             
                    aListDisciplina.Add(aTitle);
                }
            }
      
            dr.Close();

            conn.Close();

            return aListDisciplina;
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Disciplina obj)
        {
            
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
    
            SqlCommand com = conn.CreateCommand();
       
            SqlCommand cmd = new SqlCommand("INSERT INTO Disciplina (Codigo, Disciplina) VALUES(@Codigo,@Disciplina)", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", obj.idDisciplina);
            cmd.Parameters.AddWithValue("@Codigo",obj.codigo);
            cmd.Parameters.AddWithValue("@Disciplina", obj.disciplina);          

         
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Disciplina obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);
   
            conn.Open();
  
            SqlCommand com = conn.CreateCommand();
 
            SqlCommand cmd = new SqlCommand("UPDATE Disciplina SET Disciplina = @Disciplina, Codigo=@Codigo WHERE idDisciplina = @idDisciplina", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", obj.idDisciplina);
            cmd.Parameters.AddWithValue("@Codigo", obj.codigo);
            cmd.Parameters.AddWithValue("@Disciplina", obj.disciplina);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
         
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string id)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand com = conn.CreateCommand();

            SqlCommand cmd = new SqlCommand("DELETE FROM Disciplina WHERE idDisciplina = @idDisciplina", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Disciplina Select(string ID)
        {
            Modelo.Disciplina disciplina = new Disciplina();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText="select * FROM Disciplina WHERE IdDisciplina = @idDisciplina";
            cmd.Parameters.AddWithValue("@idDisciplina", ID );
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                disciplina.idDisciplina = int.Parse(dr["idDisciplina"].ToString());
                disciplina.codigo = dr["Codigo"].ToString();
                disciplina.disciplina = dr["Disciplina"].ToString();
                
                        

            }
            conn.Close();
            return disciplina;
           

        }



    }
}