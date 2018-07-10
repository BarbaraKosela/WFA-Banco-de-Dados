using ExemploBancoDeDados02.MODEL;
using ExemploBancoDeDados02.REPOSITORY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDeDados02
{
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroHeroi().ShowDialog();
        }
        private void AtualizarLista()
        {
            string coluna = "nome";
           

            if (radioButton2.Checked)
            {
                coluna = "conta_bancaria";
            }

            else if (radioButton3.Checked)
            {
                coluna = "raca";
            }



            string tipoOrdem = "ASC";
            if(radioButton5.Checked)
            {
                tipoOrdem = "DESC";
            }

            dataGridView1.Rows.Clear();

            string pesquisa = "";
            
            List<Heroi> herois = new HeroiRepositorio().ObterTodos(textBox1.Text, coluna, tipoOrdem);
            foreach(Heroi heroi in herois)
           
            {
                dataGridView1.Rows.Add(new object[]
                
                {
                heroi.Id,
                heroi.Nome,
                heroi.Raca,
                heroi.ContaBancaria
                });
            }
        }
        private void ListaHerois_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo =Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool apagado = new HeroiRepositorio().Apagar(codigo);
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
    
    
    }


}
