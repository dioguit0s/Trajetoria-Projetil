namespace ProjetilPBL
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
            this.BtnGerarAngulo = new System.Windows.Forms.Button();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtDistancia = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.LblAnguloMinim = new System.Windows.Forms.Label();
            this.LblAnguloDigitado = new System.Windows.Forms.Label();
            this.TxtAngulo = new System.Windows.Forms.TextBox();
            this.BtnGerarGrafico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGerarAngulo
            // 
            this.BtnGerarAngulo.Location = new System.Drawing.Point(603, 176);
            this.BtnGerarAngulo.Name = "BtnGerarAngulo";
            this.BtnGerarAngulo.Size = new System.Drawing.Size(118, 23);
            this.BtnGerarAngulo.TabIndex = 0;
            this.BtnGerarAngulo.Text = "Gerar Angulo";
            this.BtnGerarAngulo.UseVisualStyleBackColor = true;
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Location = new System.Drawing.Point(559, 89);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(77, 16);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia(x)";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(559, 129);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(56, 16);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura(h)";
            this.LblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.Location = new System.Drawing.Point(642, 86);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(100, 22);
            this.TxtDistancia.TabIndex = 3;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(642, 129);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 22);
            this.TxtAltura.TabIndex = 4;
            // 
            // LblAnguloMinim
            // 
            this.LblAnguloMinim.AutoSize = true;
            this.LblAnguloMinim.Location = new System.Drawing.Point(491, 233);
            this.LblAnguloMinim.Name = "LblAnguloMinim";
            this.LblAnguloMinim.Size = new System.Drawing.Size(124, 16);
            this.LblAnguloMinim.TabIndex = 5;
            this.LblAnguloMinim.Text = "O angulo minimo é: ";
            // 
            // LblAnguloDigitado
            // 
            this.LblAnguloDigitado.AutoSize = true;
            this.LblAnguloDigitado.Location = new System.Drawing.Point(472, 271);
            this.LblAnguloDigitado.Name = "LblAnguloDigitado";
            this.LblAnguloDigitado.Size = new System.Drawing.Size(110, 16);
            this.LblAnguloDigitado.TabIndex = 6;
            this.LblAnguloDigitado.Text = "Angulo desejado";
            // 
            // TxtAngulo
            // 
            this.TxtAngulo.Location = new System.Drawing.Point(603, 268);
            this.TxtAngulo.Name = "TxtAngulo";
            this.TxtAngulo.Size = new System.Drawing.Size(100, 22);
            this.TxtAngulo.TabIndex = 7;
            // 
            // BtnGerarGrafico
            // 
            this.BtnGerarGrafico.Location = new System.Drawing.Point(576, 330);
            this.BtnGerarGrafico.Name = "BtnGerarGrafico";
            this.BtnGerarGrafico.Size = new System.Drawing.Size(115, 24);
            this.BtnGerarGrafico.TabIndex = 8;
            this.BtnGerarGrafico.Text = "Gerar gráfico";
            this.BtnGerarGrafico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Com base no imagem insira:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGerarGrafico);
            this.Controls.Add(this.TxtAngulo);
            this.Controls.Add(this.LblAnguloDigitado);
            this.Controls.Add(this.LblAnguloMinim);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.BtnGerarAngulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerarAngulo;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtDistancia;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label LblAnguloMinim;
        private System.Windows.Forms.Label LblAnguloDigitado;
        private System.Windows.Forms.TextBox TxtAngulo;
        private System.Windows.Forms.Button BtnGerarGrafico;
        private System.Windows.Forms.Label label1;
    }
}

