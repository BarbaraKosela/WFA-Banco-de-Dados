namespace Atividade01_BancoDeDados_WFA
{
    partial class CadastroDeAlunos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroDaMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(199, 268);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 53);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(154, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "NÚMERO DA MATRÍCULA";
            // 
            // txtNumeroDaMatricula
            // 
            this.txtNumeroDaMatricula.Location = new System.Drawing.Point(200, 90);
            this.txtNumeroDaMatricula.Name = "txtNumeroDaMatricula";
            this.txtNumeroDaMatricula.Size = new System.Drawing.Size(153, 23);
            this.txtNumeroDaMatricula.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRIMEIRA NOTA:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(144, 132);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(153, 23);
            this.txtNota1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "SEGUNDA NOTA:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(144, 163);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(153, 23);
            this.txtNota2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "TERCEIRA NOTA:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(144, 196);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(153, 23);
            this.txtNota3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "FREQUENCIA:";
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Location = new System.Drawing.Point(121, 225);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(153, 23);
            this.txtFrequencia.TabIndex = 13;
            // 
            // CadastroDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFrequencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroDaMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCadastrar);
            this.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastroDeAlunos";
            this.Text = "Cadastro de alunos!";
            this.Load += new System.EventHandler(this.CadastroDeAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroDaMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrequencia;
    }
}

