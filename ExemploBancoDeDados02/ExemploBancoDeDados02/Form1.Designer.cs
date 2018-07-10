namespace ExemploBancoDeDados02
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNOMEPESSOA = new System.Windows.Forms.TextBox();
            this.CBRACA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CHBMULHER = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTQUANTIDADEFILMES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContaBancaria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDescicao = new System.Windows.Forms.RichTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(277, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNome.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(86, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(99, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESCURIDÃO";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.DarkRed;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(130, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NÃO";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.DarkRed;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(35, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SIM";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOME PESSOA:";
            // 
            // TXTNOMEPESSOA
            // 
            this.TXTNOMEPESSOA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXTNOMEPESSOA.ForeColor = System.Drawing.SystemColors.Window;
            this.TXTNOMEPESSOA.Location = new System.Drawing.Point(161, 148);
            this.TXTNOMEPESSOA.Name = "TXTNOMEPESSOA";
            this.TXTNOMEPESSOA.Size = new System.Drawing.Size(203, 27);
            this.TXTNOMEPESSOA.TabIndex = 4;
            // 
            // CBRACA
            // 
            this.CBRACA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CBRACA.ForeColor = System.Drawing.SystemColors.Window;
            this.CBRACA.FormattingEnabled = true;
            this.CBRACA.Items.AddRange(new object[] {
            "Humano",
            "Orc",
            "Fada",
            "Nórdico",
            "Avatar",
            "Alien",
            "Sayajin"});
            this.CBRACA.Location = new System.Drawing.Point(79, 199);
            this.CBRACA.Name = "CBRACA";
            this.CBRACA.Size = new System.Drawing.Size(203, 28);
            this.CBRACA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "RAÇA:";
            // 
            // CHBMULHER
            // 
            this.CHBMULHER.AutoSize = true;
            this.CHBMULHER.BackColor = System.Drawing.Color.DarkRed;
            this.CHBMULHER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHBMULHER.Location = new System.Drawing.Point(326, 202);
            this.CHBMULHER.Name = "CHBMULHER";
            this.CHBMULHER.Size = new System.Drawing.Size(101, 24);
            this.CHBMULHER.TabIndex = 8;
            this.CHBMULHER.Text = "MULHER";
            this.CHBMULHER.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "QUANTIDADE DE FILMES:";
            // 
            // TXTQUANTIDADEFILMES
            // 
            this.TXTQUANTIDADEFILMES.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXTQUANTIDADEFILMES.ForeColor = System.Drawing.SystemColors.Window;
            this.TXTQUANTIDADEFILMES.Location = new System.Drawing.Point(245, 244);
            this.TXTQUANTIDADEFILMES.Name = "TXTQUANTIDADEFILMES";
            this.TXTQUANTIDADEFILMES.Size = new System.Drawing.Size(197, 27);
            this.TXTQUANTIDADEFILMES.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "CONTA BANCÁRIA:";
            // 
            // txtContaBancaria
            // 
            this.txtContaBancaria.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContaBancaria.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContaBancaria.Location = new System.Drawing.Point(188, 277);
            this.txtContaBancaria.Name = "txtContaBancaria";
            this.txtContaBancaria.Size = new System.Drawing.Size(197, 27);
            this.txtContaBancaria.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATA DE NASCIMENTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "DESCRIÇÃO:";
            // 
            // rtbDescicao
            // 
            this.rtbDescicao.BackColor = System.Drawing.SystemColors.GrayText;
            this.rtbDescicao.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbDescicao.Location = new System.Drawing.Point(16, 372);
            this.rtbDescicao.Name = "rtbDescicao";
            this.rtbDescicao.Size = new System.Drawing.Size(411, 81);
            this.rtbDescicao.TabIndex = 16;
            this.rtbDescicao.Text = "";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpDataNascimento.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.dtpDataNascimento.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(229, 308);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(122, 27);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 515);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.rtbDescicao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContaBancaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTQUANTIDADEFILMES);
            this.Controls.Add(this.CHBMULHER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBRACA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNOMEPESSOA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Registre seu herói";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNOMEPESSOA;
        private System.Windows.Forms.ComboBox CBRACA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHBMULHER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTQUANTIDADEFILMES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContaBancaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDescicao;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}

