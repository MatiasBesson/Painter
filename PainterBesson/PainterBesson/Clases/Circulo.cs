using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterBesson.Clases
{
    public class Circulo : Figura
    {
        Point pntIncio;
        Point pntFinal;

        public Circulo()
        {

        }
        public Circulo(Point inicio, Point final)
        {
            this.pntIncio = inicio;
            this.pntFinal = final;
        }

        public override void dibujar(Graphics grp)
        {
            grp.DrawEllipse(new Pen(Color.Blue), 160, 10, 40, 60);                        
            grp.Dispose();
        }
    }
}
