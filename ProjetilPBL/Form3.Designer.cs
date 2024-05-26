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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnGrafico = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblInfos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(624, 21);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(666, 391);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // BtnGrafico
            // 
            this.BtnGrafico.Location = new System.Drawing.Point(509, 453);
            this.BtnGrafico.Name = "BtnGrafico";
            this.BtnGrafico.Size = new System.Drawing.Size(200, 37);
            this.BtnGrafico.TabIndex = 1;
            this.BtnGrafico.Text = "Gerar Grafico e informações";
            this.BtnGrafico.UseVisualStyleBackColor = true;
            this.BtnGrafico.Click += new System.EventHandler(this.BtnGrafico_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(46, 439);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(114, 51);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.Text = "Voltar para\r\no menu\r\n";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblInfos
            // 
            this.LblInfos.AutoSize = true;
            this.LblInfos.Location = new System.Drawing.Point(81, 50);
            this.LblInfos.Name = "LblInfos";
            this.LblInfos.Size = new System.Drawing.Size(0, 16);
            this.LblInfos.TabIndex = 3;
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 519);
            this.Controls.Add(this.LblInfos);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnGrafico);
            this.Controls.Add(this.grafico);
            this.Name = "FormGrafico";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button BtnGrafico;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblInfos;
    }
}