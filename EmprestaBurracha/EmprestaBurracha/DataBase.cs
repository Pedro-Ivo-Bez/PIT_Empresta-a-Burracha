using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmprestaBurracha
{
    class DataBase
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
            sql.Parameters.Clear();
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
        public static void DesfazerEmprestimo(int id)
        {
            sql.CommandText = $"DELETE FROM Emprestimos WHERE ID = '{id}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void DemitirFuncionario(string Nome)
        {
            sql.CommandText = $"DELETE FROM Funcionarios WHERE Cpf = '{Nome}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void RemoverMaterial(string Nome)
        {
            sql.CommandText = $"DELETE FROM Materiais WHERE Nome = '{Nome}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void RemoverTodosEmprestimosDeUmFuncionario(string nome, Material m, int i)
        {
            sql.CommandText = $"DELETE FROM Emprestimos WHERE NomeFuncionario = '{nome}'";
            Executar(out SqlDataAdapter adaptador);
            AdicionarOuModificarMaterial(m.Nome, new Material(m.Nome, m.Quantidade + i));
        }
        public static void RetirarMaterial(string Nome, int Quantidade)
        {

        }
        public static void Emprestar(Material Material, Funcionario Funcionario, int Quantidade, DateTime Devolução, int id)
        {
            sql.CommandText = "INSERT INTO Emprestimos (NomeFuncionario, Material, Quantidade, Devolucao, ID) VALUES (@nomefuncionario, @material, @quantidade, @devolucao, @id)";
            sql.Parameters.AddWithValue("@nomefuncionario", Funcionario.Nome);
            sql.Parameters.AddWithValue("@material", Material.Nome);
            sql.Parameters.AddWithValue("@quantidade", Quantidade);
            sql.Parameters.AddWithValue("@devolucao", $"{Devolução.Day}/{Devolução.Month}/{Devolução.Year}");
            sql.Parameters.AddWithValue("@id", id);


            Executar(out SqlDataAdapter adaptador);
            sql.Parameters.Clear();
        }
        public static SqlDataAdapter RetornarEmprestimos()
        {
            sql.CommandText = "SELECT NomeFuncionario, Material, Quantidade, Devolucao, Id FROM Emprestimos";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter BuscarFuncionario(string Tipo, string Arg)
        {
            sql.CommandText = $"SELECT * FROM Funcionarios WHERE {Tipo} LIKE '%{Arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter BuscarMaterial(string Tipo, string Arg)
        {
            sql.CommandText = $"SELECT * FROM Materiais WHERE {Tipo} LIKE '%{Arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static SqlDataAdapter BuscarEmprestimos(string Tipo, string Arg)
        {
            sql.CommandText = $"SELECT * FROM Emprestimos WHERE {Tipo} LIKE '%{Arg}%'";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
        public static Funcionario RetornarFuncionarioUnico(string nome)
        {
            sql.CommandText = $"SELECT Nome, Email, Cpf, Funcao FROM Funcionarios WHERE Nome = '{nome}'";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet();adaptador.Fill(ds, "Funcionarios");
            foreach(DataRow Row in ds.Tables["Funcionarios"].Rows)
            {
                string Nome = Row["Nome"].ToString();
                string Email = Row["Email"].ToString();
                string Cpf = Row["Cpf"].ToString();
                string Funcao = Row["Funcao"].ToString();
                return (new Funcionario(Nome, Email, Cpf, Funcao));
            }
            return null;
        }
        public static Material RetornarMaterialUnico(string nome)
        {
            sql.CommandText = $"SELECT Nome, Quantidade FROM Materiais WHERE Nome = '{nome}'";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet(); adaptador.Fill(ds, "Funcionarios");
            foreach (DataRow Row in ds.Tables["Funcionarios"].Rows)
            {
                string Nome = Row["Nome"].ToString();
                int Quantidade = int.Parse(Row["Quantidade"].ToString());
                return (new Material(Nome, Quantidade));
            }
            return null;
        }
        public static Emprestimo RetornarEmprestimoUnico(string nome)
        {
            sql.CommandText = $"SELECT NomeFuncionario, Material, Quantidade, Id FROM Emprestimos WHERE NomeFuncionario = '{nome}'";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet(); adaptador.Fill(ds, "Funcionarios");
            foreach (DataRow Row in ds.Tables["Funcionarios"].Rows)
            {
                string NomeFuncionario = Row["NomeFuncionario"].ToString();
                string Material = Row["Material"].ToString();
                int Quantidade = int.Parse(Row["Quantidade"].ToString());
                DateTime Devo = DateTime.Now;
                int Id = int.Parse(Row["Id"].ToString());
                return (new Emprestimo(RetornarMaterialUnico(Material), Quantidade, Devo, RetornarFuncionarioUnico(NomeFuncionario)));
            }
            return null;
        }
        public static void AdicionarOuModificarMaterial(string NomeMaterial, Material m)
        {
            sql.CommandText = $"UPDATE Materiais SET Nome = '{m.Nome}', Quantidade = '{m.Quantidade}' WHERE Nome = '{NomeMaterial}'";

            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            InserirMaterial(m);
        }

        public static int RetornarId()
        {
            sql.CommandText = $"SELECT Id FROM Ids";
            Executar(out SqlDataAdapter adaptador);

            DataSet ds = new DataSet(); adaptador.Fill(ds, "Ids");
            foreach (DataRow Row in ds.Tables["Ids"].Rows)
            {
                int id = int.Parse(Row["Id"].ToString());
                AtualizarId(id);
                return id + 1;
            }
            return 0;
        }
        private static void AtualizarId(int id)
        {
            sql.CommandText = $"UPDATE Ids SET Id = '{id + 1}' WHERE Id = '{id}'";
            Executar(out SqlDataAdapter adaptador);
        }
        public static void AdicionarOuEditarFuncionario(Funcionario f, string cpf)
        {
            sql.CommandText = $"UPDATE Funcionarios SET Nome = '{f.Nome}', Email = '{f.Email}', Cpf = '{f.Cpf}', Funcao = '{f.Função}' WHERE Cpf = '{cpf}'";
            int i = Executar(out SqlDataAdapter adaptador);

            if (i > 0) return;
            InserirFuncionario(f);
        }
    }
}
