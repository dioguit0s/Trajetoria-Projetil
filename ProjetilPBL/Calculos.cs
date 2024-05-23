using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilPBL
{
    internal class Calculos
    {
        
        //Calculos que serão usados durante o projeto
        const double g = 9.8;//Aceleração da gravidade





        //Gera o angulo minimo
        public static double CalcAnguloMinima(double distancia, double altura)
        {
            double thetaMin = Math.Atan((2 * altura) / distancia);
            double thetaMinGraus = thetaMin * (180 / Math.PI);
            return thetaMinGraus;
        }

        //Transforma graus em rad
        public static double TransGrausRad(double thethaMinGraus)
        {
            double thetha = thethaMinGraus * (180 / Math.PI);
            return thetha;
        }

        //Transforma de Graus para Rad
        public static double TransGrausRad(double thethaGraus)
        {
            double thetha = thethaGraus * (Math.PI/180);
            return thetha;
        }


        //Calculo velocidade projetil
        public static double VelocidadeMinima(double distancia, double altura, double theta)
        {
            double v0 = Math.Sqrt((g * distancia * distancia) / (2 * (distancia * Math.Tan(theta) - altura) * Math.Cos(theta) * Math.Cos(theta)));
            return v0;
        }

        //Calculo tempo de voo do projetil até o alvo
        public static double CalcTempo(double distancia, double v0, double theta)
        {
            double tempo = distancia / (v0 * Math.Cos(theta));
            return tempo;
        }

        //Calculo que descobre se o projetil está ascendente ou descendente
        public static string AscDesc(double tempo, double v0)
        {
            double vt = v0 - g * tempo;
            string direção;
            if (vt > 0)
            {
                direção = "O projétil atinge o alvo em ascendência.";
            }
            else
            {
                direção = "O projétil atinge o alvo em descendência.";
            }
            return direção;
        }
    }
}
