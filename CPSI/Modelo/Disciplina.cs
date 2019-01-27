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
        private List<Modelo.DocumentoDisciplina> listDocumentoDaDisciplinas;
        private IList<int> listIddocumento;
        public Disciplina()
        {
            this.idDisciplina = 0;
            this.disciplina = "";
            listDocumentoDaDisciplinas = new List<DocumentoDisciplina>();
        }
        public Disciplina(int idDisciplina, string disciplina)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
            listDocumentoDaDisciplinas = new List<DocumentoDisciplina>();

        }
        public void  addDocumentoDisciplina(IList<int> listIddocumento)
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
        public List<DocumentoDisciplina> getDocumentoDisciplina()
        {
            foreach (int i in listIddocumento)
            {
                listDocumentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina, i));
            }
            return listDocumentoDaDisciplinas;
        }
        
 
       
    }
}