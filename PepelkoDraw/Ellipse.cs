using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PepelkoDraw {
    class Ellipse : GraphicalObject {

        public Ellipse(int sx, int sy, int ex, int ey, Color c, int penw)
            : base(sx, sy, ex, ey, c, penw) {
        }

        public override void Draw(Graphics g) {
            g.DrawEllipse(p, StartX, StartY, EndX - StartX, EndY - StartY);
        }
    }
}
