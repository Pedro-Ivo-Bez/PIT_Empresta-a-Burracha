using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmprestaBurracha
{
    class DB
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();
        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=EmprestaBurracha;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            return adaptador;
        }
        public static int Executar(out SqlDataAdapter adaptador)
        {
            conexao.Close();
            adaptador = Inicializar();
            int i = 0;
            conexao.Open();
            i = sql.ExecuteNonQuery();
            conexao.Close();
            return i;
        }
        public static void InserirFuncionario(Funcionario f)
        {
            sql.CommandText = "INSERT INTO Funcionarios (Nome, Email, Cpf, Funcao, Ativo) VALUES (@nome, @email, @cpf, @funcao, @ativo)";
            sql.Parameters.AddWithValue("@nome", f.Nome);
            sql.Parameters.AddWithValue("@email", f.Email);
            sql.Parameters.AddWithValue("@cpf", f.Cpf);
            sql.Parameters.AddWithValue("@funcao", f.Função);
            sql.Parameters.AddWithValue("@ativo", 1);

            Executar(out SqlDataAdapter adapatador);
            sql.Parameters.Clear();
        }
        public static void InserirMaterial(Material m)
        {
            sql.CommandText = "INSERT INTO Materiais (Nome, Quantidade) VALUES (@nome, @quantidade)";
            sql.Parameters.AddWithValue("@nome", m.Nome);
            sql.Parameters.AddWithValue("@quantidade", m.Quantidade);

            Executar(out SqlDataAdapter adapatador);
        }
        public static SqlDataAdapter RetornarFuncionarios()
        {
            sql.CommandText = "SELECT Nome, Email, Cpf, Funcao FROM Funcionarios";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter RetornarMateriais()
        {
            sql.CommandText = "SELECT Nome, Quantidade FROM Materiais";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static void DemitirFuncionario(string Nome)
        {
            sql.CommandText = $"DELETE FROM Funcionarios WHERE Nome = '{Nome}'";
            Executar(out SqlDataAdapter adaptador);
        }
    }
}
