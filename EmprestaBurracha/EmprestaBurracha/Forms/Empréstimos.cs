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
                listView1.Items.Add(item);
            }
        }

        private void Empréstimos_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
