using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetilPBL
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu1());

            //Variaveis
         
        }
        //Calculos que serão usados durante o projeto
        const double g = 9.8;//Aceleração da gravidade


     
        

        //Gera o angulo minimo
        public double CalcAnguloMinima(double distancia, double altura)
        {
            double thetaMin = Math.Atan((2 * altura) / distancia);
            double thetaMinGraus = thetaMin * (180 / Math.PI);
            return thetaMinGraus;
        }

        //Calculo velocidade projetil
        public double VelocidadeMinima(double distancia, double altura, double theta)
        {
            double v0 = Math.Sqrt((g * distancia * distancia) / (2 * (distancia * Math.Tan(theta) - altura) * Math.Cos(theta) * Math.Cos(theta)));
            return v0;
        }

        //Calculo tempo de voo do projetil até o alvo
        public double CalcTempo(double distancia, double v0, double theta)
        {
            double tempo = distancia / (v0 * Math.Cos(theta));
            return tempo;
        }

        //Calculo que descobre se o projetil está ascendente ou descendente
        public double AscDesc(double tempo, double v0)
        {
            double vt = v0 - g * tempo;
            return vt;
        }
    }
}
