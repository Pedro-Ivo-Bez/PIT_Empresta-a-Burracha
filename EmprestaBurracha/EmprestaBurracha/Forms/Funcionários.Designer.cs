
namespace EmprestaBurracha.Forms
{
    partial class Funcionários
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.FuncionariosDGV = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet = new EmprestaBurracha.EmprestaBurrachaDataSet();
            this.Erro = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.Funçao = new System.Windows.Forms.TextBox();
            this.Cpf = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.funcionariosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter();
            this.Entrada = new System.Windows.Forms.ComboBox();
            this.EntradaTexto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.EntradaTexto);
            this.panel1.Controls.Add(this.Entrada);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.FuncionariosDGV);
            this.panel1.Controls.Add(this.Erro);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.Funçao);
            this.panel1.Controls.Add(this.Cpf);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(219, 399);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(110, 36);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.Text = "Limpar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FuncionariosDGV
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.FuncionariosDGV.AutoGenerateColumns = false;
            this.FuncionariosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.FuncionariosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FuncionariosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FuncionariosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.FuncionariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn});
            this.FuncionariosDGV.DataSource = this.funcionariosBindingSource;
            this.FuncionariosDGV.GridColor = System.Drawing.Color.Maroon;
            this.FuncionariosDGV.Location = new System.Drawing.Point(0, 47);
            this.FuncionariosDGV.Name = "FuncionariosDGV";
            this.FuncionariosDGV.RowHeadersVisible = false;
            this.FuncionariosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.FuncionariosDGV.RowTemplate.Height = 24;
            this.FuncionariosDGV.Size = new System.Drawing.Size(1070, 255);
            this.FuncionariosDGV.TabIndex = 10;
            this.FuncionariosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncionariosDGV_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Função";
            this.funcaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            this.funcaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.emprestaBurrachaDataSet;
            // 
            // emprestaBurrachaDataSet
            // 
            this.emprestaBurrachaDataSet.DataSetName = "EmprestaBurrachaDataSet";
            this.emprestaBurrachaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Erro
            // 
            this.Erro.AutoSize = true;
            this.Erro.ForeColor = System.Drawing.Color.DarkRed;
            this.Erro.Location = new System.Drawing.Point(337, 407);
            this.Erro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(60, 21);
            this.Erro.TabIndex = 11;
            this.Erro.Text = "label5";
            this.Erro.Visible = false;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Fire;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.Location = new System.Drawing.Point(749, 396);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(161, 43);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "Demitir";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Funçao
            // 
            this.Funçao.BackColor = System.Drawing.Color.White;
            this.Funçao.ForeColor = System.Drawing.Color.Black;
            this.Funçao.Location = new System.Drawing.Point(633, 337);
            this.Funçao.Margin = new System.Windows.Forms.Padding(4);
            this.Funçao.Name = "Funçao";
            this.Funçao.Size = new System.Drawing.Size(132, 27);
            this.Funçao.TabIndex = 9;
            // 
            // Cpf
            // 
            this.Cpf.Location = new System.Drawing.Point(467, 337);
            this.Cpf.Margin = new System.Windows.Forms.Padding(4);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(157, 27);
            this.Cpf.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(244, 337);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(213, 27);
            this.Email.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(16, 337);
            this.Nome.Margin = new System.Windows.Forms.Padding(4);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(219, 27);
            this.Nome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(629, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(16, 396);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(208, 43);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Adicionar/Atualizar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // Entrada
            // 
            this.Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrada.ForeColor = System.Drawing.Color.White;
            this.Entrada.FormattingEnabled = true;
            this.Entrada.Items.AddRange(new object[] {
            "Nome",
            "Email",
            "Cpf",
            "Funcao"});
            this.Entrada.Location = new System.Drawing.Point(3, 12);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(171, 29);
            this.Entrada.TabIndex = 13;
            this.Entrada.SelectedIndexChanged += new System.EventHandler(this.Entrada_SelectedIndexChanged);
            // 
            // EntradaTexto
            // 
            this.EntradaTexto.Location = new System.Drawing.Point(181, 18);
            this.EntradaTexto.Name = "EntradaTexto";
            this.EntradaTexto.Size = new System.Drawing.Size(418, 27);
            this.EntradaTexto.TabIndex = 14;
            this.EntradaTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Funcionários";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Funcionários_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox Funçao;
        private System.Windows.Forms.TextBox Cpf;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label Erro;
        private System.Windows.Forms.DataGridView FuncionariosDGV;
        private EmprestaBurrachaDataSet emprestaBurrachaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox EntradaTexto;
        private System.Windows.Forms.ComboBox Entrada;
    }
}