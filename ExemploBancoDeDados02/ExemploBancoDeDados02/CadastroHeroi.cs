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
    public partial class CadastroHeroi : Form
    {
        private int codigo;

        public CadastroHeroi()
        {
            InitializeComponent();
        }

        public CadastroHeroi(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(codigo);
            PreencherCampos(heroi);


        }

        private void PreencherCampos(Heroi heroi)
        {
            txtNome.Text = heroi.Nome;
            TXTNOMEPESSOA.Text = heroi.NomePessoa;
            txtcodigo.Text = Convert.ToString(heroi.Id);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            TXTQUANTIDADEFILMES.Text = Convert.ToString(heroi.QuantidadeFilmes);
            CBRACA.SelectedItem = heroi.Raca;
            CHBMULHER.Checked = heroi.Sexo == 'm';
            rtbDescicao.Text = heroi.Descricao;
            if (heroi.Escuridao)
            {
                radioButton1.Checked = true;
            }

            else
            {
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = TXTNOMEPESSOA.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = radioButton1.Checked;
            heroi.QuantidadeFilmes = Convert.ToByte(TXTQUANTIDADEFILMES.Text);
            heroi.Raca = CBRACA.SelectedItem.ToString();
            heroi.Sexo = CHBMULHER.Checked ? 'f' : 'm';
            heroi.Descricao = rtbDescicao.Text;
            if (string.IsNullOrEmpty(txtcodigo.Text)) 
            {
                bool cadastrou = new HeroiRepositorio().Inserir(heroi);
                if (cadastrou)
                {
                    MessageBox.Show("Registro cadastrado com sucesso");
                }

                else
                {
                    MessageBox.Show("Seu registro não foi cadastrado");
                }
            }

            
            else
            {
                int id = Convert.ToInt32(txtcodigo.Text);
                heroi.Id = id;
                bool alterou = new HeroiRepositorio().Alterar(heroi);
                if(alterou)
                
                {
                    MessageBox.Show("Registro alterado com sucesso");
                }

                else
                {
                    MessageBox.Show("Não foi possível alterar");
                }
            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtcodigo.Text);
                    Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(id);
                    if (heroi != null)
                    {
                        PreencherCampos(heroi);
                    }

                    else
                    {
                        MessageBox.Show("Código não existente");
                        txtcodigo.Focus();

                        txtcodigo.SelectionStart = 0;
                        txtcodigo.SelectionLength = txtcodigo.Text.Length;
                    }
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show("Digite um código válido");
                    txtcodigo.Focus();
                }
            } 
        }
    }
}
