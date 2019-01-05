using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Disciplina
    {
        public int idDisciplina { get; set; }
        public string disciplina { get; set; }
        private List<int> ListIddocumento = new List<int>();
     

        public Disciplina()
        {
            this.idDisciplina = 0;
            this.disciplina = "";
           
        }
        public Disciplina(int idDisciplina, string disciplina)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
           
        }
        public void  AddDocumentoDisciplina(int idDocumento)
        {
            ListIddocumento.Add(idDocumento);

        }
        public bool ExistDocumento()
        {
            if (ListIddocumento.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Modelo.DocumentoDisciplina> GetDocumentoDisciplina()
        {
            List<Modelo.DocumentoDisciplina> documentoDaDisciplinas = new List<DocumentoDisciplina>();
            foreach(int i in ListIddocumento)
            {
                documentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina,i));
            }
            return documentoDaDisciplinas;
        }
       
    }
}