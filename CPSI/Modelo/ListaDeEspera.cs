using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class ListaDeEspera
    {
          public int IdTurma { get; set; }
          public int IdAluno { get; set; }
          public DateTime DataInscricao { get; set; }

          public ListaDeEspera()
          {



          }
          public ListaDeEspera(int IdTurma, int, int IdAluno,DateTime DataInscricao)
          {

            this.DataInscricao = DataInscricao;
            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;

          }
    }
}