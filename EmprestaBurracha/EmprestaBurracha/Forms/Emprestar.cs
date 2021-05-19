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
    public partial class Emprestar : Form
    {
        public Emprestar()
        {
            InitializeComponent();
        }

        private void Emprestar_Load(object sender, EventArgs e)
        {
            ListarFuncionarios();
            ListarItens();

        }

        private void ListarFuncionarios()
        {
            Funcionarios.Items.Clear();
            foreach (Funcionario f in Console.Funcionarios)
            {
                if (f.Ativo)
                {
                    ListViewItem item = new ListViewItem(f.Nome);
                    Funcionarios.Items.Add(item);
                }
            }
        }
        private void ListarItens()
        {
            Itens.Items.Clear();
            foreach (Material m in Console.Materiais)
            {
                    ListViewItem item = new ListViewItem(m.Nome);
                    item.SubItems.Add(Convert.ToString(m.Quantidade));
                    Itens.Items.Add(item);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach(Material m in Console.Materiais)
            {
                if(m.Nome == Itens.SelectedItems[0].Text)
                {
                    foreach (Funcionario f in Console.Funcionarios)
                    {

                        if (f.Nome == Funcionarios.SelectedItems[0].Text)
                        {
                            Console.AdicionarEmprestimo(new Emprestimo(m, Convert.ToInt32(Quantidade.Value), Calendario.SelectionStart, f));
                        }
                    }   
                }
            }

        }
    }
}
