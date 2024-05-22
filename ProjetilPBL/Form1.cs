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
    public partial class Menu1 : Form
    {
        
        public static double distancia;
        public static double altura;


        public Menu1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        public void BtnGerarAngulo_Click(object sender, EventArgs e)
        {


            distancia = double.Parse(TxtDistancia.Text);
            altura = double.Parse(TxtAltura.Text);

            
            this.Hide();
            Menu2 menu2= new Menu2();
            menu2.Show();
            
           
        }
        
        public static double getDistancia()
        {
            
            return distancia;
        }
        public static double getAltura()
        {
            return altura;
        }
    }
}
