namespace ProjetilPBL
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.BtnGerarAngulo = new System.Windows.Forms.Button();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtDistancia = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGerarAngulo
            // 
            this.BtnGerarAngulo.Location = new System.Drawing.Point(591, 219);
            this.BtnGerarAngulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGerarAngulo.Name = "BtnGerarAngulo";
            this.BtnGerarAngulo.Size = new System.Drawing.Size(108, 39);
            this.BtnGerarAngulo.TabIndex = 0;
            this.BtnGerarAngulo.Text = "Próximo";
            this.BtnGerarAngulo.UseVisualStyleBackColor = true;
            this.BtnGerarAngulo.Click += new System.EventHandler(this.BtnGerarAngulo_Click);
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Location = new System.Drawing.Point(537, 132);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(77, 16);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia(x)";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(537, 172);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(56, 16);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura(h)";
            this.LblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.Location = new System.Drawing.Point(631, 129);
            this.TxtDistancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(91, 22);
            this.TxtDistancia.TabIndex = 3;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(631, 172);
            this.TxtAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(91, 22);
            this.TxtAltura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Com base no imagem insira:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(694, 402);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.BtnGerarAngulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerarAngulo;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtDistancia;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSair;
    }
}

