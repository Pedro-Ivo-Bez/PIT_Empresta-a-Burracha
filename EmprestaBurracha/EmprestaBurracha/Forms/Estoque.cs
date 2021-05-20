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
                adaptador = DB.RetornarMateriais();
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
                DB.InserirMaterial(new Material(Nome.Text, Convert.ToInt32(Quantidade.Value)));
                Listar();
                Erro.Visible = false;
                return;
            }
            Erro.Text = "Insira todos os dados corretamente";
            Erro.Visible = true;
        }
    }
}
