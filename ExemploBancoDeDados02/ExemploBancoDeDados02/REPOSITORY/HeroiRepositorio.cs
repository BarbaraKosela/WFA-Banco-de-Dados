using ExemploBancoDeDados02.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDeDados02.REPOSITORY
{
    public class HeroiRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104962\Documents\ExemploBancoDeDados02.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;
        public HeroiRepositorio ()
	        {
                connection = new SqlConnection(connectionString);
	        } 


        public bool Inserir(Heroi heroi) {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "INSERT INTO herois (nome, escuridao, nome_pessoa, raca, conta_bancaria, data_nascimento, sexo, quantidade_filmes, descricao) VALUES (@NOME, @ESCURIDAO, @NOME_PESSOA, @RACA, @CONTA_BANCARIA, @DATA_NASCIMENTO, @SEXO, @QUANTIDADE_FILMES, @DESCRICAO)";
            comando.Parameters.AddWithValue("@NOME", heroi.Nome);
            comando.Parameters.AddWithValue("@ESCURIDAO", heroi.Escuridao);
            comando.Parameters.AddWithValue("@NOME_PESSOA", heroi.NomePessoa);
            comando.Parameters.AddWithValue("@RACA", heroi.Raca);
            comando.Parameters.AddWithValue("@CONTA_BANCARIA", heroi.ContaBancaria);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", heroi.DataNascimento);
            comando.Parameters.AddWithValue("@SEXO", heroi.Sexo);
            comando.Parameters.AddWithValue("@QUANTIDADE_FILMES", heroi.QuantidadeFilmes);
            comando.Parameters.AddWithValue("@DESCRICAO", heroi.Descricao);
            int quantidadeRegistros = comando.ExecuteNonQuery();
            connection.Close();

            return quantidadeRegistros == 1;
        }


        public bool Alterar(Heroi heroi) { return false; }
        public List<Heroi> ObterTodos() { return null; }
        public Heroi ObterPeloCodigo(int codigo) { return null; }
        public bool Apagar(int codigo) { return false; }
    }
}
