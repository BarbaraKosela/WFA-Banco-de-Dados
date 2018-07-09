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
            heroi.Nome = "Batman";
            heroi.NomePessoa = "Bruce Wayne";
            heroi.ContaBancaria =  12000000000.00;
            heroi.DataNascimento = new DateTime(1976, 2, 19);
            heroi.Escuridao = true;
            heroi.QuantidadeFilmes = 10;
            heroi.Raca = "Humano";
            heroi.Sexo = 'M';
            heroi.Descricao = "";
            new HeroiRepositorio().Inserir(heroi);
        }
    }
}
