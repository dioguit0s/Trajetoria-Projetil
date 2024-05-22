using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetilPBL
{
    public partial class FormGrafico : Form
    {
        const double g = 9.8;
        //trazendo variaveis necessarias para os calculos finais
        static double distancia = Menu1.getDistancia();
        static double altura = Menu1.getAltura();
        static double angulo = Menu2.getAngulo();



        public FormGrafico()
        {
            MessageBox.Show($"{distancia}\n{altura}\n{angulo}");

           double v0 = Math.Sqrt((g * distancia * distancia) / (2 * (distancia * Math.Tan(angulo) - altura) * Math.Cos(angulo) * Math.Cos(angulo)));

            // double tempo = Calculos.CalcTempo(distancia, velocidade, angulo);
            //double direcao = Calculos.AscDesc(tempo, velocidade);

            MessageBox.Show($"{v0}\n");

            InitializeComponent();
            /*LblTeste.Text = $"A velocidade do projetil é :{velocidade}\n" +
                            $"O tempo que o projetil demora até o alvo é: {tempo}" +
                            $"A direção do projetil é: {direcao} ";*/
        }

        

    }
}
