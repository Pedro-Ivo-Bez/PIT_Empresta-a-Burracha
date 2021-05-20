
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelQuant = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Itens = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Funcionarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelErro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.LabelErro);
            this.panel1.Controls.Add(this.LabelQuant);
            this.panel1.Controls.Add(this.Calendario);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Controls.Add(this.Itens);
            this.panel1.Controls.Add(this.Funcionarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 450);
            this.panel1.TabIndex = 0;
            // 
            // LabelQuant
            // 
            this.LabelQuant.AutoSize = true;
            this.LabelQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuant.ForeColor = System.Drawing.Color.White;
            this.LabelQuant.Location = new System.Drawing.Point(736, 83);
            this.LabelQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuant.Name = "LabelQuant";
            this.LabelQuant.Size = new System.Drawing.Size(114, 21);
            this.LabelQuant.TabIndex = 7;
            this.LabelQuant.Text = "Quantidade";
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Calendario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.Location = new System.Drawing.Point(27, 234);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 6;
            this.Calendario.TitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Calendario.TrailingForeColor = System.Drawing.SystemColors.Desktop;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(522, 316);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(145, 36);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Emprestar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(740, 107);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(120, 22);
            this.Quantidade.TabIndex = 3;
            // 
            // Itens
            // 
            this.Itens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Itens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.Itens.ForeColor = System.Drawing.Color.White;
            this.Itens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Itens.HideSelection = false;
            this.Itens.Location = new System.Drawing.Point(246, 22);
            this.Itens.Margin = new System.Windows.Forms.Padding(4);
            this.Itens.Name = "Itens";
            this.Itens.Size = new System.Drawing.Size(415, 208);
            this.Itens.TabIndex = 2;
            this.Itens.UseCompatibleStateImageBehavior = false;
            this.Itens.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 174;
            // 
            // Funcionarios
            // 
            this.Funcionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.Funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Funcionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Funcionarios.ForeColor = System.Drawing.Color.White;
            this.Funcionarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Funcionarios.HideSelection = false;
            this.Funcionarios.Location = new System.Drawing.Point(27, 22);
            this.Funcionarios.Margin = new System.Windows.Forms.Padding(4);
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Size = new System.Drawing.Size(201, 208);
            this.Funcionarios.TabIndex = 1;
            this.Funcionarios.UseCompatibleStateImageBehavior = false;
            this.Funcionarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 200;
            // 
            // LabelErro
            // 
            this.LabelErro.AutoSize = true;
            this.LabelErro.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LabelErro.ForeColor = System.Drawing.Color.Maroon;
            this.LabelErro.Location = new System.Drawing.Point(559, 381);
            this.LabelErro.Name = "LabelErro";
            this.LabelErro.Size = new System.Drawing.Size(53, 20);
            this.LabelErro.TabIndex = 8;
            this.LabelErro.Text = "label1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView Funcionarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView Itens;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown Quantidade;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label LabelQuant;
        private System.Windows.Forms.Label LabelErro;
    }
}