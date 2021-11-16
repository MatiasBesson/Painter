using PainterBesson.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterBesson
{
    public partial class Form2 : Form
    {
        public List<Figura> figuras = new List<Figura>();
        Point pntIncio;
        Point pntFinal;
        
        //public Cuadrado cuadrado = new Cuadrado();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {                  
            Graphics grp = this.CreateGraphics();
            foreach (Figura figura in figuras)
            {
                figura.dibujar(grp);
            }        

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics
            //Figura.dibujar(e.Graphics);
            //e.Graphics.DrawRectangle(new Pen(Color.Black), 160, 70, 60, 60);
            //
            // foreach (Figura figura in figuras)
            //{
            //    figura.dibujar(e.Graphics);
            //}
            //e.Graphics.Dispose(); 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
