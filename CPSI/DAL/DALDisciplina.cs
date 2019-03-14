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
            Modelo.Disciplina disciplina;
            List<Modelo.Disciplina> ListDisciplina = new List<Modelo.Disciplina>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Disciplina Order by Disciplina";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) 
                {
            
                    disciplina = new Modelo.Disciplina(
                        int.Parse(dr["idDisciplina"].ToString()),
                        dr["Disciplina"].ToString()
                        );
             
                    ListDisciplina.Add(disciplina);
                }
            }
      
            dr.Close();
            conn.Close();

            return ListDisciplina;
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Disciplina obj)
        {
            
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            if (obj.idDisciplina == 0)
                obj.idDisciplina = GetIdMax() + 1;

            SqlCommand cmd = new SqlCommand("INSERT INTO Disciplina (IdDisciplina, Disciplina) VALUES(@idDisciplina,@Disciplina)", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", obj.idDisciplina);
            cmd.Parameters.AddWithValue("@Disciplina", obj.disciplina);
            cmd.ExecuteNonQuery();
            if (obj.existDocumento())
            {
                new DAL.DALDocumentoDisciplina().Insert(obj);
               
            }
            conn.Close();

           
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Disciplina obj)
        {

            SqlConnection conn = new SqlConnection(connectionString);
   
            conn.Open();
  
            
 
            SqlCommand cmd = new SqlCommand("UPDATE Disciplina SET Disciplina = @Disciplina WHERE idDisciplina = @idDisciplina", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", obj.idDisciplina);
            cmd.Parameters.AddWithValue("@Disciplina", obj.disciplina);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
         
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(string id)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Disciplina WHERE idDisciplina = @idDisciplina", conn);
            cmd.Parameters.AddWithValue("@idDisciplina", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Disciplina Select(string ID)
        {
            Modelo.Disciplina disciplina = new Modelo.Disciplina();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText="select * FROM Disciplina WHERE IdDisciplina = @idDisciplina";
            cmd.Parameters.AddWithValue("@idDisciplina", ID );
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                disciplina.idDisciplina = int.Parse(dr["idDisciplina"].ToString());
                disciplina.disciplina = dr["Disciplina"].ToString();
                
                        

            }
            DAL.DALDocumentoDisciplina dALDocumentoDisciplina = new DALDocumentoDisciplina();
            disciplina.listDocumento=dALDocumentoDisciplina.SelectALL(disciplina.idDisciplina.ToString());
            conn.Close();
            return disciplina;
           

        }

        public int GetIdMax()
        {
            int max = 0;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Max(IdDisciplina) as Max FROM Disciplina";
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