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
        static double thethaGraus = Menu2.getAngulo();

        //Transforma o angulo recebido pelo user em Rad
        static double thetha = Calculos.TransGrausRad(thethaGraus);



        public FormGrafico()
        {
            
            double v0 = Calculos.VelocidadeMinima(distancia, altura, thetha);
            double tempo = Calculos.CalcTempo(distancia, v0, thetha);
            string direcao = Calculos.AscDesc(tempo, v0);

            MessageBox.Show($"{v0:F2}\n{tempo:F1}\n{direcao}");

            InitializeComponent();
            LblTeste.Text = $"A velocidade do projetil é :{v0:F2}\n" +
                            $"O tempo que o projetil demora até o alvo é: {tempo:F1}\n" +
                            $"{direcao}";
        }

        

    }
}
