using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterBesson.Clases
{
    public class Cuadrado : Figura
    {
        public Cuadrado()
        {

        }
        public override void dibujar(Graphics grp)
        {
            grp.DrawRectangle(new Pen(Color.Black), 160, 70, 60, 60);
            grp.Dispose();
        }        
    }
}
