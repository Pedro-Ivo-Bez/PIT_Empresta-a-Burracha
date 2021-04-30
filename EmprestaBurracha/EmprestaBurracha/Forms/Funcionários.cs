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
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }

        private void Funcionários_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            listView1.Items.Clear();
            foreach (Funcionario f in Console.Funcionarios)
            {
                if(f.Ativo)
                {
                    ListViewItem item = new ListViewItem(f.Nome);
                    item.SubItems.Add(f.Email);
                    item.SubItems.Add(f.Cpf);
                    item.SubItems.Add(f.Função);
                    listView1.Items.Add(item);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(Nome.Text != "" && Email.Text != "" && Cpf.Text != "" && Funçao.Text != "")
            {
                Erro.Visible = false;
                Console.AdicionarFuncionario(new Funcionario(Nome.Text, Email.Text, Cpf.Text, Funçao.Text));
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
            foreach(Funcionario f in Console.Funcionarios)
            {
                if(f.Nome.Equals(listView1.SelectedItems[0].Text))
                {
                    f.Ativo = false;
                }
            }
            listView1.Items.Remove(listView1.SelectedItems[0]);
            Listar();
        }
    }
}
