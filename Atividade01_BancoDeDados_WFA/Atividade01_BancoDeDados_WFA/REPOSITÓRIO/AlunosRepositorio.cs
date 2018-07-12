using Atividade01_BancoDeDados_WFA.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_BancoDeDados_WFA.REPOSITÓRIO
{
    class AlunosRepositorio
    {
        private string conectarAString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104962\Documents\Atividade01_BancoDeDados_WFA.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;
        public AlunosRepositorio()
        {
            connection = new SqlConnection(conectarAString);
        }

        public int Inserir(Alunos aluno)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"INSERT INTO alunos (nome, codigo_matricula, nota01, nota02, nota03, frequencia)
OUTPUT INSERTED.ID
VALUES (@NOME, @CODIGO_MATRICULA, @NOTA01, @NOTA02, @NOTA03, @FREQUENCIA)";
            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.Matricula);
            comando.Parameters.AddWithValue("@NOTA01", aluno.Nota_01);
            comando.Parameters.AddWithValue("@NOTA02", aluno.Nota_02);
            comando.Parameters.AddWithValue("@NOTA03", aluno.Nota_03);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            int id = Convert.ToInt32(comando.ExecuteScalar().ToString());

            connection.Close();
            return id;
        }

        public bool Alterar(Alunos aluno)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"UPDATE alunos SET nome = @NOME, codigo_matricula = @CONTA_BANCARIA, nota01 = @NOTA01,
nota02 = @NOTA02, nota03 = @NOTA03, frequencia = @FREQUENCIA WHERE id = @ID)";

            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.Matricula);
            comando.Parameters.AddWithValue("@NOTA01", aluno.Nota_01);
            comando.Parameters.AddWithValue("@NOTA02", aluno.Nota_02);
            comando.Parameters.AddWithValue("@NOTA03", aluno.Nota_03);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            int quantidadeQueAlterou = comando.ExecuteNonQuery();
            connection.Close();
            return quantidadeQueAlterou == 1;
        }

        public List<Alunos> ObterTodosOsAlunos(string textoPesquisar = "%%", string ordenar = "nome", string ordem = "ASC")
        {
            textoPesquisar = "%" + textoPesquisar + "%";
            List<Alunos> alunos = new List<Alunos>();
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT id, nome, codigo_matricula, nota01,
nota02, nota03, frequencia FROM alunos WHERE nome LIKE @PESQUISA OR codigo_matricula LIKE @PESQUISA ORDER BY " + ordenar + "" + ordem;
            comando.Parameters.AddWithValue("@PESQUISA", textoPesquisar);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Alunos aluno = new Alunos();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0].ToString());
                aluno.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Matricula = tabelaEmMemoria.Rows[i][2].ToString();
                aluno.Nota_01 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3].ToString());
                aluno.Nota_02 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4].ToString());
                aluno.Nota_03 = Convert.ToDouble(tabelaEmMemoria.Rows[i][5].ToString());
                aluno.Frequencia = Convert.ToInt32(tabelaEmMemoria.Rows[i][6].ToString());
            }
            connection.Close();
            return alunos;
        }


        public Alunos ObterAlunosPorCodigo(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT id, nome, codigo_matricula, nota01,
nota02, nota03, frequencia WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", codigo);
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            Alunos aluno = new Alunos();
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][0].ToString());
            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.Matricula = tabelaEmMemoria.Rows[0][2].ToString();
            aluno.Nota_01 = Convert.ToDouble(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota_02 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Nota_03 = Convert.ToDouble(tabelaEmMemoria.Rows[0][5].ToString());
            aluno.Frequencia = Convert.ToInt32(tabelaEmMemoria.Rows[0][6].ToString());

            connection.Close();
            return aluno;
        }

        public bool Apagar(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            connection.Close();

            return quantidade == 1;
        }

        public double ObterMedia()
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "SELECT nome, ((nota_1 + nota_2 + nota_3 + nota_4) /4) FROM alunos";
            double total = Convert.ToDouble(comando.ExecuteScalar());
            connection.Close();
            return total;

        }

    }
}
