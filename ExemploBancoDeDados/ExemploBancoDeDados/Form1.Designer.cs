﻿namespace ExemploBancoDeDados
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
            this.txtCor = new System.Windows.Forms.TextBox();
            this.rtbAtualizar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCorApagar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(93, 28);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(308, 27);
            this.txtCor.TabIndex = 0;
            // 
            // rtbAtualizar
            // 
            this.rtbAtualizar.Location = new System.Drawing.Point(23, 130);
            this.rtbAtualizar.Name = "rtbAtualizar";
            this.rtbAtualizar.ReadOnly = true;
            this.rtbAtualizar.Size = new System.Drawing.Size(378, 173);
            this.rtbAtualizar.TabIndex = 1;
            this.rtbAtualizar.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "ATUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "COR:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "APAGAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CORES:";
            // 
            // cbCorApagar
            // 
            this.cbCorApagar.FormattingEnabled = true;
            this.cbCorApagar.Location = new System.Drawing.Point(469, 28);
            this.cbCorApagar.Name = "cbCorApagar";
            this.cbCorApagar.Size = new System.Drawing.Size(283, 28);
            this.cbCorApagar.TabIndex = 9;
            this.cbCorApagar.DropDown += new System.EventHandler(this.cbCorApagar_DropDown);
            this.cbCorApagar.SelectedIndexChanged += new System.EventHandler(this.cbCorApagar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "NOVO NOME:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(603, 241);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 44);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(415, 208);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(337, 27);
            this.txtNovoNome.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.cbCorApagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbAtualizar);
            this.Controls.Add(this.txtCor);
            this.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.RichTextBox rtbAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCorApagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNovoNome;
    }
}

