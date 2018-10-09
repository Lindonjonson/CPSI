﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormRegistrarDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           IDTituloDisciplina.Text=Session["NomeTurma"].ToString();
        }

        protected void Click_Matricular(object sender, EventArgs e)
        {
                DAL.DALMatricula insertMatricula = new DAL.DALMatricula();
                DataKey dataKeyID = DetailsViewAluno.DataKey;
                string ID = dataKeyID.Values["IdAluno"].ToString();
                Modelo.Matricula matricula = new Modelo.Matricula(int.Parse(ID), int.Parse(Session["IdTurma"].ToString()),1,DateTime.Now);
                insertMatricula.Insert(matricula);
                List<int> listIDdocumentos = new List<int>();
                foreach (ListItem I in CheckBoxListDocumento.Items)
                {
                    if (I.Selected) listIDdocumentos.Add(Convert.ToInt32(I.Value));
                }
                Modelo.AlunoDocumento alunoDocumento = new Modelo.AlunoDocumento(int.Parse(ID),listIDdocumentos);
                DAL.DALAlunoDocumento InsertALunoDocumento =new DAL.DALAlunoDocumento();
                InsertALunoDocumento.Insert(alunoDocumento);  
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");
        }



    }
}