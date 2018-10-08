using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Documento:DocumentoDisciplina
    {
        public int idDocumento { get; set; }
        public string documento { get; set; }

        public Documento()
        {
            this.idDocumento = 0;
            this.documento = "";
        }

        public Documento(int idDocumento, string documento,int idDisciplina)
        {
            this.idDocumento = idDocumento;
            this.documento = documento;
            this.idDisciplina = idDisciplina;
        }
        public Documento(int idDocumento, string documento)
        {
            this.idDocumento = idDocumento;
            this.documento = documento;
        }


    }
}