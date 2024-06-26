﻿using System;
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
        double thetha = Calculos.TransGrausRad(angulo);


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
            double direcao = Calculos.AscDesc(tempo, v0);
            string dir;
            if (direcao > 0)
            {
                dir = "Ascendente";
            }
            else
            {
                dir = "Descendente";
            }

            LblInfos.Text = $"A velocidade do projetil é de {v0:F4}\n" +
                            $"Ele atinge o projetil em {tempo:F2} \n" +
                            $"E sua direção é {dir}\n";

            //Configurando o grafico
            var obj_chart = grafico.ChartAreas["ChartArea1"];

            obj_chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            obj_chart.AxisX.Minimum = 0;

            obj_chart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            obj_chart.AxisY.Minimum = 0;
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
            for (int x = 0; x <= distancia + 50; x++)
            {
                double y = x * Math.Tan(thetha) - (g * Math.Pow(x, 2)) / (2 * Math.Pow(v0 * Math.Cos(thetha), 2));

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
