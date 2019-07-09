using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class AlunoDocumento
    {
        public int IdAluno {get; set;}
        public List<int> IdDocumento = new List<int>();
        public AlunoDocumento()
        {

        }
        public AlunoDocumento(int IdAluno, List<int> IdDocumento)
        {
            this.IdAluno = IdAluno;
            this.IdDocumento = IdDocumento;

        }

    }
}