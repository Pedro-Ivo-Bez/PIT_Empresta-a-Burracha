﻿using System;
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
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }
        
        private void Funcionários_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'emprestaBurrachaDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.emprestaBurrachaDataSet.Funcionarios);
            Listar();
        }
        
        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DB.RetornarFuncionarios();
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
        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(Nome.Text != "" && Email.Text != "" && Cpf.Text != "" && Funçao.Text != "")
            {
                Erro.Visible = false;
                DB.InserirFuncionario(new Funcionario(Nome.Text, Email.Text, Cpf.Text, Funçao.Text));
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
            int LinhaSelecionada = FuncionariosDGV.SelectedCells[0].RowIndex;
            string NomeFuncionario = (string)FuncionariosDGV.Rows[LinhaSelecionada].Cells[0].Value;
            DB.DemitirFuncionario(NomeFuncionario);
            Listar();
        }
    }
}
