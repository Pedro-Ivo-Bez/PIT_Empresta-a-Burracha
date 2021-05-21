
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelErro = new System.Windows.Forms.Label();
            this.LabelQuant = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.FuncionariosDGV = new System.Windows.Forms.DataGridView();
            this.emprestaBurrachaDataSet = new EmprestaBurracha.EmprestaBurrachaDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter();
            this.MateriaisDVG = new System.Windows.Forms.DataGridView();
            this.emprestaBurrachaDataSet1 = new EmprestaBurracha.EmprestaBurrachaDataSet1();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaisTableAdapter = new EmprestaBurracha.EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelecionadorDatas = new System.Windows.Forms.DateTimePicker();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelecionadorDatas);
            this.panel1.Controls.Add(this.MateriaisDVG);
            this.panel1.Controls.Add(this.FuncionariosDGV);
            this.panel1.Controls.Add(this.LabelErro);
            this.panel1.Controls.Add(this.LabelQuant);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 450);
            this.panel1.TabIndex = 0;
            // 
            // LabelErro
            // 
            this.LabelErro.AutoSize = true;
            this.LabelErro.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LabelErro.ForeColor = System.Drawing.Color.Maroon;
            this.LabelErro.Location = new System.Drawing.Point(484, 331);
            this.LabelErro.Name = "LabelErro";
            this.LabelErro.Size = new System.Drawing.Size(53, 20);
            this.LabelErro.TabIndex = 8;
            this.LabelErro.Text = "label1";
            this.LabelErro.Visible = false;
            // 
            // LabelQuant
            // 
            this.LabelQuant.AutoSize = true;
            this.LabelQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuant.ForeColor = System.Drawing.Color.White;
            this.LabelQuant.Location = new System.Drawing.Point(472, 97);
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
            this.Quantidade.Location = new System.Drawing.Point(476, 121);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(120, 18);
            this.Quantidade.TabIndex = 3;
            // 
            // FuncionariosDGV
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.FuncionariosDGV.AutoGenerateColumns = false;
            this.FuncionariosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.FuncionariosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FuncionariosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FuncionariosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FuncionariosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.FuncionariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.FuncionariosDGV.DataSource = this.funcionariosBindingSource;
            this.FuncionariosDGV.GridColor = System.Drawing.Color.Maroon;
            this.FuncionariosDGV.Location = new System.Drawing.Point(43, 22);
            this.FuncionariosDGV.Name = "FuncionariosDGV";
            this.FuncionariosDGV.RowHeadersVisible = false;
            this.FuncionariosDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.FuncionariosDGV.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.FuncionariosDGV.RowTemplate.Height = 24;
            this.FuncionariosDGV.Size = new System.Drawing.Size(375, 200);
            this.FuncionariosDGV.TabIndex = 11;
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
            // MateriaisDVG
            // 
            this.MateriaisDVG.AutoGenerateColumns = false;
            this.MateriaisDVG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.MateriaisDVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MateriaisDVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MateriaisDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.MateriaisDVG.ColumnHeadersHeight = 26;
            this.MateriaisDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn});
            this.MateriaisDVG.DataSource = this.materiaisBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MateriaisDVG.DefaultCellStyle = dataGridViewCellStyle20;
            this.MateriaisDVG.Location = new System.Drawing.Point(43, 228);
            this.MateriaisDVG.Name = "MateriaisDVG";
            this.MateriaisDVG.RowHeadersVisible = false;
            this.MateriaisDVG.RowHeadersWidth = 51;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.MateriaisDVG.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.MateriaisDVG.RowTemplate.Height = 24;
            this.MateriaisDVG.Size = new System.Drawing.Size(375, 200);
            this.MateriaisDVG.TabIndex = 12;
            // 
            // emprestaBurrachaDataSet1
            // 
            this.emprestaBurrachaDataSet1.DataSetName = "EmprestaBurrachaDataSet1";
            this.emprestaBurrachaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaisBindingSource
            // 
            this.materiaisBindingSource.DataMember = "Materiais";
            this.materiaisBindingSource.DataSource = this.emprestaBurrachaDataSet1;
            // 
            // materiaisTableAdapter
            // 
            this.materiaisTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 250;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // SelecionadorDatas
            // 
            this.SelecionadorDatas.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.SelecionadorDatas.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SelecionadorDatas.Location = new System.Drawing.Point(476, 55);
            this.SelecionadorDatas.Name = "SelecionadorDatas";
            this.SelecionadorDatas.Size = new System.Drawing.Size(268, 22);
            this.SelecionadorDatas.TabIndex = 13;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 375;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Devolução";
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
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaisDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestaBurrachaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Quantidade;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label LabelQuant;
        private System.Windows.Forms.Label LabelErro;
        private System.Windows.Forms.DataGridView FuncionariosDGV;
        private EmprestaBurrachaDataSet emprestaBurrachaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private EmprestaBurrachaDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridView MateriaisDVG;
        private EmprestaBurrachaDataSet1 emprestaBurrachaDataSet1;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private EmprestaBurrachaDataSet1TableAdapters.MateriaisTableAdapter materiaisTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SelecionadorDatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}