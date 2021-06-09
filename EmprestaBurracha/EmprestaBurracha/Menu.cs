using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EmprestaBurracha
{
    public partial class Menu : Form
    {
        private IconButton Atual;
        private Panel Esquerda;
        private Form Pagina;
        public Menu()
        {
            InitializeComponent();
            Esquerda = new Panel();
            Esquerda.Size = new Size(7, 60);
            PainelPrincipal.Controls.Add(Esquerda);
        }

        private struct Cores
        {
            public static Color cor = Color.FromArgb(172, 126, 241);
            public static Color cor1 = Color.FromArgb(249, 118, 176);
            public static Color cor2 = Color.FromArgb(253, 138, 114);
            public static Color cor3 = Color.FromArgb(95, 77, 221);
        }
        private void Ativar(object sender, Color cor) 
        {
                Desligar();

                Atual = (IconButton)sender;
                Atual.BackColor = Color.FromArgb(31, 30, 68);
                Atual.ForeColor = cor;
                Atual.TextAlign = ContentAlignment.MiddleCenter;
                Atual.IconColor = cor;
                Atual.TextImageRelation = TextImageRelation.TextBeforeImage;
                Atual.ImageAlign = ContentAlignment.MiddleRight;

                Esquerda.BackColor = cor;
                Esquerda.Location = new Point(0, Atual.Location.Y);
                Esquerda.Visible = true;
                Esquerda.BringToFront();

                Inicio.IconChar = Atual.IconChar;
                Inicio.Text = Atual.Text;
                Inicio.IconColor = cor;
        }

        private void Paginas(Form pagina)
        {
            if(Pagina != null)
            {
                Pagina.Close();
            }
            Pagina = pagina;
            pagina.TopLevel = false;
            pagina.FormBorderStyle = FormBorderStyle.None;
            pagina.Dock = DockStyle.Fill;
            PaginaPainel.Controls.Add(pagina);
            PaginaPainel.Tag = pagina;
            pagina.BringToFront();
            pagina.Show();
        }
        public void Desligar()
        {
            if(Atual != null)
            {
                Atual.BackColor = Color.FromArgb(31, 30, 68);
                Atual.ForeColor = Color.Gainsboro;
                Atual.TextAlign = ContentAlignment.MiddleLeft;
                Atual.IconColor = Color.Gainsboro;
                Atual.TextImageRelation = TextImageRelation.ImageBeforeText;
                Atual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Ativar(sender, Cores.cor);
            Paginas(new Forms.Estoque());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Ativar(sender, Cores.cor1);
            Paginas(new Forms.Empréstimos());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Ativar(sender, Cores.cor2);
            Paginas(new Forms.Funcionários());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Ativar(sender, Cores.cor3);
            Paginas(new Forms.Emprestar());
        }
    }
}
