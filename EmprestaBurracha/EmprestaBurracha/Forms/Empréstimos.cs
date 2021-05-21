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
    public partial class Empréstimos : Form
    {
        public Empréstimos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarEmprestimos();
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
                    EmprestimosDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }

        private void Empréstimos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet3.Emprestimos'. Você pode movê-la ou removê-la conforme necessário.
            this.emprestimosTableAdapter1.Fill(this.emprestaBurrachaDataSet3.Emprestimos);
            Listar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = EmprestimosDGV.SelectedCells[0].RowIndex;
            int IdEmprestimo = (int)EmprestimosDGV.Rows[LinhaSelecionada].Cells[0].Value;
            int QuantidadeEmprestimo = (int)EmprestimosDGV.Rows[LinhaSelecionada].Cells[3].Value;
            string MaterialEmprestimo = (string)EmprestimosDGV.Rows[LinhaSelecionada].Cells[2].Value;
            Material m = DataBase.RetornarMaterialUnico(MaterialEmprestimo);

            DataBase.AdicionarOuModificarMaterial(MaterialEmprestimo, new Material(m.Nome, m.Quantidade + QuantidadeEmprestimo));
            DataBase.DesfazerEmprestimo(IdEmprestimo);
            Listar();
        }
    }
}
