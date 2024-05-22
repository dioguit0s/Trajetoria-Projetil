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
        Menu1 medidas = new Menu1();
        
        

        public Menu2()
        { 
            InitializeComponent();

            double distancia = medidas.getDistancia();
            double altura = medidas.getAltura();
            double thetaMinGraus = calculos.CalcAnguloMinima(distancia, altura);
            LblAngMinimo.Text = medidas.getDistancia().ToString();

        }

        private void BtnGerarGrafico_Click(object sender, EventArgs e)
        {

            

        }
    }
}
