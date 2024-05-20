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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGerarAngulo
            // 
            this.BtnGerarAngulo.Location = new System.Drawing.Point(443, 178);
            this.BtnGerarAngulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGerarAngulo.Name = "BtnGerarAngulo";
            this.BtnGerarAngulo.Size = new System.Drawing.Size(81, 32);
            this.BtnGerarAngulo.TabIndex = 0;
            this.BtnGerarAngulo.Text = "Próximo";
            this.BtnGerarAngulo.UseVisualStyleBackColor = true;
            this.BtnGerarAngulo.Click += new System.EventHandler(this.BtnGerarAngulo_Click);
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Location = new System.Drawing.Point(403, 107);
            this.LblDistancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(62, 13);
            this.LblDistancia.TabIndex = 1;
            this.LblDistancia.Text = "Distancia(x)";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(403, 140);
            this.LblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(46, 13);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura(h)";
            this.LblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.Location = new System.Drawing.Point(473, 105);
            this.TxtDistancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(69, 20);
            this.TxtDistancia.TabIndex = 3;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(473, 140);
            this.TxtAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(69, 20);
            this.TxtAltura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Com base no imagem insira:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblDistancia);
            this.Controls.Add(this.BtnGerarAngulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

