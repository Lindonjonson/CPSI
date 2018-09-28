﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Disciplina
{
    public partial class WebFormGerenciarCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DAL.DALDisciplina disciplina = new DAL.DALDisciplina();

            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDisciplina.DataKeys[index];
                string id = keys.Value.ToString();

                Response.Redirect("~\\Admin\\WebFormEditarDisciplina.aspx?ID=" + id);
            }
            if (e.CommandName == "Excluir")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDisciplina.DataKeys[index];
                string id = keys.Value.ToString();

                disciplina.Delete(id);
                Response.Redirect("~\\Admin\\WebFormGerenciarDisciplina.aspx");
            }
        }

        protected void Inserir_Click(object sender, EventArgs e)
        {   
            Modelo.Disciplina disciplina = new Modelo.Disciplina(0,TxtNomeDisciplina.Text);
            DAL.DALDisciplina insertDisciplina = new DAL.DALDisciplina();
            disciplina.idDisciplina = insertDisciplina.Insert(disciplina);
            List<int> listIDdocumentos = new List<int>();
            foreach( ListItem I in CheckBoxListDocumento.Items)
            {
                if (I.Selected) listIDdocumentos.Add(Convert.ToInt32(I.Value)); 
            }

            Modelo.DocumentoDisciplina documentoDisciplina = new Modelo.DocumentoDisciplina(listIDdocumentos, disciplina.idDisciplina);
            DAL.DALDocumentoDisciplina InsertDocumentoDisciplina = new DAL.DALDocumentoDisciplina();
            InsertDocumentoDisciplina.Insert(documentoDisciplina);
            Response.Redirect("~\\Admin\\WebFormGerenciarDisciplina.aspx");
            
            
           
            
        }
    }
}