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
    public partial class CadastroDeAlunos : Form
    {
        private int codigo;
        public CadastroDeAlunos()
        {
            InitializeComponent();
        }

        public CadastroDeAlunos(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Alunos aluno = new AlunosRepositorio().ObterAlunosPorCodigo(codigo);
            PreencherCampos(aluno);
        }

        private void CadastroDeAlunos_Load(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            double totalMedia = ((aluno.Nota_01 + aluno.Nota_02 + aluno.Nota_03) / 3);
            label8.Text = Convert.ToString(totalMedia);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            PreencherCampos(aluno);

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new AlunosRepositorio().Inserir(aluno);
                txtCodigo.Text = Convert.ToString(id);
                MessageBox.Show("O aluno " + aluno.Nome + " foi cadastrado com sucesso");

            }

            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                aluno.Id = id;
                bool alterou = new AlunosRepositorio().Alterar(aluno);
                if (alterou)
                {
                    MessageBox.Show("Registro alterado com sucesso");
                }

                else
                {
                    MessageBox.Show("Não foi possível alterar");
                }


            }
        }

        private void PreencherCampos(Alunos aluno)
        {
            txtCodigo.Text = Convert.ToString(aluno.Id);
            txtNome.Text = aluno.Nome;
            txtNumeroDaMatricula.Text = aluno.Matricula;
            txtNota1.Text = Convert.ToString(aluno.Nota_01);
            txtNota2.Text = Convert.ToString(aluno.Nota_02);
            txtNota3.Text = Convert.ToString(aluno.Nota_03);
            txtFrequencia.Text = Convert.ToString(aluno.Frequencia);
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    Alunos aluno = new AlunosRepositorio().ObterAlunosPorCodigo(id);
                    if (aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Código não é existente");
                        txtCodigo.Focus();

                        txtCodigo.SelectionStart = 0;
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;
                    }
                }

                catch
                {
                    MessageBox.Show("Digite um código válido");
                    txtCodigo.Focus();
                }
            }
        }
    }
}
