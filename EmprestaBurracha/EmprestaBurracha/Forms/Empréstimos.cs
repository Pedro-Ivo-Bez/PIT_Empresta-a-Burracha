using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprestaBurracha.Forms
{
    public partial class Empréstimos : Form
    {
        public Empréstimos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            foreach (Emprestimo e in Console.Emprestimos)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(e.Id));
                item.SubItems.Add(e.Funcionario.Nome);
                item.SubItems.Add(e.Material.Nome);
                item.SubItems.Add($"{e.Devolução.Day}/{e.Devolução.Month}/{e.Devolução.Year}");
                item.SubItems.Add(Convert.ToString(e.Quantidade));
            }
        }

        private void Empréstimos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet2.Emprestimos'. Você pode movê-la ou removê-la conforme necessário.
            this.emprestimosTableAdapter.Fill(this.emprestaBurrachaDataSet2.Emprestimos);
            Listar();
        }
    }
}
