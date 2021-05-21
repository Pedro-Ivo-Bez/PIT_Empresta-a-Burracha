
namespace EmprestaBurracha.Forms
{
    partial class Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.MateriaisDVG = new System.Windows.Forms.DataGridView();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet1 = new EmprestaBurracha.EmprestaBurrachaDataSet1();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Erro = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Nome = new System.Windows.Forms.TextBox();
            this.LabelQuant = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.emprestaBurrachaDataSet = new EmprestaBurracha.EmprestaBurrachaDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter();
            this.materiaisTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter();
            this.funcionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.MateriaisDVG);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.Erro);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.LabelQuant);
            this.panel1.Controls.Add(this.LabelNome);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 542);
            this.panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(352, 400);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(117, 36);
            this.iconButton3.TabIndex = 10;
            this.iconButton3.Text = "Remover";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(234, 400);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(110, 36);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Limpar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // MateriaisDVG
            // 
            this.MateriaisDVG.AutoGenerateColumns = false;
            this.MateriaisDVG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.MateriaisDVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MateriaisDVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MateriaisDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MateriaisDVG.ColumnHeadersHeight = 25;
            this.MateriaisDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.MateriaisDVG.DataSource = this.materiaisBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MateriaisDVG.DefaultCellStyle = dataGridViewCellStyle2;
            this.MateriaisDVG.Location = new System.Drawing.Point(-3, 0);
            this.MateriaisDVG.Name = "MateriaisDVG";
            this.MateriaisDVG.RowHeadersVisible = false;
            this.MateriaisDVG.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.MateriaisDVG.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MateriaisDVG.RowTemplate.Height = 24;
            this.MateriaisDVG.Size = new System.Drawing.Size(965, 308);
            this.MateriaisDVG.TabIndex = 8;
            this.MateriaisDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MateriaisDVG_CellContentClick);
            // 
            // materiaisBindingSource
            // 
            this.materiaisBindingSource.DataMember = "Materiais";
            this.materiaisBindingSource.DataSource = this.emprestaBurrachaDataSet1;
            // 
            // emprestaBurrachaDataSet1
            // 
            this.emprestaBurrachaDataSet1.DataSetName = "EmprestaBurrachaDataSet1";
            this.emprestaBurrachaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(336, 337);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 7;
            // 
            // Erro
            // 
            this.Erro.AutoSize = true;
            this.Erro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erro.ForeColor = System.Drawing.Color.Maroon;
            this.Erro.Location = new System.Drawing.Point(576, 338);
            this.Erro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(60, 21);
            this.Erro.TabIndex = 6;
            this.Erro.Text = "label1";
            this.Erro.Visible = false;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(304, 336);
            this.Quantidade.Margin = new System.Windows.Forms.Padding(4);
            this.Quantidade.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(112, 22);
            this.Quantidade.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(16, 337);
            this.Nome.Margin = new System.Windows.Forms.Padding(4);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(248, 22);
            this.Nome.TabIndex = 4;
            // 
            // LabelQuant
            // 
            this.LabelQuant.AutoSize = true;
            this.LabelQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuant.ForeColor = System.Drawing.Color.White;
            this.LabelQuant.Location = new System.Drawing.Point(300, 311);
            this.LabelQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuant.Name = "LabelQuant";
            this.LabelQuant.Size = new System.Drawing.Size(114, 21);
            this.LabelQuant.TabIndex = 3;
            this.LabelQuant.Text = "Quantidade";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.ForeColor = System.Drawing.Color.White;
            this.LabelNome.Location = new System.Drawing.Point(12, 311);
            this.LabelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(60, 21);
            this.LabelNome.TabIndex = 2;
            this.LabelNome.Text = "Nome";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(20, 400);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(206, 36);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Adicionar/Atualizar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // emprestaBurrachaDataSet
            // 
            this.emprestaBurrachaDataSet.DataSetName = "EmprestaBurrachaDataSet";
            this.emprestaBurrachaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.emprestaBurrachaDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // materiaisTableAdapter
            // 
            this.materiaisTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosBindingSource1
            // 
            this.funcionariosBindingSource1.DataMember = "Funcionarios";
            this.funcionariosBindingSource1.DataSource = this.emprestaBurrachaDataSet;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 690;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 250;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 542);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Estoque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Teste_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label LabelQuant;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.NumericUpDown Quantidade;
        private System.Windows.Forms.Label Erro;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private EmprestaBurrachaDataSet emprestaBurrachaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridView MateriaisDVG;
        private EmprestaBurrachaDataSet1 emprestaBurrachaDataSet1;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter materiaisTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}