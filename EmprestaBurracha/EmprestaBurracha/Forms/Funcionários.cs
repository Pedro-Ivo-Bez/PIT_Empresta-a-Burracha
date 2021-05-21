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
        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(Nome.Text != "" && Email.Text != "" && Cpf.Text != "" && Funçao.Text != "")
            {
                Erro.Visible = false;
                DataBase.InserirFuncionario(new Funcionario(Nome.Text, Email.Text, Cpf.Text, Funçao.Text));
                Nome.Text = "";
                Email.Text = "";
                Cpf.Text = "";
                Funçao.Text = "";
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
                    DataBase.RemoverTodosEmprestimosDeUmFuncionario(NomeFuncionario, emp.Material, emp.Quantidade);
                    DataBase.DemitirFuncionario(CpfFuncionario);
                }
                else if(res == DialogResult.No) 
                {
                    DataBase.DemitirFuncionario(CpfFuncionario);
                }
            }
            else
            {
                DataBase.DemitirFuncionario(CpfFuncionario);
            }
            Listar();
        }
    }
}
