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
        private List<int> ListIddocumento;
        private List<Modelo.DocumentoDisciplina> ListdocumentoDaDisciplinas;
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
        public void  AddDocumentoDisciplina(List<int> ListIddocumento)
        {

            this.ListIddocumento = ListIddocumento;
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
            if (ListdocumentoDaDisciplinas == null)
            {
                ListdocumentoDaDisciplinas = new List<DocumentoDisciplina>();
                foreach (int i in ListIddocumento)
                {
                    ListdocumentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina, i));
                }
                return ListdocumentoDaDisciplinas;
            }
            else
                return ListdocumentoDaDisciplinas;


        }
        public void SetDocumentoDisciplina(List<Modelo.DocumentoDisciplina> ListdocumentoDaDisciplinas)
        {
            this.ListdocumentoDaDisciplinas = ListdocumentoDaDisciplinas;

        }
       
    }
}