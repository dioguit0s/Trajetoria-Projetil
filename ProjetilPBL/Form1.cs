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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Declara o objeto Graphics e define-o com o Graphics fornecido no PaintEventArgs.
            Graphics g = e.Graphics;

            // Simula a trajetória da bala (pode ser ajustada conforme necessário).
            float[] xPoints = { 10, 20, 30, 40, 50 }; // Exemplo de coordenadas X
            float[] yPoints = { 100, 90, 80, 70, 60 }; // Exemplo de coordenadas Y

            // Desenha a linha conectando os pontos.
            Pen pen = new Pen(Color.Red);
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);

            // Lembre-se de ajustar as coordenadas e os valores conforme a sua aplicação real.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }
    }
}
