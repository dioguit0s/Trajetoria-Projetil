﻿namespace ProjetilPBL
{
    partial class Menu2
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
            this.BtnGerarGrafico = new System.Windows.Forms.Button();
            this.TxtAngulo = new System.Windows.Forms.TextBox();
            this.LblAnguloDigitado = new System.Windows.Forms.Label();
            this.LblAnguloMinim = new System.Windows.Forms.Label();
            this.BtnGerarAngulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGerarGrafico
            // 
            this.BtnGerarGrafico.Location = new System.Drawing.Point(385, 278);
            this.BtnGerarGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGerarGrafico.Name = "BtnGerarGrafico";
            this.BtnGerarGrafico.Size = new System.Drawing.Size(86, 20);
            this.BtnGerarGrafico.TabIndex = 13;
            this.BtnGerarGrafico.Text = "Gerar gráfico";
            this.BtnGerarGrafico.UseVisualStyleBackColor = true;
            this.BtnGerarGrafico.Click += new System.EventHandler(this.BtnGerarGrafico_Click);
            // 
            // TxtAngulo
            // 
            this.TxtAngulo.Location = new System.Drawing.Point(405, 228);
            this.TxtAngulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAngulo.Name = "TxtAngulo";
            this.TxtAngulo.Size = new System.Drawing.Size(76, 20);
            this.TxtAngulo.TabIndex = 12;
            // 
            // LblAnguloDigitado
            // 
            this.LblAnguloDigitado.AutoSize = true;
            this.LblAnguloDigitado.Location = new System.Drawing.Point(307, 230);
            this.LblAnguloDigitado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnguloDigitado.Name = "LblAnguloDigitado";
            this.LblAnguloDigitado.Size = new System.Drawing.Size(86, 13);
            this.LblAnguloDigitado.TabIndex = 11;
            this.LblAnguloDigitado.Text = "Angulo desejado";
            // 
            // LblAnguloMinim
            // 
            this.LblAnguloMinim.AutoSize = true;
            this.LblAnguloMinim.Location = new System.Drawing.Point(321, 199);
            this.LblAnguloMinim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnguloMinim.Name = "LblAnguloMinim";
            this.LblAnguloMinim.Size = new System.Drawing.Size(100, 13);
            this.LblAnguloMinim.TabIndex = 10;
            this.LblAnguloMinim.Text = "O angulo minimo é: ";
            // 
            // BtnGerarAngulo
            // 
            this.BtnGerarAngulo.Location = new System.Drawing.Point(405, 153);
            this.BtnGerarAngulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGerarAngulo.Name = "BtnGerarAngulo";
            this.BtnGerarAngulo.Size = new System.Drawing.Size(88, 19);
            this.BtnGerarAngulo.TabIndex = 9;
            this.BtnGerarAngulo.Text = "Gerar Angulo";
            this.BtnGerarAngulo.UseVisualStyleBackColor = true;
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnGerarGrafico);
            this.Controls.Add(this.TxtAngulo);
            this.Controls.Add(this.LblAnguloDigitado);
            this.Controls.Add(this.LblAnguloMinim);
            this.Controls.Add(this.BtnGerarAngulo);
            this.Name = "Menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerarGrafico;
        private System.Windows.Forms.TextBox TxtAngulo;
        private System.Windows.Forms.Label LblAnguloDigitado;
        private System.Windows.Forms.Label LblAnguloMinim;
        private System.Windows.Forms.Button BtnGerarAngulo;
    }
}