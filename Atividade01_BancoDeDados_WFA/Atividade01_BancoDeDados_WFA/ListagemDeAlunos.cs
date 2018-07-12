using Atividade01_BancoDeDados_WFA.MODELO;
using Atividade01_BancoDeDados_WFA.REPOSITÓRIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01_BancoDeDados_WFA
{
    public partial class ListagemDeAlunos : Form
    {
        public ListagemDeAlunos()
        {
            InitializeComponent();
        }

        private void ListagemDeAlunos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string pesquisa = "";
            List<Alunos> alunos = new AlunosRepositorio().ObterTodosOsAlunos(textBox1.Text);
            foreach (Alunos aluno in alunos)
            {
                dataGridView1.Rows.Add(new object[]
                
                {
                    aluno.Id,
                    aluno.Nome,
                    aluno.Matricula,
                    aluno.Nota_01,
                    aluno.Nota_02,
                    aluno.Nota_03
                    
                
                });
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroDeAlunos().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }


    }
}
