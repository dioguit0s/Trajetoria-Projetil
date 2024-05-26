using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetilPBL
{
    public partial class FormGrafico : Form
    {
        const double g = 9.8;
        //trazendo variaveis necessarias para os calculos finais
        static double distancia = Menu1.getDistancia();
        static double altura = Menu1.getAltura();
        static double angulo = Menu2.getAngulo();

        //Transforma o angulo recebido pelo user em Rad
        double thetha = Calculos.TransGrausRad(thethaGraus);


        public FormGrafico()
        {
            InitializeComponent();

            //Reinica o grafico e adiciona as series necessarias
            grafico.Series.Clear();
        }

        private void BtnGrafico_Click(object sender, EventArgs e)
        {
            double v0 = Calculos.VelocidadeMinima(distancia, altura, thetha);
            double tempo = Calculos.CalcTempo(distancia, v0, thetha);
            string direcao = Calculos.AscDesc(tempo, v0);

            MessageBox.Show($"{v0:F2}\n{tempo:F1}\n{direcao}");
            //Adicionando o ponto alvo
            grafico.Series.Add("Alvo");
            grafico.Series["Alvo"].Color = Color.Blue;
            grafico.Series["Alvo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            grafico.Series["Alvo"].Points.AddXY(distancia, altura);

            //Adicionando a trajetoria
            grafico.Series.Add("Trajetória");
            grafico.Series["Trajetória"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafico.Series["Trajetória"].Color = Color.Red;
            //loop que adiciona na o traço
            for(int x = 1; x <= distancia + 50; x++)
            {
                double y = x * Math.Tan(thetha) - (g * Math.Pow(x, 2)) / (2 * Math.Pow(v0  * Math.Cos(thetha), 2));

                grafico.Series["Trajetória"].Points.AddXY(x, y);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu1 menu = new Menu1();
            menu.Show();
            this.Close();
        }
    }
}
