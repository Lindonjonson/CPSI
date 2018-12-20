using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class DocumentoDisciplina
    {
        public int idDisciplina { get; set; }
        private List<int> ListIdDocumento = new List<int>();
        public DocumentoDisciplina()
        {
            
        }
        public DocumentoDisciplina(int idDisciplina)
        {
            this.idDisciplina = idDisciplina;
        }
        public List<int> GetListDocumentos()
        {
            return ListIdDocumento;
        }
        public void AddIdDocumento(int IdDocumento)
        {
            ListIdDocumento.Add(IdDocumento);

        }
       
    }
}