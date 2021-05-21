
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emprestaBurrachaDataSet2 = new EmprestaBurracha.EmprestaBurrachaDataSet2();
            this.emprestimosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter();
            this.EmprestimosDGV = new System.Windows.Forms.DataGridView();
            this.emprestimosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.EmprestimosDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 0;
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
            // EmprestimosDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.EmprestimosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmprestimosDGV.AutoGenerateColumns = false;
            this.EmprestimosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.EmprestimosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmprestimosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmprestimosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmprestimosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmprestimosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.devolucaoDataGridViewTextBoxColumn});
            this.EmprestimosDGV.DataSource = this.emprestimosBindingSource1;
            this.EmprestimosDGV.GridColor = System.Drawing.Color.Maroon;
            this.EmprestimosDGV.Location = new System.Drawing.Point(0, 0);
            this.EmprestimosDGV.Name = "EmprestimosDGV";
            this.EmprestimosDGV.RowHeadersVisible = false;
            this.EmprestimosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.EmprestimosDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EmprestimosDGV.RowTemplate.Height = 24;
            this.EmprestimosDGV.Size = new System.Drawing.Size(999, 310);
            this.EmprestimosDGV.TabIndex = 11;
            // 
            // emprestimosBindingSource1
            // 
            this.emprestimosBindingSource1.DataMember = "Emprestimos";
            this.emprestimosBindingSource1.DataSource = this.emprestaBurrachaDataSet2;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Width = 325;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 300;
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
            // Empréstimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Empréstimos";
            this.Text = "Empréstimos";
            this.Load += new System.EventHandler(this.Empréstimos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmprestimosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private EmprestaBurrachaDataSet2 emprestaBurrachaDataSet2;
        private System.Windows.Forms.BindingSource emprestimosBindingSource;
        private EmprestaBurrachaDataSet2TableAdapters.EmprestimosTableAdapter emprestimosTableAdapter;
        private System.Windows.Forms.DataGridView EmprestimosDGV;
        private System.Windows.Forms.BindingSource emprestimosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucaoDataGridViewTextBoxColumn;
    }
}