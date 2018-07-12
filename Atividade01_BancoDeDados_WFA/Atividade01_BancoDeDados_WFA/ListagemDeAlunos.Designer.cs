namespace Atividade01_BancoDeDados_WFA
{
    partial class ListagemDeAlunos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1MATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NOTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NOTA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1NOTA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(575, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "BUSCAR:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(578, 440);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(578, 334);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 73);
            this.button5.TabIndex = 13;
            this.button5.Text = "SITUAÇÃO";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(578, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 73);
            this.button4.TabIndex = 12;
            this.button4.Text = "ATUALIZAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(578, 172);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 73);
            this.button3.TabIndex = 11;
            this.button3.Text = "APAGAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(578, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 73);
            this.button2.TabIndex = 10;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(578, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1ID,
            this.Column1NOME,
            this.Column1MATRICULA,
            this.Column1NOTA1,
            this.Column1NOTA2,
            this.Column1NOTA3});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 450);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "MÉDIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(96, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "-";
            // 
            // Column1ID
            // 
            this.Column1ID.HeaderText = "ID";
            this.Column1ID.Name = "Column1ID";
            this.Column1ID.ReadOnly = true;
            this.Column1ID.Visible = false;
            // 
            // Column1NOME
            // 
            this.Column1NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1NOME.HeaderText = "NOME";
            this.Column1NOME.Name = "Column1NOME";
            this.Column1NOME.ReadOnly = true;
            // 
            // Column1MATRICULA
            // 
            this.Column1MATRICULA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1MATRICULA.HeaderText = "NÚMERO DE MATRÍCULA";
            this.Column1MATRICULA.Name = "Column1MATRICULA";
            this.Column1MATRICULA.ReadOnly = true;
            // 
            // Column1NOTA1
            // 
            this.Column1NOTA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1NOTA1.HeaderText = "NOTA 1";
            this.Column1NOTA1.Name = "Column1NOTA1";
            this.Column1NOTA1.ReadOnly = true;
            // 
            // Column1NOTA2
            // 
            this.Column1NOTA2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1NOTA2.HeaderText = "NOTA 2";
            this.Column1NOTA2.Name = "Column1NOTA2";
            this.Column1NOTA2.ReadOnly = true;
            // 
            // Column1NOTA3
            // 
            this.Column1NOTA3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1NOTA3.HeaderText = "NOTA 3";
            this.Column1NOTA3.Name = "Column1NOTA3";
            this.Column1NOTA3.ReadOnly = true;
            // 
            // ListagemDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListagemDeAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem De Alunos";
            this.Load += new System.EventHandler(this.ListagemDeAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1MATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NOTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NOTA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1NOTA3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}