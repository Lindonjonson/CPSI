using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Documento
    {
        public int idDocumento { get; set; }
        public string documento { get; set; }
        public bool validade { get; set; }
        public int tipo { get; set; }
        public Documento()
        {
            this.idDocumento = 0;
            this.documento = "";
        }
        public Documento(int idDocumento, string documento, bool validade,int tipo)
        {
            this.idDocumento = idDocumento;
            this.documento = documento;
            this.validade = validade;
            this.tipo = tipo;
        }


    }
}