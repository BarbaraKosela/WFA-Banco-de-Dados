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


        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroDeAlunos().ShowDialog();
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
        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool apagado = new AlunosRepositorio().Apagar(codigo);

            if (apagado)
            {
                dataGridView1.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso");
            }

            else
            {
                MessageBox.Show("Não foi possível apagar");
            }
        }

        private void label3_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroDeAlunos(codigo).ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }






    }
}
