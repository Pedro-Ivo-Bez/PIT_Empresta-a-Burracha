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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Teste_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet1.Materiais'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaisTableAdapter.Fill(this.emprestaBurrachaDataSet1.Materiais);
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.emprestaBurrachaDataSet.Funcionarios);
        }

        private void Listar()
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Nome.Text != "" && Quantidade.Value != 0)
            {
                DataBase.AdicionarOuModificarMaterial(Nome.Text, new Material(Nome.Text, Convert.ToInt32(Quantidade.Value)));
                Listar();
                Nome.Text = "";
                Quantidade.Value = 0;
                Nome.Focus();
                Erro.Visible = false;
                Nome.Enabled = true;
                return;
            }
            Nome.Enabled = true;
            Erro.Text = "Insira todos os dados corretamente";
            Erro.Visible = true;
        }

        private void MateriaisDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = MateriaisDVG.SelectedCells[0].RowIndex;
            string NomeMaterial = (string)MateriaisDVG.Rows[LinhaSelecionada].Cells[0].Value;
            int QuantidadeMaterial = (int)MateriaisDVG.Rows[LinhaSelecionada].Cells[1].Value;

            Nome.Text = NomeMaterial;
            Nome.Enabled = false;
            Quantidade.Value = QuantidadeMaterial;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Nome.Text = "";
            Quantidade.Value = 0;
            Nome.Enabled = true;
            Listar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = MateriaisDVG.SelectedCells[0].RowIndex;
            string NomeMaterial = (string)MateriaisDVG.Rows[LinhaSelecionada].Cells[0].Value;

            DataBase.RemoverMaterial(NomeMaterial);
            Nome.Text = "";
            Quantidade.Value = 0;
            Nome.Enabled = true;
            Listar();
        }
    }
}
