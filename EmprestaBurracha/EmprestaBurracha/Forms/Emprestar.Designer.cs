
namespace EmprestaBurracha.Forms
{
    partial class Emprestar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelDevolução = new System.Windows.Forms.Label();
            this.SelecionadorDatas = new System.Windows.Forms.DateTimePicker();
            this.MateriaisDVG = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet1 = new EmprestaBurracha.EmprestaBurrachaDataSet1();
            this.FuncionariosDGV = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet = new EmprestaBurracha.EmprestaBurrachaDataSet();
            this.LabelQuant = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.funcionariosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter();
            this.materiaisTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter();
            this.emprestaBurrachaDataSet2 = new EmprestaBurracha.EmprestaBurrachaDataSet2();
            this.emprestimosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter();
            this.EntradaTexto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.EntradaTexto);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LabelDevolução);
            this.panel1.Controls.Add(this.SelecionadorDatas);
            this.panel1.Controls.Add(this.MateriaisDVG);
            this.panel1.Controls.Add(this.FuncionariosDGV);
            this.panel1.Controls.Add(this.LabelQuant);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(449, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 447);
            this.panel2.TabIndex = 15;
            // 
            // LabelDevolução
            // 
            this.LabelDevolução.AutoSize = true;
            this.LabelDevolução.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDevolução.ForeColor = System.Drawing.Color.White;
            this.LabelDevolução.Location = new System.Drawing.Point(537, 56);
            this.LabelDevolução.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDevolução.Name = "LabelDevolução";
            this.LabelDevolução.Size = new System.Drawing.Size(103, 21);
            this.LabelDevolução.TabIndex = 14;
            this.LabelDevolução.Text = "Devolução";
            // 
            // SelecionadorDatas
            // 
            this.SelecionadorDatas.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.SelecionadorDatas.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SelecionadorDatas.Location = new System.Drawing.Point(541, 80);
            this.SelecionadorDatas.Name = "SelecionadorDatas";
            this.SelecionadorDatas.Size = new System.Drawing.Size(268, 22);
            this.SelecionadorDatas.TabIndex = 13;
            // 
            // MateriaisDVG
            // 
            this.MateriaisDVG.AutoGenerateColumns = false;
            this.MateriaisDVG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.MateriaisDVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MateriaisDVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MateriaisDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MateriaisDVG.ColumnHeadersHeight = 26;
            this.MateriaisDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn});
            this.MateriaisDVG.DataSource = this.materiaisBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MateriaisDVG.DefaultCellStyle = dataGridViewCellStyle8;
            this.MateriaisDVG.Location = new System.Drawing.Point(12, 247);
            this.MateriaisDVG.Name = "MateriaisDVG";
            this.MateriaisDVG.RowHeadersVisible = false;
            this.MateriaisDVG.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.MateriaisDVG.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.MateriaisDVG.RowTemplate.Height = 24;
            this.MateriaisDVG.Size = new System.Drawing.Size(465, 200);
            this.MateriaisDVG.TabIndex = 12;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 315;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
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
            // FuncionariosDGV
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.FuncionariosDGV.AutoGenerateColumns = false;
            this.FuncionariosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.FuncionariosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FuncionariosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FuncionariosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FuncionariosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.FuncionariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.FuncionariosDGV.DataSource = this.funcionariosBindingSource;
            this.FuncionariosDGV.GridColor = System.Drawing.Color.Maroon;
            this.FuncionariosDGV.Location = new System.Drawing.Point(12, 36);
            this.FuncionariosDGV.Name = "FuncionariosDGV";
            this.FuncionariosDGV.RowHeadersVisible = false;
            this.FuncionariosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.FuncionariosDGV.RowTemplate.Height = 24;
            this.FuncionariosDGV.Size = new System.Drawing.Size(465, 177);
            this.FuncionariosDGV.TabIndex = 11;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 435;
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
            // LabelQuant
            // 
            this.LabelQuant.AutoSize = true;
            this.LabelQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuant.ForeColor = System.Drawing.Color.White;
            this.LabelQuant.Location = new System.Drawing.Point(537, 105);
            this.LabelQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuant.Name = "LabelQuant";
            this.LabelQuant.Size = new System.Drawing.Size(114, 21);
            this.LabelQuant.TabIndex = 7;
            this.LabelQuant.Text = "Quantidade";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(601, 228);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(207, 62);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "   Emprestar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantidade.ForeColor = System.Drawing.Color.White;
            this.Quantidade.Location = new System.Drawing.Point(541, 129);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(120, 18);
            this.Quantidade.TabIndex = 3;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // materiaisTableAdapter
            // 
            this.materiaisTableAdapter.ClearBeforeFill = true;
            // 
            // emprestaBurrachaDataSet2
            // 
            this.emprestaBurrachaDataSet2.DataSetName = "EmprestaBurrachaDataSet2";
            this.emprestaBurrachaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimosBindingSource
            // 
            this.emprestimosBindingSource.DataMember = "Emprestimos";
            this.emprestimosBindingSource.DataSource = this.emprestaBurrachaDataSet2;
            // 
            // emprestimosTableAdapter
            // 
            this.emprestimosTableAdapter.ClearBeforeFill = true;
            // 
            // EntradaTexto
            // 
            this.EntradaTexto.Location = new System.Drawing.Point(12, 6);
            this.EntradaTexto.Name = "EntradaTexto";
            this.EntradaTexto.Size = new System.Drawing.Size(322, 22);
            this.EntradaTexto.TabIndex = 17;
            this.EntradaTexto.TextChanged += new System.EventHandler(this.EntradaTexto_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Emprestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Emprestar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Emprestar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Quantidade;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label LabelQuant;
        private System.Windows.Forms.DataGridView FuncionariosDGV;
        private EmprestaBurrachaDataSet emprestaBurrachaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridView MateriaisDVG;
        private EmprestaBurrachaDataSet1 emprestaBurrachaDataSet1;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter materiaisTableAdapter;
        private System.Windows.Forms.Label LabelDevolução;
        private System.Windows.Forms.DateTimePicker SelecionadorDatas;
        private EmprestaBurrachaDataSet2 emprestaBurrachaDataSet2;
        private System.Windows.Forms.BindingSource emprestimosBindingSource;
        private EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter emprestimosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox EntradaTexto;
    }
}