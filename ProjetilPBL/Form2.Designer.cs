namespace ProjetilPBL
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
            this.LblAngMinimo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGerarGrafico
            // 
            this.BtnGerarGrafico.Location = new System.Drawing.Point(559, 256);
            this.BtnGerarGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGerarGrafico.Name = "BtnGerarGrafico";
            this.BtnGerarGrafico.Size = new System.Drawing.Size(115, 25);
            this.BtnGerarGrafico.TabIndex = 13;
            this.BtnGerarGrafico.Text = "Gerar gráfico";
            this.BtnGerarGrafico.UseVisualStyleBackColor = true;
            this.BtnGerarGrafico.Click += new System.EventHandler(this.BtnGerarGrafico_Click);
            // 
            // TxtAngulo
            // 
            this.TxtAngulo.Location = new System.Drawing.Point(585, 194);
            this.TxtAngulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAngulo.Name = "TxtAngulo";
            this.TxtAngulo.Size = new System.Drawing.Size(100, 22);
            this.TxtAngulo.TabIndex = 12;
            // 
            // LblAnguloDigitado
            // 
            this.LblAnguloDigitado.AutoSize = true;
            this.LblAnguloDigitado.Location = new System.Drawing.Point(455, 197);
            this.LblAnguloDigitado.Name = "LblAnguloDigitado";
            this.LblAnguloDigitado.Size = new System.Drawing.Size(110, 16);
            this.LblAnguloDigitado.TabIndex = 11;
            this.LblAnguloDigitado.Text = "Angulo desejado";
            // 
            // LblAnguloMinim
            // 
            this.LblAnguloMinim.AutoSize = true;
            this.LblAnguloMinim.Location = new System.Drawing.Point(473, 159);
            this.LblAnguloMinim.Name = "LblAnguloMinim";
            this.LblAnguloMinim.Size = new System.Drawing.Size(124, 16);
            this.LblAnguloMinim.TabIndex = 10;
            this.LblAnguloMinim.Text = "O angulo minimo é: ";
            // 
            // LblAngMinimo
            // 
            this.LblAngMinimo.AutoSize = true;
            this.LblAngMinimo.Location = new System.Drawing.Point(613, 159);
            this.LblAngMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAngMinimo.Name = "LblAngMinimo";
            this.LblAngMinimo.Size = new System.Drawing.Size(53, 16);
            this.LblAngMinimo.TabIndex = 14;
            this.LblAngMinimo.Text = "asdsda";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(692, 401);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblAngMinimo);
            this.Controls.Add(this.BtnGerarGrafico);
            this.Controls.Add(this.TxtAngulo);
            this.Controls.Add(this.LblAnguloDigitado);
            this.Controls.Add(this.LblAnguloMinim);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerarGrafico;
        private System.Windows.Forms.TextBox TxtAngulo;
        private System.Windows.Forms.Label LblAnguloDigitado;
        private System.Windows.Forms.Label LblAnguloMinim;
        private System.Windows.Forms.Label LblAngMinimo;
        private System.Windows.Forms.Button BtnSair;
    }
}