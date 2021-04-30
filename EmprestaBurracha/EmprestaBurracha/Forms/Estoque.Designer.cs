
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelQuant = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Erro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.Erro);
            this.panel1.Controls.Add(this.Quantidade);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.LabelQuant);
            this.panel1.Controls.Add(this.LabelNome);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 440);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 226);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 724;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
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
            this.iconButton1.Location = new System.Drawing.Point(15, 325);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(109, 29);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Adicionar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.ForeColor = System.Drawing.Color.White;
            this.LabelNome.Location = new System.Drawing.Point(9, 253);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(48, 17);
            this.LabelNome.TabIndex = 2;
            this.LabelNome.Text = "Nome";
            // 
            // LabelQuant
            // 
            this.LabelQuant.AutoSize = true;
            this.LabelQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuant.ForeColor = System.Drawing.Color.White;
            this.LabelQuant.Location = new System.Drawing.Point(225, 253);
            this.LabelQuant.Name = "LabelQuant";
            this.LabelQuant.Size = new System.Drawing.Size(87, 17);
            this.LabelQuant.TabIndex = 3;
            this.LabelQuant.Text = "Quantidade";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 274);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(187, 20);
            this.Nome.TabIndex = 4;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(228, 273);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(84, 20);
            this.Quantidade.TabIndex = 5;
            // 
            // Erro
            // 
            this.Erro.AutoSize = true;
            this.Erro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erro.ForeColor = System.Drawing.Color.Maroon;
            this.Erro.Location = new System.Drawing.Point(225, 331);
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(47, 17);
            this.Erro.TabIndex = 6;
            this.Erro.Text = "label1";
            this.Erro.Visible = false;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 440);
            this.Controls.Add(this.panel1);
            this.Name = "Estoque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Teste_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ColumnHeader ID;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label LabelQuant;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.NumericUpDown Quantidade;
        private System.Windows.Forms.Label Erro;
    }
}