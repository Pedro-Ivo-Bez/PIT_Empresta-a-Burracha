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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Listar()
        {
            foreach(Material m in Console.Materiais)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(m.Id));
                item.SubItems.Add(m.Nome);
                item.SubItems.Add(Convert.ToString(m.Quantidade));
                listView1.Items.Add(item);
            }
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Nome.Text != "" && Quantidade.Value != 0)
            {
                Console.AdicionarMaterial(new Material(Nome.Text, Convert.ToInt32(Quantidade.Value)));
                Listar();
                Erro.Visible = false;
                return;
            }
            Erro.Text = "Insira todos os dados corretamente";
            Erro.Visible = true;
        }
    }
}
