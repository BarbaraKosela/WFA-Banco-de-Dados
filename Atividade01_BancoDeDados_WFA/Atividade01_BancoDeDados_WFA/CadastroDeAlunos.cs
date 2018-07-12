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
            //PreencherCampos(aluno);
        }

        private void CadastroDeAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtNumeroDaMatricula.Text;
            aluno.Nota_01 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota_02 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota_03 = Convert.ToDouble(txtNota3.Text);
            aluno.Frequencia = Convert.ToInt32(txtFrequencia.Text);

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new AlunosRepositorio().Inserir(aluno);
                txtCodigo.Text = Convert.ToString(id);
                MessageBox.Show("O aluno" + aluno.Nome + "foi cadastrado com sucesso");

            }
        }
    }
}
