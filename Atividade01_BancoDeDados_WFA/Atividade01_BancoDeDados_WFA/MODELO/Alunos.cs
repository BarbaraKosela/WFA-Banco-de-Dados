using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_BancoDeDados_WFA.MODELO
{
    class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Nota_01 { get; set; }
        public double Nota_02 { get; set; }
        public double Nota_03 { get; set; }
        public int Frequencia { get; set; }

        internal void Add(Alunos aluno)
        {
            throw new NotFiniteNumberException();
        }


    }
}
