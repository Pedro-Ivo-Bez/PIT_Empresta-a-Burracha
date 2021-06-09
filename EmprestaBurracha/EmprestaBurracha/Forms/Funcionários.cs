using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmprestaBurracha.Forms
{
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }
        
        private void Funcionários_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.emprestaBurrachaDataSet.Funcionarios);
            Listar();
            EntradaTexto.Enabled = false;
        }
        
        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarFuncionarios();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    FuncionariosDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
        private void ListarTipo(string Tipo, string Arg)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.BuscarFuncionario(Tipo, Arg);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    FuncionariosDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(Nome.Text != "" && Email.Text != "" && Cpf.Text != "" && Funçao.Text != "")
            {
                Erro.Visible = false;
                DataBase.AdicionarOuEditarFuncionario(new Funcionario(Nome.Text, Email.Text, Cpf.Text, Funçao.Text), Cpf.Text);
                Limpar();
                Listar();
                return;
            }
                Erro.Text = "Insira todos os dados corretamente";
                Erro.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = FuncionariosDGV.SelectedCells[0].RowIndex;
            string CpfFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[2].Value;
            string NomeFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            Emprestimo emp = DataBase.RetornarEmprestimoUnico(NomeFuncionario);

            if(emp != null) 
            {
                DialogResult res = MessageBox.Show("Esse funcionários tem empréstimos ativos, deseja devolver todos os empréstimos?", "Devolver", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    Limpar();
                    DataBase.RemoverTodosEmprestimosDeUmFuncionario(NomeFuncionario, emp.Material, emp.Quantidade);
                    DataBase.DemitirFuncionario(CpfFuncionario);
                }
                else if(res == DialogResult.No) 
                {
                    Limpar();
                    DataBase.DemitirFuncionario(CpfFuncionario);
                }
            }
            else
            {
                Limpar();
                DataBase.DemitirFuncionario(CpfFuncionario);
            }
            Listar();
        }

        private void FuncionariosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = FuncionariosDGV.SelectedCells[0].RowIndex;
            string NomeFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            Funcionario f = DataBase.RetornarFuncionarioUnico(NomeFuncionario);

            Cpf.Enabled = false;
            Nome.Text = f.Nome;
            Email.Text = f.Email;
            Cpf.Text = f.Cpf;
            Funçao.Text = f.Função;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            Cpf.Enabled = true;
            Nome.Text = "";
            Email.Text = "";
            Cpf.Text = "";
            Funçao.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListarTipo(Entrada.Text, EntradaTexto.Text);
        }

        private void Entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntradaTexto.Enabled = true;
        }
    }
}
