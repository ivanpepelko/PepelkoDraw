using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PepelkoDraw {
    class Line : GraphicalObject {

        public Line(int sx, int sy, int ex, int ey, Color c, int penw)
            : base(sx, sy, ex, ey, c, penw) {
        }

        public override void Draw(System.Drawing.Graphics g) {
            g.DrawLine(p, StartX, StartY, EndX, EndY);
        }

    }
}
