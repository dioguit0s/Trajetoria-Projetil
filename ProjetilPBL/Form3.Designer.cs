namespace ProjetilPBL
{
    partial class FormGrafico
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
            this.LblTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTeste
            // 
            this.LblTeste.AutoSize = true;
            this.LblTeste.Location = new System.Drawing.Point(225, 212);
            this.LblTeste.Name = "LblTeste";
            this.LblTeste.Size = new System.Drawing.Size(44, 16);
            this.LblTeste.TabIndex = 0;
            this.LblTeste.Text = "label1";
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTeste);
            this.Name = "FormGrafico";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTeste;
    }
}