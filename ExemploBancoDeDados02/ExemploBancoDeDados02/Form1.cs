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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = TXTNOMEPESSOA.Text;
            heroi.ContaBancaria =  Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = radioButton1.Checked;
            heroi.QuantidadeFilmes = Convert.ToByte(TXTQUANTIDADEFILMES.Text);
            heroi.Raca = CBRACA.SelectedItem.ToString();
            heroi.Sexo = CHBMULHER.Checked ? 'f' : 'm';
            heroi.Descricao = rtbDescicao.Text;
            new HeroiRepositorio().Inserir(heroi);
        }
    }
}
