using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private static int proximoNumero = 1001;
        public int RA { get; set;}
        public string Nome { get; set;}
        public int Idade { get; set;}

        public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        RA = GerarProximoRA();
    }

    private static int GerarProximoRA()
    {
        int ra = 157048221 * 10000 + proximoNumero;
        proximoNumero++;
        return ra;
    }

    }
}




