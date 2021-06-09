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
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet2.Emprestimos'. Você pode movê-la ou removê-la conforme necessário.
            this.emprestimosTableAdapter.Fill(this.emprestaBurrachaDataSet2.Emprestimos);
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
        private void ListarFuncionariosTipo(string Arg)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.BuscarFuncionario("Nome", Arg);
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
        private void ListarMaterialTipo(string Arg)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.BuscarMaterial("Nome", Arg);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = FuncionariosDGV.SelectedCells[0].RowIndex;
            string NomeFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = MateriaisDVG.SelectedCells[0].RowIndex;
            string NomeMaterial = (string)MateriaisDVG.Rows[LinhaSelecionada1].Cells[0].Value;

            Funcionario f = DataBase.RetornarFuncionarioUnico(NomeFuncionario);
            Material m = DataBase.RetornarMaterialUnico(NomeMaterial);

            DateTime hoje = DateTime.Now;
            if (SelecionadorDatas.Value < hoje || SelecionadorDatas.Value == hoje) 
            {
                LabelDevolução.ForeColor = Color.Red;
                return;
            }
            if (Quantidade.Value == 0 || Quantidade.Value > m.Quantidade)
            {
                LabelDevolução.ForeColor = Color.White;
                LabelQuant.ForeColor = Color.Red;
                return;
            }
                LabelQuant.ForeColor = Color.White;
                DataBase.Emprestar(m, f, Convert.ToInt32(Quantidade.Value), SelecionadorDatas.Value, DataBase.RetornarId());
                DataBase.AdicionarOuModificarMaterial(NomeMaterial, new Material(NomeMaterial, m.Quantidade - Convert.ToInt32(Quantidade.Value)));
                ListarItens();

                Quantidade.Value = 0;
                SelecionadorDatas.Value = DateTime.Now;

        }

        private void EntradaTexto_TextChanged(object sender, EventArgs e)
        {
            ListarFuncionariosTipo(EntradaTexto.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListarMaterialTipo(textBox1.Text);
        }
    }
}
