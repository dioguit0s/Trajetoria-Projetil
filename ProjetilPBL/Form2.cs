using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetilPBL;

namespace ProjetilPBL
{
    public partial class Menu2 : Form
    {
        Program calculos = new Program();
        public static double thetaMinGraus;
        public static double theta;
        

        public Menu2()
        { 
            InitializeComponent();

            double distancia = Menu1.getDistancia();
            double altura = Menu1.getAltura();
            thetaMinGraus = Calculos.CalcAnguloMinima(distancia, altura);
            LblAngMinimo.Text = thetaMinGraus.ToString(); 

        }

        private void BtnGerarGrafico_Click(object sender, EventArgs e)
        {
            theta = double.Parse(TxtAngulo.Text);
            if (theta < thetaMinGraus)
            {
                MessageBox.Show("Insira um valor acima do minimo");
            } else 
            { 
                FormGrafico menu3 = new FormGrafico();
                this.Hide();
                menu3.Show();

            }
            

        }
        public static double getAngulo()
        {
            return theta;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
