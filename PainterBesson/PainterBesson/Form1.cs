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
    public partial class Form1 : Form
    {
        Form2 ventanaDibujo = new Form2();
        List<Figura> dibujo = new List<Figura>();        
        
        public Form1()
        {
            InitializeComponent();
        }       

        private void btnCirculo_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grp = this.CreateGraphics();
            Circulo circulo = new Circulo();
            circulo.dibujar(grp);
            dibujo.Add(circulo);
        }

        private void btnCuadrado_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grp = this.CreateGraphics();
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.dibujar(grp);

            //Figura cuadrado = new Cuadrado();           
            //cuadrado  pictureBox1;

            //ventanaDibujo.MouseClick += pictureBox1_Paint();

            dibujo.Add(cuadrado);
        }        

        private void btnNuevo_MouseClick(object sender, MouseEventArgs e)
        {
            //Form2 ventanaDibujo = new Form2();            
            ventanaDibujo.Owner = this;
            ventanaDibujo.Show();            
            ventanaDibujo.Location = new Point(this.Location.X, this.Location.Y + this.ClientSize.Height + 30);
            ventanaDibujo.figuras = dibujo;
            //ventanaDibujo.Location = new Point(this.Location.X + this.ClientSize.Width, this.Location.Y);

            //AddOwnedForm(ventanaDibujo);
            //ventanaDibujo.Show();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            ventanaDibujo.Location = new Point(this.Location.X, this.Location.Y + this.ClientSize.Height + 30);
        }
    }
}
