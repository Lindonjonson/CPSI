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
        private List<int> listIddocumento;
        private List<Modelo.DocumentoDisciplina> listDocumentoDaDisciplinas;
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
        public void  addDocumentoDisciplina(List<int> listIddocumento)
        {

            this.listIddocumento = listIddocumento;
        }
        public bool existDocumento()
        {
            if (listIddocumento.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Modelo.DocumentoDisciplina> getDocumentoDisciplina()
        {
            if (listDocumentoDaDisciplinas == null)
            {
                listDocumentoDaDisciplinas = new List<DocumentoDisciplina>();
                foreach (int i in listIddocumento)
                {
                    listDocumentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina, i));
                }
                return listDocumentoDaDisciplinas;
            }
            else
                return listDocumentoDaDisciplinas;


        }
        public void setDocumentoDisciplina(List<Modelo.DocumentoDisciplina> listdocumentoDaDisciplinas)
        {
            this.listDocumentoDaDisciplinas = listdocumentoDaDisciplinas;

        }
       
    }
}