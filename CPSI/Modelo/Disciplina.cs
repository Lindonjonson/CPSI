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
        protected IList<int> listIddocumento;
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
            List<Modelo.DocumentoDisciplina> listDocumentoDaDisciplinas = new List<DocumentoDisciplina>();
            foreach (int i in listIddocumento)
            {
                listDocumentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina, i));
            }
            return listDocumentoDaDisciplinas;
        }
        
 
       
    }
}