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
    public partial class Emprestar : Form
    {
        public Emprestar()
        {
            InitializeComponent();
        }

        private void Emprestar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet1.Materiais'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaisTableAdapter.Fill(this.emprestaBurrachaDataSet1.Materiais);
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.emprestaBurrachaDataSet.Funcionarios);
            ListarFuncionarios();
            ListarItens();

        }

        private void ListarItens()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarMateriais();
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
                    MateriaisDVG.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
        private void ListarFuncionarios()
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
        private void Erro(String erro)
        {
            LabelErro.Text = erro;
            LabelErro.Visible = true;
        }
        private void RemoverErro()
        {
            LabelErro.Text = " ";
            LabelErro.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = FuncionariosDGV.SelectedCells[0].RowIndex;
            string NomeFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = MateriaisDVG.SelectedCells[0].RowIndex;
            string NomeMaterial = (string)MateriaisDVG.Rows[LinhaSelecionada1].Cells[0].Value;

            Funcionario f = DataBase.RetornarFuncionarioUnico(NomeFuncionario);
            Material m = DataBase.RetornarMaterialUnico(NomeMaterial);

            DateTime hoje = DateTime.Now;
            if (SelecionadorDatas.Value < hoje)
            { 
                Erro("Insira uma data válida");
                return;
            }
            if (Quantidade.Value == 0 || Quantidade.Value > m.Quantidade)
            {
                Erro("Insira uma quantidade válida de itens");
                return;
            }
            if (SelecionadorDatas.Value.Day != hoje.Day || SelecionadorDatas.Value.Month != hoje.Month || SelecionadorDatas.Value.Year != hoje.Year)
            {
                DataBase.Emprestar(m, f, Convert.ToInt32(Quantidade.Value), SelecionadorDatas.Value);
                DataBase.AdicionarOuModificarMaterial(NomeMaterial, new Material(NomeMaterial, m.Quantidade - Convert.ToInt32(Quantidade.Value)));
                ListarItens();
                RemoverErro();
            }
            else
            {
                Erro("Insira uma data que não seja hoje");
            }
        }
    }
}
