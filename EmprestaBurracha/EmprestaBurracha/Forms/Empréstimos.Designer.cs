
namespace EmprestaBurracha.Forms
{
    partial class Empréstimos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.EmprestimosDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprestimosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet3 = new EmprestaBurracha.EmprestaBurrachaDataSet3();
            this.emprestimosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emprestaBurrachaDataSet2 = new EmprestaBurracha.EmprestaBurrachaDataSet2();
            this.emprestimosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter();
            this.emprestimosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimosTableAdapter1 = new EmprestaBurracha.EmprestaBurrachaDataSet3TableAdapters.EmprestimosTableAdapter();
            this.EntradaTexto = new System.Windows.Forms.TextBox();
            this.Entrada = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.EntradaTexto);
            this.panel1.Controls.Add(this.Entrada);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.EmprestimosDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(40, 392);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(219, 36);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.Text = "Devolver Empréstimo";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // EmprestimosDGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.EmprestimosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.EmprestimosDGV.AutoGenerateColumns = false;
            this.EmprestimosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.EmprestimosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmprestimosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmprestimosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.EmprestimosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmprestimosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.devolucaoDataGridViewTextBoxColumn});
            this.EmprestimosDGV.DataSource = this.emprestimosBindingSource3;
            this.EmprestimosDGV.GridColor = System.Drawing.Color.Maroon;
            this.EmprestimosDGV.Location = new System.Drawing.Point(0, 42);
            this.EmprestimosDGV.Name = "EmprestimosDGV";
            this.EmprestimosDGV.RowHeadersVisible = false;
            this.EmprestimosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.EmprestimosDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.EmprestimosDGV.RowTemplate.Height = 24;
            this.EmprestimosDGV.Size = new System.Drawing.Size(999, 310);
            this.EmprestimosDGV.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Width = 300;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 275;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // devolucaoDataGridViewTextBoxColumn
            // 
            this.devolucaoDataGridViewTextBoxColumn.DataPropertyName = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn.HeaderText = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devolucaoDataGridViewTextBoxColumn.Name = "devolucaoDataGridViewTextBoxColumn";
            this.devolucaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emprestimosBindingSource3
            // 
            this.emprestimosBindingSource3.DataMember = "Emprestimos";
            this.emprestimosBindingSource3.DataSource = this.emprestaBurrachaDataSet3;
            // 
            // emprestaBurrachaDataSet3
            // 
            this.emprestaBurrachaDataSet3.DataSetName = "EmprestaBurrachaDataSet3";
            this.emprestaBurrachaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimosBindingSource1
            // 
            this.emprestimosBindingSource1.DataMember = "Emprestimos";
            this.emprestimosBindingSource1.DataSource = this.emprestaBurrachaDataSet2;
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
            // emprestimosBindingSource2
            // 
            this.emprestimosBindingSource2.DataMember = "Emprestimos";
            this.emprestimosBindingSource2.DataSource = this.emprestaBurrachaDataSet2;
            // 
            // emprestimosTableAdapter1
            // 
            this.emprestimosTableAdapter1.ClearBeforeFill = true;
            // 
            // EntradaTexto
            // 
            this.EntradaTexto.Location = new System.Drawing.Point(181, 18);
            this.EntradaTexto.Name = "EntradaTexto";
            this.EntradaTexto.Size = new System.Drawing.Size(418, 22);
            this.EntradaTexto.TabIndex = 16;
            this.EntradaTexto.TextChanged += new System.EventHandler(this.EntradaTexto_TextChanged);
            // 
            // Entrada
            // 
            this.Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrada.ForeColor = System.Drawing.Color.White;
            this.Entrada.FormattingEnabled = true;
            this.Entrada.Items.AddRange(new object[] {
            "NomeFuncionario",
            "Material"});
            this.Entrada.Location = new System.Drawing.Point(3, 12);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(171, 24);
            this.Entrada.TabIndex = 15;
            this.Entrada.SelectedIndexChanged += new System.EventHandler(this.Entrada_SelectedIndexChanged);
            // 
            // Empréstimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Empréstimos";
            this.Text = "Empréstimos";
            this.Load += new System.EventHandler(this.Empréstimos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private EmprestaBurrachaDataSet2 emprestaBurrachaDataSet2;
        private System.Windows.Forms.BindingSource emprestimosBindingSource;
        private EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter emprestimosTableAdapter;
        private System.Windows.Forms.DataGridView EmprestimosDGV;
        private System.Windows.Forms.BindingSource emprestimosBindingSource1;
        private System.Windows.Forms.BindingSource emprestimosBindingSource2;
        private EmprestaBurrachaDataSet3 emprestaBurrachaDataSet3;
        private System.Windows.Forms.BindingSource emprestimosBindingSource3;
        private EmprestaBurrachaDataSet3TableAdapters.EmprestimosTableAdapter emprestimosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucaoDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox EntradaTexto;
        private System.Windows.Forms.ComboBox Entrada;
    }
}