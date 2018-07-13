namespace ExemploBancoDeDados02
{
    partial class EstatisticasHerois
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
            this.lblTotalContasBancarias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DA CONTA BANCÁRIA:";
            // 
            // lblTotalContasBancarias
            // 
            this.lblTotalContasBancarias.AutoSize = true;
            this.lblTotalContasBancarias.BackColor = System.Drawing.Color.DarkRed;
            this.lblTotalContasBancarias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalContasBancarias.Location = new System.Drawing.Point(278, 9);
            this.lblTotalContasBancarias.Name = "lblTotalContasBancarias";
            this.lblTotalContasBancarias.Size = new System.Drawing.Size(20, 20);
            this.lblTotalContasBancarias.TabIndex = 1;
            this.lblTotalContasBancarias.Text = "0";
            this.lblTotalContasBancarias.Click += new System.EventHandler(this.lblTotalContasBancarias_Click);
            // 
            // EstatisticasHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 42);
            this.Controls.Add(this.lblTotalContasBancarias);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EstatisticasHerois";
            this.Text = "Estatisticas dos heróis";
            this.Load += new System.EventHandler(this.EstatisticasHerois_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalContasBancarias;
    }
}