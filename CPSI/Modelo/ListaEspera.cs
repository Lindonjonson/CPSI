using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class ListaEspera
    {
          public int IdTurma { get; set; }
          public int IdAluno { get; set; }
          public DateTime DataInscricao { get; set; }

          public ListaEspera()
          {



          }
          public ListaEspera(int IdTurma, int IdAluno,DateTime DataInscricao)
          {

            this.DataInscricao = DataInscricao;
            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;

          }
    }
}